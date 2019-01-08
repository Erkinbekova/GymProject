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
    public partial class Subscribers : Form
    {
        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand cmd;
        private const String STOREDPROCEDURENAME = "ZHANEL.ADDSUBS";
        private const String ID_PARM = "pID";
        private const String FIELD1_PARM = "pName";
        private const String FIELD2_PARM = "pSurname";
        private const String FIELD3_PARM = "pBirth";
        private const String FIELD4_PARM = "pNumber";
        private const String FIELD5_PARM = "pGender";
        private const String FIELD6_PARM = "pDate";

        OracleDataAdapter adapter;
        DataTable table;
        public Subscribers()
        {
            InitializeComponent();
        }

        private void Subscribers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.SUB". При необходимости она может быть перемещена или удалена.
            this.sUBTableAdapter.Fill(this.dataGym.SUB);


        }

        private void btnAddSub_Click(object sender, EventArgs e)
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
            orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Date);
            orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD6_PARM, OracleDbType.Date);


            //orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Int32);
            orcmd.Parameters[FIELD1_PARM].Value = textBoxNam.Text;
            orcmd.Parameters[FIELD2_PARM].Value = textBoxSurname.Text;
            orcmd.Parameters[FIELD3_PARM].Value = dateTimePickerBirth.Value;
            orcmd.Parameters[FIELD4_PARM].Value = textBoxNumber.Text;
            orcmd.Parameters[FIELD5_PARM].Value = textBoxGender.Text;
            orcmd.Parameters[FIELD6_PARM].Value = dateTimePickerDate.Value;

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

        public void populate()
        {
            string selectQuery = "Select * from \"SUB\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridViewSub.DataSource = table;
        }

       

       

       

        private void btnDelSub_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM \"SUB\" where 'ID_АБОНЕМЕНТА'=" + int.Parse(txtId.Text);
                executeQuery(deleteQuery);

            }
            populate();
        }

        public void executeQuery(string query)
        {
            try
            {
                openConnection();
                cmd = new OracleCommand(query, orc);
                if (cmd.ExecuteNonQuery() == 1)
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

        private void btnEditSub_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }

        private void dataGridViewSub_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dataGridViewSub.CurrentRow.Cells[0].Value.ToString();
            textBoxNam.Text = dataGridViewSub.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridViewSub.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerBirth.Text = dataGridViewSub.CurrentRow.Cells[3].Value.ToString();
            textBoxNumber.Text = dataGridViewSub.CurrentRow.Cells[4].Value.ToString();
            textBoxGender.Text = dataGridViewSub.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerDate.Text = dataGridViewSub.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
    

