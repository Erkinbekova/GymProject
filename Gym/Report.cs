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
using CrystalDecisions.CrystalReports.Engine;

namespace Gym
{
    public partial class Report : Form
    {
        OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
        OracleCommand oracmd;

        public Report()
        {
            InitializeComponent();
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

        private void bntReport_Click(object sender, EventArgs e)
        {
            OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123 ");
            orc.Open();
            string query = "Select * from \"SEARCH\"";
            OracleDataAdapter da = new OracleDataAdapter(query, orc);
            DataSet2 ds = new DataSet2();
            da.Fill(ds, "SEARCH");
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load("CrystalReport4.rpt");
            rDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rDoc;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
