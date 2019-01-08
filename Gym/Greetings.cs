using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Greetings : Form
    {
        public Greetings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            
            this.Hide();
        }

        private void Greetings_Load(object sender, EventArgs e)
        {

        }
    }
}
