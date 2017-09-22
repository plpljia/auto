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
    public partial class UserForm : Form
    {
        private MysqlServer g_mMysqlServer = new MysqlServer();
        private const string g_strUserGroup_Operater = "Operater";
        private const string g_strUserGroup_PEAdmin = "PEAdmin";
        private const string g_strUserGroup_Administrator = "Administrator";

        private const string g_strProjectGroup_ISA3Project = "ISA3Project";

        public UserForm()
        {
            InitializeComponent();

        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            UserGroup_cbx.Items.Add(g_strUserGroup_Operater);
            UserGroup_cbx.Items.Add(g_strUserGroup_PEAdmin);
            UserGroup_cbx.Items.Add(g_strUserGroup_Administrator);

            ProjectGroup_cbx.Items.Add(g_strProjectGroup_ISA3Project);
        }

        private bool CheckParameterNotNull()
        {
            
            if (UserGroup_cbx.Text == "") { MessageBox.Show("UserGroup not select , please choose."); return false; }
            else if (UserName_txt.Text == "") { MessageBox.Show("User name not allow null , please fill in."); return false; }
            else if (FullName_txt.Text == "") { MessageBox.Show("Full name not allow null , please fill in."); return false; }
            else if (Password_txt.Text == "") { MessageBox.Show("User password not allow null , please fill in."); return false; }
            else if (ProjectGroup_cbx.Text == "") { MessageBox.Show("ProjectGroup not select , please choose."); return false; }
            else if (ProjectName_txt.Text == "") { MessageBox.Show("Project name not allow null , please fill in."); return false; }
            else
            {
                return true;
            }

        }

        private bool CheckParameterNull()
        {

            if (UserGroup_cbx.Text == "") { MessageBox.Show("UserGroup not select , please choose."); return true; }
            else if (UserName_txt.Text == "") { MessageBox.Show("User name not allow null , please fill in."); return true; }
            else if (FullName_txt.Text == "") { MessageBox.Show("Full name not allow null , please fill in."); return true; }
            else if (Password_txt.Text == "") { MessageBox.Show("User password not allow null , please fill in."); return true; }
            else if (ProjectGroup_cbx.Text == "") { MessageBox.Show("ProjectGroup not select , please choose."); return true; }
            else if (ProjectName_txt.Text == "") { MessageBox.Show("Project name not allow null , please fill in."); return true; }
            else
            {
                return false;
            }

        }

        private void CleanAllInputParameter()
        {
            UserName_txt.Text = "";
            FullName_txt.Text = "";
            Password_txt.Text = "";
            UserGroup_cbx.SelectedIndex = -1;
            ProjectGroup_cbx.SelectedIndex = -1;
            ProjectName_txt.Text = "";
        }

        private void RefreshOrSearch(object sender, EventArgs e)
        {
            DataTable l_dsResultDataTable = new DataTable();

            string l_strSelect = "";
            if (Search_txt.Text == "")
            {
                l_strSelect = "SELECT  `CreatTime`, `UserName`, `FullName`, `Password`, `UserGroup`, `ProjectGroup`, `Project` FROM `autoprogramerdb`.`users`  ";
            }
            else
            {
                l_strSelect = "SELECT  `CreatTime`, `UserName`, `FullName`, `Password`, `UserGroup`, `ProjectGroup`, `Project` FROM `autoprogramerdb`.`users`  "
                    + "WHERE `UserName`='" + Search_txt.Text + "'";
            }

            int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnData(l_strSelect, l_dsResultDataTable);
            if (l_iSqlState > 0)
            {
                User_DataGridView.DataSource = l_dsResultDataTable;
                User_DataGridView.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm:ss";
            }
            else
            {
                l_dsResultDataTable.Rows.Clear();
                User_DataGridView.DataSource = l_dsResultDataTable;
                //MessageBox.Show("Can't find the user.");
            }
            try
            {
                l_dsResultDataTable.Dispose();
            }
            catch { }        
        
        }

        private void User_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int l_iSeleteRow = User_DataGridView.CurrentRow.Index;
            try
            {
                UserName_txt.Text = User_DataGridView.Rows[l_iSeleteRow].Cells[1].Value.ToString();
                FullName_txt.Text = User_DataGridView.Rows[l_iSeleteRow].Cells[2].Value.ToString();
                Password_txt.Text = User_DataGridView.Rows[l_iSeleteRow].Cells[3].Value.ToString();
                string l_strUserGroup = User_DataGridView.Rows[l_iSeleteRow].Cells[4].Value.ToString();
                switch (l_strUserGroup)
                {
                    case g_strUserGroup_Operater:
                        UserGroup_cbx.SelectedIndex = 0;
                        break ;
                    case g_strUserGroup_PEAdmin:
                        UserGroup_cbx.SelectedIndex = 1;
                        break;
                    case g_strUserGroup_Administrator:
                        UserGroup_cbx.SelectedIndex = 2;
                        break;
                    default:
                        UserGroup_cbx.SelectedIndex = -1;
                        break;
                }
                string l_strProjectGroup = User_DataGridView.Rows[l_iSeleteRow].Cells[5].Value.ToString();
                switch (l_strProjectGroup)
                { 
                    case g_strProjectGroup_ISA3Project:
                        ProjectGroup_cbx.SelectedIndex = 0;
                        break;
                    default:
                        ProjectGroup_cbx.SelectedIndex = -1;
                        break;
                }
                ProjectName_txt.Text = User_DataGridView.Rows[l_iSeleteRow].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Exception , Please retry.");
            }

        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(UserGroup_cbx.Text);
            if (CheckParameterNull()) return;
            else
            {
                string l_strSelect = "SELECT  `UserName` FROM `autoprogramerdb`.`users`  "
                                     + "WHERE `UserName`='" + UserName_txt.Text + "'";
                int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnRow(l_strSelect);
                if (l_iSqlState > 0)
                {
                    MessageBox.Show("User name already exist,please use another name.");
                    return;
                }


                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to add the user :" + UserName_txt.Text, "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "INSERT INTO `autoprogramerdb`.`users` (`CreatTime`, `UserName`, `FullName`, `Password`, `UserGroup`, `ProjectGroup`, `Project`) "
                                      + "VALUES (NOW(), "
                                      + "'" + UserName_txt.Text + "', "
                                      + "'" + FullName_txt.Text + "', "
                                      + "'" + Password_txt.Text + "', "
                                      + "'" + UserGroup_cbx.Text + "', "
                                      + "'" + ProjectGroup_cbx.Text + "', "
                                      + "'" + ProjectName_txt.Text + "') ";
                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Add user : " + UserName_txt.Text + ", Success.");
                        RefreshOrSearch(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Add user fail,please retry.");
                    }
                }

            }
        }

        private void DelUser_btn_Click(object sender, EventArgs e)
        {
            if (UserName_txt.Text=="") 
            {
                MessageBox.Show("User name not allow null , please fill in.");
                return;
            }
            else
            {

                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to delete the user :" + UserName_txt.Text, "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "DELETE   FROM `autoprogramerdb`.`users` "
                                      + "WHERE `UserName`='" + UserName_txt.Text + "'";

                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Delete user : " + UserName_txt.Text + ", Success.");

                        CleanAllInputParameter();

                        RefreshOrSearch(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Can't find the user to delete,please select another one.");
                    }
                }

            }

        }

        private void UpdateUser_btn_Click(object sender, EventArgs e)
        {
            if (CheckParameterNull()) return;
            else
            {
                string l_strSelect = "SELECT  `UserName` FROM `autoprogramerdb`.`users`  "
                                     + "WHERE `UserName`='" + UserName_txt.Text + "'";
                int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnRow(l_strSelect);
                if (l_iSqlState <= 0)
                {
                    MessageBox.Show("User name not exist,can't update.");
                    return;
                }

                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to update the user :" + UserName_txt.Text, "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "UPDATE  `autoprogramerdb`.`users` SET "
                                      +  "`UserName`="  + "'" + UserName_txt.Text + "', "
                                      +  "`FullName`="  + "'" + FullName_txt.Text + "', "
                                      +  "`Password`="  + "'" + Password_txt.Text + "', "
                                      +  "`UserGroup`=" + "'" + UserGroup_cbx.Text + "', "
                                      +  "`ProjectGroup`="+ "'" + ProjectGroup_cbx.Text + "', "
                                      +  "`Project`="   + "'"  + ProjectName_txt.Text + "' "
                                      +  " WHERE `UserName`='" + UserName_txt.Text + "'";

                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Update user : " + UserName_txt.Text + ", Success.");
                        RefreshOrSearch(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Update user fail,please retry.");
                    }
                }

            }
        }


        private void RemoveProject_btn_Click(object sender, EventArgs e)
        {
            if (CheckParameterNull()) return;
            else
            {
                string l_strSelect = "SELECT  `UserName` FROM `autoprogramerdb`.`users`  "
                                     + "WHERE `UserName`='" + UserName_txt.Text + "'";
                int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnRow(l_strSelect);
                if (l_iSqlState <= 0)
                {
                    MessageBox.Show("User name not exist,please choose another one.");
                    return;
                }

                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to remove the user :" + UserName_txt.Text + " Project", "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "UPDATE  `autoprogramerdb`.`users` SET "
                                      + "`UserName`=" + "'" + UserName_txt.Text + "', "
                                      + "`FullName`=" + "'" + FullName_txt.Text + "', "
                                      + "`Password`=" + "'" + Password_txt.Text + "', "
                                      + "`UserGroup`=" + "'" + UserGroup_cbx.Text + "', "
                                      + "`ProjectGroup`=" + "'" + "" + "', "
                                      + "`Project`=" + "'" + "" + "' "
                                      + " WHERE `UserName`='" + UserName_txt.Text + "'";

                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Remove user : " + UserName_txt.Text + " project, Success.");
                        RefreshOrSearch(sender, e);
                        ProjectGroup_cbx.SelectedIndex = -1;
                        ProjectName_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Remove user project fail,please retry.");
                    }
                }

            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            //UserGroup_cbx.SelectedIndex = 1;
            RefreshOrSearch(sender,  e);

        }

        private void ProjectName_txt_Click(object sender, EventArgs e)
        {
            //CheckParemeterNotNull();
            if (ProjectGroup_cbx.Text == "")
            {
                MessageBox.Show("ProjectGroup not select , please choose."); 
                return;
            }
 
            ProjectSelectForm l_mProjectSelectForm = new ProjectSelectForm();
            l_mProjectSelectForm.g_strProjectGroup_ = ProjectGroup_cbx.SelectedItem.ToString();
            l_mProjectSelectForm.ShowDialog();
            ProjectName_txt.Text = l_mProjectSelectForm.g_strProjectName__;
            l_mProjectSelectForm.Dispose();
            //MessageBox.Show(l_mProjectSelectForm.g_strProjectName__);
            
        }













    }
}
