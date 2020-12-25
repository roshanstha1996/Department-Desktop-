using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace DepartmentalStoreApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        BusinessLogicClass blc = new BusinessLogicClass();
        UserClass uc = new UserClass();
        public int UserId;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please provide User Name");
            }            
            else if (txtPassword.Text == "")
            { MessageBox.Show("Please provide Password"); }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password you enter did not match");
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            else if (txtCreatedBy.Text == "")
            { MessageBox.Show("Please provide Created By"); }
            else
            {
                try
                {
                    bool result = blc.ManageUser(0,
                        txtUserName.Text,
                        txtPassword.Text,
                        cmbRole.Text,
                        txtCreatedBy.Text,
                        dtpCreatedDate.Text,
                        cmbIsActive.Text,
                        1);
                    if (result == true)
                    {
                        MessageBox.Show("User Successfully Added");
                        dgvUsers.DataSource = uc.GetAllUsers();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in creating user");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please provide User Name");
            }
            else if (txtPassword.Text == "")
            { MessageBox.Show("Please provide Password"); }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password you enter did not match");
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            else if (txtCreatedBy.Text == "")
            { MessageBox.Show("Please provide Created By"); }
            else
            {
                try
                {
                    bool result = blc.ManageUser(UserId,
                        txtUserName.Text,
                        txtPassword.Text,
                        cmbRole.Text,
                        txtCreatedBy.Text,
                        dtpCreatedDate.Text,
                        cmbIsActive.Text,
                        2);
                    if (result == true)
                    {
                        MessageBox.Show("User Successfully Updated");
                        dgvUsers.DataSource = uc.GetAllUsers();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating user");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please provide User Name");
            }
            else if (txtPassword.Text == "")
            { MessageBox.Show("Please provide Password"); }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password you enter did not match");
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            else if (txtCreatedBy.Text == "")
            { MessageBox.Show("Please provide Created By"); }
            else
            {
                try
                {
                    bool result = blc.ManageUser(UserId,
                        txtUserName.Text,
                        txtPassword.Text,
                        cmbRole.Text,
                        txtCreatedBy.Text,
                        dtpCreatedDate.Text,
                        cmbIsActive.Text,
                        3);
                    if (result == true)
                    {
                        MessageBox.Show("User Successfully Deleted");
                        dgvUsers.DataSource = uc.GetAllUsers();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting user");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value.ToString());
                txtUserName.Text = dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
                txtPassword.Text = dgvUsers.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbRole.Text = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
                txtCreatedBy.Text = dgvUsers.SelectedRows[0].Cells["CreatedBy"].Value.ToString();
                dtpCreatedDate.Text = dgvUsers.SelectedRows[0].Cells["CreatedDate"].Value.ToString();
                cmbIsActive.Text = dgvUsers.SelectedRows[0].Cells["IsActive"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           dgvUsers.DataSource = uc.GetAllUsers();
        }
    }
}
