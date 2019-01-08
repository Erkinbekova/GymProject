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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.STAFF". При необходимости она может быть перемещена или удалена.
            this.sTAFFTableAdapter.Fill(this.dataGym.STAFF);

        }


        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;
        private const String STOREDPROCEDURENAME = "ZHANEL.ADDSTAFF";

        private const String ID_PARM = "pID_staff";
        private const String FIELD1_PARM = "pTitle";
        private const String FIELD2_PARM = "pOklad";
        private const String FIELD3_PARM = "pEducation";
        private const String FIELD4_PARM = "pExperience";
       

        OracleDataAdapter adapter;
        DataTable table;




        public void populate()
        {
            string selectQuery = "Select * from \"STAFF\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridStaff.DataSource = table;
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



        private void btnAddStaff_Click(object sender, EventArgs e)
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
            orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Varchar2, 50);
           
            orcmd.Parameters[FIELD1_PARM].Value = textBoxTitle.Text;
            orcmd.Parameters[FIELD2_PARM].Value = textBoxSalary.Text;
            orcmd.Parameters[FIELD3_PARM].Value = textBoxEducation.Text;
            orcmd.Parameters[FIELD4_PARM].Value = textBoxExperience.Text;
           

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

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM \"STAFF\" where ID_ДОЛЖНОСТИ=" + int.Parse(textBoxId.Text);
                executeMyQuery(deleteQuery);

            }
            populate();
        }

        private void dataGridStaff_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dataGridStaff.CurrentRow.Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridStaff.CurrentRow.Cells[1].Value.ToString();
            textBoxSalary.Text = dataGridStaff.CurrentRow.Cells[2].Value.ToString();
            textBoxEducation.Text = dataGridStaff.CurrentRow.Cells[3].Value.ToString();
            textBoxExperience.Text = dataGridStaff.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
