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
    public partial class MachineForm : Form
    {
        private MysqlServer g_mMysqlServer = new MysqlServer();

        public MachineForm()
        {
            InitializeComponent();
        }

        private void RefreshOrSearch(object sender, EventArgs e)
        {
            DataTable l_dsResultDataTable = new DataTable();

            string l_strSelect = "SELECT `CreatTime`, `PCMachineName`, `Comment` FROM `autoprogramerdb`.`machine`";

            int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnData(l_strSelect, l_dsResultDataTable);
            if (l_iSqlState > 0)
            {
                Machine_DataGridView.DataSource = l_dsResultDataTable;
                Machine_DataGridView.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm:ss";
            }
            else
            {
                l_dsResultDataTable.Rows.Clear();
                Machine_DataGridView.DataSource = l_dsResultDataTable;
                MessageBox.Show("Can't find Machine name,please retry.");
            }
            try
            {
                l_dsResultDataTable.Dispose();
            }
            catch 
            {
                MessageBox.Show("Exception,please retry.");
            }

        }

        private void MachineForm_Load(object sender, EventArgs e)
        {
            RefreshOrSearch(sender, e);
        }

        private void Machine_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int l_iSeleteRow = Machine_DataGridView.CurrentRow.Index;
            try
            {
                MachineName_txt.Text = Machine_DataGridView.Rows[l_iSeleteRow].Cells[1].Value.ToString();
                Comment_txt.Text = Machine_DataGridView.Rows[l_iSeleteRow].Cells[2].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Exception , Please retry.");
            }
        }
        
        //SELECT `ID`, `CreatTime`, `PCMachineName`, `Comment` FROM `autoprogramerdb`.`machine` WHERE  `PCMachineName`='1';
        private void AddMachine_btn_Click(object sender, EventArgs e)
        {
            if (MachineName_txt.Text == "")
            {
                MessageBox.Show("Please fill a machine name.");
                return;
            }
            if (Comment_txt.Text == "")
            {
                MessageBox.Show("Please fill a comment.");
                return;
            }
            else
            {
                string l_strSelect = "SELECT `CreatTime`, `PCMachineName`, `Comment` FROM `autoprogramerdb`.`machine`  "
                                     + "WHERE `PCMachineName`='" + MachineName_txt.Text + "'";
                int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnRow(l_strSelect);
                if (l_iSqlState > 0)
                {
                    MessageBox.Show("Machine name have already exist");
                    return;
                }


                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to add the machine name : " + MachineName_txt.Text, "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "INSERT INTO `autoprogramerdb`.`machine` (`CreatTime`, `PCMachineName`, `Comment`) "
                                      + "VALUES (NOW(), "
                                      + "'" + MachineName_txt.Text + "', "
                                      + "'" + Comment_txt.Text + "') ";
                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Add machine name : " + MachineName_txt.Text + ", Success.");
                        RefreshOrSearch(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Add machine name fail,please retry.");
                    }
                }

            }
        }



        private void DelMachine_btn_Click(object sender, EventArgs e)
        {
            if (MachineName_txt.Text == "")
            {
                MessageBox.Show("Please fill a machine name.");
                return;
            }
            if (Comment_txt.Text == "")
            {
                MessageBox.Show("Please fill a comment.");
                return;
            }
            else
            {
                DialogResult l_mDialogResult = MessageBox.Show("Are you sure to delete the machine name :" + MachineName_txt.Text, "", MessageBoxButtons.OKCancel);
                if (l_mDialogResult == DialogResult.OK)
                {
                    string l_strInsert = "DELETE   FROM `autoprogramerdb`.`machine` "
                                      + "WHERE `PCMachineName`='" + MachineName_txt.Text + "'";

                    int l_iSqlStateInsert = g_mMysqlServer.mysqlSendCmdNonQuery(l_strInsert);
                    if (l_iSqlStateInsert > 0)
                    {
                        MessageBox.Show("Delete machine name : " + MachineName_txt.Text + ", Success.");

                        MachineName_txt.Text = "";
                        Comment_txt.Text =
                            "";
                        RefreshOrSearch(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Can't find the machine name to delete,please select another one.");
                    }
                }

            }


        }


    }
}
