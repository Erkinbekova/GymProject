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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123");
            OracleDataAdapter orada = new OracleDataAdapter("Select Count(*) from \"EMPLOYEE\" where 'РОЛЬ' = 'Админ' and ИМЯ = '" + logUserName.Text + "' and ID_СОТРУДНИКА = '" + logPassword.Text + "'", orc);
            DataTable dt = new DataTable();
            orada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenu main = new MainMenu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            OracleConnection orc = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ZHANEL; Password = 123");
           // OracleDataAdapter orada = new OracleDataAdapter("Select Count(*) from \"EMPLOYEE\" where 'РОЛЬ' = 'Админ' and 'ИМЯ' = '" + logUserName.Text + "' and 'ID_СОТРУДНИКА' = '" + logPassword.Text + "'" , orc);
            OracleDataAdapter orada = new OracleDataAdapter("Select Count(*) from \"EMPLOYEE\"" + "where РОЛЬ = 'Админ'"+ " and ИМЯ = '" +logUserName.Text + "' and ID_D = " + logPassword.Text, orc);
            DataTable dt = new DataTable();
            orada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenu main = new MainMenu();
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check your Username or Password");
            }

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
