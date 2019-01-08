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
    public partial class Group : Form
    {
        private const String STOREDPROCEDURENAME = "ZHANEL.ADDGROUP";
        private const String ID_PARM = "pID_GRP";
        private const String FIELD1_PARM = "pTitle";
        private const String FIELD2_PARM = "pType";
        DataTable table;
        OracleDataAdapter adapter;
        OracleCommand cmd;
        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");

        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.GRP". При необходимости она может быть перемещена или удалена.
            this.gRPTableAdapter.Fill(this.dataGym.GRP);

        }

        private void dataGridGroup_MouseClick(object sender, MouseEventArgs e)
        {
            deleteID.Text = dataGridGroup.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");

            //OracleDataAdapter orada = new OracleDataAdapter("Insert into \"Service\" (service_id, name, value, time_of_spending) values ('" + input_ser_id.Text  + "','" + Input_name.Text + "','" + Input_price.Text + "','" + Input_desc.Text + ");", orc);
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = orc;
            cmd.CommandText = STOREDPROCEDURENAME;
            cmd.CommandType = CommandType.StoredProcedure;
            // Add the parameters and set values for them.
            cmd.Parameters.Add(ID_PARM, OracleDbType.Int32).Direction =
               ParameterDirection.Output;
            cmd.Parameters.Add(FIELD1_PARM, OracleDbType.Varchar2);
            cmd.Parameters.Add(FIELD2_PARM, OracleDbType.Varchar2);
            

            cmd.Parameters[FIELD1_PARM].Value = textBoxTitle.Text;
            cmd.Parameters[FIELD2_PARM].Value = textBoxType.Text;
           

            // Execute the insert query.
            orc.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
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

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder ocb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }
        public void populate()
        {
            string selectQuery = "Select * from \"GRP\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridGroup.DataSource = table;

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

        private void buttonDelGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deleteQuery = "delete from \"GRP\" where 'ID_ГРУППЫ' = " + int.Parse(deleteID.Text);
                executeQuery(deleteQuery);
            }
            populate();
        }
    }
}
