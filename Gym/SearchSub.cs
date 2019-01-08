using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using CrystalDecisions.CrystalReports.Engine;

namespace Gym
{
    public partial class SearchSub : Form
    {
        public SearchSub()
        {
            InitializeComponent();
        }

        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;
        OracleDataAdapter adapter;
        DataTable table;
       
        public void populate()
        {
            string selectQuery = "Select * FROM SEARCH";

            table = new DataTable();
            adapter = new OracleDataAdapter(selectQuery, orc);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            populate();
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

        private void SearchSub_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.SEARCH". При необходимости она может быть перемещена или удалена.
            this.sEARCHTableAdapter.Fill(this.dataSet2.SEARCH);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SEARCHFORSUB". При необходимости она может быть перемещена или удалена.
            this.sEARCHFORSUBTableAdapter.Fill(this.dataSet1.SEARCHFORSUB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.GRP". При необходимости она может быть перемещена или удалена.
            this.gRPTableAdapter.Fill(this.dataGym.GRP);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataGym.SUB". При необходимости она может быть перемещена или удалена.
            this.sUBTableAdapter.Fill(this.dataGym.SUB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new OracleDataAdapter("Select * from ZHANEL.SEARCH where ИМЯ like'" + textBox1.Text + "%' ", orc);
            table = new DataTable();
            adapter.Fill(table);         
            dataGridView1.DataSource = table;
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
