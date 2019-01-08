using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Gym
{
    public partial class Empl : Form
    {
        public Empl()
        {
            InitializeComponent();
        }

        private void Empl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEETableAdapter.Fill(this.dataGym.EMPLOYEE);

        }

        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;
        private const String STOREDPROCEDURENAME = "ZHANEL.ADDEMP";

        private const String ID_PARM = "pID_employee";
        private const String FIELD1_PARM = "pName";
        private const String FIELD2_PARM = "pSurname";
        private const String FIELD3_PARM = "pNumber";
        private const String FIELD4_PARM = "pId_d";
        private const String FIELD5_PARM = "pRole";


        OracleDataAdapter adapter;
        DataTable table;




        public void populate()
        {
            string selectQuery = "Select * from \"EMPLOYEE\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridEmp.DataSource = table;
        }

        public void openConnection()
        {
            if (orc.State == ConnectionState.Closed)
            {
                orc.Open();
            }
        }
        public void closeConnection()
        {
            if (orc.State == ConnectionState.Open)
            {
                orc.Close();
            }
        }


        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                oracmd = new OracleCommand(query, orc);
                if (oracmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query EXecuted");
                }
                else
                {
                    MessageBox.Show("Query non EXecuted");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void dataGridEmp_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dataGridEmp.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridEmp.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridEmp.CurrentRow.Cells[2].Value.ToString();
            textBoxNumber.Text = dataGridEmp.CurrentRow.Cells[3].Value.ToString();
            textBoxId_d.Text = dataGridEmp.CurrentRow.Cells[4].Value.ToString();
            textBoxRole.Text = dataGridEmp.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            OracleCommand orcmd = new OracleCommand();
            orcmd.Connection = orc;
            orcmd.CommandText = STOREDPROCEDURENAME;
            orcmd.CommandType = CommandType.StoredProcedure;
            // Add the parameters and set values for them.
            orcmd.Parameters.Add(ID_PARM, OracleDbType.Int32).Direction =
                ParameterDirection.Output;
            orcmd.Parameters.Add(FIELD1_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD2_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Int32);
            orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Varchar2, 50);

            orcmd.Parameters[FIELD1_PARM].Value = textBoxName.Text;
            orcmd.Parameters[FIELD2_PARM].Value = textBoxSurname.Text;
            orcmd.Parameters[FIELD3_PARM].Value = textBoxNumber.Text;
            orcmd.Parameters[FIELD4_PARM].Value = textBoxId_d.Text;
            orcmd.Parameters[FIELD5_PARM].Value = textBoxRole.Text;


            // Execute the insert query.
            orc.Open();
            try
            {
                orcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Oracle Sequence Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                orc.Close();
            }
            populate();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM \"EMPLOYEE\" where ID_СОТР=" + int.Parse(textBoxId.Text);
                executeMyQuery(deleteQuery);

            }
            populate();
        }
    }
}

