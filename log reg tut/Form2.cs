using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log_reg_tut
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == Properties.Settings.Default.username && passwordbox.Text == Properties.Settings.Default.password)
            {
                MessageBox.Show("login succesful");
                await Task.Delay(1000);
                this.Hide();
                Form3 home = new Form3();
                home.Show();
            }
            else
            {
                MessageBox.Show("wrong password or username");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
