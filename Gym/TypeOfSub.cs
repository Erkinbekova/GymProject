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
    public partial class TypeOfSub : Form
    {
        public TypeOfSub()
        {
            InitializeComponent();
        }

        private void TypeOfSub_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.TYPE_SUB". При необходимости она может быть перемещена или удалена.
            this.tYPE_SUBTableAdapter.Fill(this.dataGym.TYPE_SUB);

        }


        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;
        private const String STOREDPROCEDURENAME = "ZHANEL.AddTypeSub";
        private const String FIELD1_PARM = "pType";
        private const String FIELD2_PARM = "pPrice";
        private const String FIELD3_PARM = "pDiscount";
        private const String FIELD4_PARM = "pTimeFrom";
        private const String FIELD5_PARM = "pTimeTo";
        private const String FIELD6_PARM = "pID_АБ";
        private const String FIELD7_PARM = "pID_G";
      
        OracleDataAdapter adapter;
        DataTable table;
        
       

       
        public void populate()
        {
            string selectQuery = "Select * from \"TYPE_SUB\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridTypeOfSub.DataSource = table;
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
        
       

        private void btnAddType_Click(object sender, EventArgs e)
        {
            
            OracleCommand orcmd = new OracleCommand();
            orcmd.Connection = orc;
            orcmd.CommandText = STOREDPROCEDURENAME;
            orcmd.CommandType = CommandType.StoredProcedure;
            // Add the parameters and set values for them.
            
            orcmd.Parameters.Add(FIELD1_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD2_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Varchar2, 50);
            orcmd.Parameters.Add(FIELD6_PARM, OracleDbType.Int32);
            orcmd.Parameters.Add(FIELD7_PARM, OracleDbType.Int32);
           
           
            orcmd.Parameters[FIELD1_PARM].Value = textBoxType.Text;
            orcmd.Parameters[FIELD2_PARM].Value = textBoxPrice.Text;
            orcmd.Parameters[FIELD3_PARM].Value = textBoxDiscount.Text;
            orcmd.Parameters[FIELD4_PARM].Value = textBoxTimeFrom.Text;
            orcmd.Parameters[FIELD5_PARM].Value = textBoxTimeTo.Text;
            orcmd.Parameters[FIELD6_PARM].Value = textBoxIdSub.Text;
            orcmd.Parameters[FIELD7_PARM].Value = textBoxIdGroup.Text;
           

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

    
        private void dataGridTypeOfSub_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxType.Text = dataGridTypeOfSub.CurrentRow.Cells[0].Value.ToString();
            textBoxPrice.Text = dataGridTypeOfSub.CurrentRow.Cells[1].Value.ToString();
            textBoxDiscount.Text = dataGridTypeOfSub.CurrentRow.Cells[2].Value.ToString();
            textBoxTimeFrom.Text = dataGridTypeOfSub.CurrentRow.Cells[3].Value.ToString();
            textBoxTimeTo.Text = dataGridTypeOfSub.CurrentRow.Cells[4].Value.ToString();
            textBoxIdSub.Text = dataGridTypeOfSub.CurrentRow.Cells[5].Value.ToString();
            textBoxIdGroup.Text = dataGridTypeOfSub.CurrentRow.Cells[6].Value.ToString();
          //  cmbCategory.Text = dataGridTypeOfSub.CurrentRow.Cells[9].Value.ToString();
           
        }
        private void btnEditType_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM \"TYPE_SUB\" where ID_АБ=" + int.Parse(textBoxIdSub.Text);
                executeMyQuery(deleteQuery);

            }
            populate();
        }

       
    }
}
