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
    public partial class Form1 : Form
    {
        bool pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        void SaveSettings()
        {
            Properties.Settings.Default.username = usernamebox.Text;
            Properties.Settings.Default.gmail = gmailbox.Text;
            Properties.Settings.Default.password = passwordbox.Text;
            Properties.Settings.Default.register = pressed;

            Properties.Settings.Default.Save();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.TextLength != 0 && gmailbox.TextLength != 0 && passwordbox.TextLength != 0)
            {
                pressed = true;
                SaveSettings();
                await Task.Delay(2000);
                this.Hide();
                Form2 login = new Form2();
                login.Show();
            }
            else
            {
                MessageBox.Show("cant be empty");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
