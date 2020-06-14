using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        //Mouse LOC
        public Point mouseloc;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || txtUserName.Text == "Username")
            {
                MessageBox.Show("Username is empty!", "Error");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
            {
                MessageBox.Show("Password is empty!", "Error");
                return;
            }
            //test
            FormMainMenu main = new FormMainMenu(this, checkBoxStaff.Checked);
            this.Visible = false;
            main.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseloc = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    (this.Location.X - mouseloc.X) + e.X, (this.Location.Y - mouseloc.Y) + e.Y);
                this.Update();
            }
        }


        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtUserName.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '•';
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            panel3.BackColor = Color.White;
            txtUserName.ForeColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Clear();
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txtUserName.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
        }



    }
}
