using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoProgramer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (UserName_txt.Text == "admin" && Password_txt.Text == "admin")
            {
                ProjectManager_btn.Visible = true;
                MachineManager_btn.Visible = true;
                UserManager_btn.Visible = true;
                LogView_btn.Visible = true;
                LocalSetting.Visible = true;
                SelectProgramer.Visible = true;
            }

        }

        private void Password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_btn_Click(sender, e);
            }
        }

        private void ProjectManager_btn_Click(object sender, EventArgs e)
        {
            ProjectManagerForm l_mProjectManagerForm = new ProjectManagerForm();
            l_mProjectManagerForm.ShowDialog();
        }

        private void MachineManager_btn_Click(object sender, EventArgs e)
        {
            MachineForm l_mMachineForm = new MachineForm();
            l_mMachineForm.ShowDialog();

        }

        private void UserManager_btn_Click(object sender, EventArgs e)
        {
            UserForm l_mUserForm = new UserForm();
            l_mUserForm.ShowDialog();
        }


    }
}
