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
    public partial class MainMenu : Form
    {
        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;
        private const String STOREDPROCEDURENAME = "ZHANEL.ADDSCHEDULE";
       // private const String ID_PARM = "pID";
        private const String FIELD1_PARM = "pTime";
        private const String FIELD2_PARM = "pIdGroup";
        private const String FIELD3_PARM = "pIdEmployee";
        private const String FIELD4_PARM = "pIdStaff";
    

        OracleDataAdapter adapter;
        DataTable table;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void абонементыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subscribers subs = new Subscribers();
           // subs.MdiParent = this;
            subs.StartPosition = FormStartPosition.CenterScreen;
            subs.Show();
        }

        private void видАбонементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfSub tsubs = new TypeOfSub();
            // subs.MdiParent = this;
            tsubs.StartPosition = FormStartPosition.CenterScreen;
            tsubs.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            // subs.MdiParent = this;
            group.StartPosition = FormStartPosition.CenterScreen;
            group.Show();
        }

        private void тренажерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            // subs.MdiParent = this;
            equipment.StartPosition = FormStartPosition.CenterScreen;
            equipment.Show();
        }

        private void штатноеРаспиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            // subs.MdiParent = this;
            staff.StartPosition = FormStartPosition.CenterScreen;
            staff.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empl employee = new Empl();
            // subs.MdiParent = this;
            employee.StartPosition = FormStartPosition.CenterScreen;
            employee.Show();
        }
        private void поискПоАбонементуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSub searchsub = new SearchSub();
            // subs.MdiParent = this;
            searchsub.StartPosition = FormStartPosition.CenterScreen;
            searchsub.Show();
        }

        private void распечататьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            // subs.MdiParent = this;
            report.StartPosition = FormStartPosition.CenterScreen;
            report.Show();
        }

        public void populate()
        {
            string selectQuery = "Select * from \"SCHEDULE\"";
            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridViewSchedule.DataSource = table;

        }

       

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Journal". При необходимости она может быть перемещена или удалена.
            //this.journalTableAdapter.Fill(this.dataSet2.Journal);
           // populate();
            this.sCHEDULETableAdapter.Fill(this.dataGym.SCHEDULE);

        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            OracleCommand orcmd = new OracleCommand();
            orcmd.Connection = orc;
            orcmd.CommandText = STOREDPROCEDURENAME;
            orcmd.CommandType = CommandType.StoredProcedure;
            // Add the parameters and set values for them.
          //  orcmd.Parameters.Add(ID_PARM, OracleDbType.Int32).Direction =
                //  ParameterDirection.Output;
            orcmd.Parameters.Add(FIELD1_PARM, OracleDbType.Date);
            orcmd.Parameters.Add(FIELD2_PARM, OracleDbType.Int32);
            orcmd.Parameters.Add(FIELD3_PARM, OracleDbType.Int32);
            orcmd.Parameters.Add(FIELD4_PARM, OracleDbType.Int32);
           


            //orcmd.Parameters.Add(FIELD5_PARM, OracleDbType.Int32);
            orcmd.Parameters[FIELD1_PARM].Value = dateTimePicker1.Value;
            orcmd.Parameters[FIELD2_PARM].Value = textBoxGroup.Text;
            orcmd.Parameters[FIELD3_PARM].Value = textBoxEmployee.Text;
            orcmd.Parameters[FIELD4_PARM].Value = textBoxStaff.Text;
            

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
            // Retrieve and display the sequence value.
            //int sequenceValue = (int)orcmd.Parameters[CODE].Value;
            //MessageBox.Show("Inserted record with ID = " + sequenceValue,
            // "Retrieving Oracle Sequence Values", MessageBoxButtons.OK,
            //MessageBoxIcon.Information);

        }

        private void editSchedule_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder orb = new OracleCommandBuilder(adapter);
            adapter.Update(table);
            populate();
        }

        /*   private void MainMenu_Load_1(object sender, EventArgs e)
           {
               // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.SCHEDULE". При необходимости она может быть перемещена или удалена.
               this.sCHEDULETableAdapter.Fill(this.dataGym.SCHEDULE);

           }*/


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
        
      

        private void delSchedule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string deleteQuery = "DELETE FROM \"SCHEDULE\" where 'ВРЕМЯ'=" + DateTime.Parse(dateTimePicker1.Text);
                executeMyQuery(deleteQuery);

            }
            populate();
        }

        private void dataGridViewSchedule_MouseClick(object sender, MouseEventArgs e)
        {
          //  txtId.Text = dataGridViewSchedule.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridViewSchedule.CurrentRow.Cells[0].Value.ToString();
            textBoxGroup.Text = dataGridViewSchedule.CurrentRow.Cells[1].Value.ToString();
            textBoxEmployee.Text = dataGridViewSchedule.CurrentRow.Cells[2].Value.ToString();
            textBoxStaff.Text = dataGridViewSchedule.CurrentRow.Cells[3].Value.ToString();
           
          

        }

       
    }
}
