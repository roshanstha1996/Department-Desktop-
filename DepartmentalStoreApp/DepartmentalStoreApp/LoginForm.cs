using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;  

namespace DepartmentalStoreApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        BusinessLogicClass blc = new BusinessLogicClass();

        //Closes the form when Escape key is pressed
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = blc.Login(txtUserName.Text, txtPassword.Text);
                if (x == true)
                {
                    MessageBox.Show("You are logged into the system");
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
