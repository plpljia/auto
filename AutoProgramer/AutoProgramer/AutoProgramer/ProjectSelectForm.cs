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
    public partial class ProjectSelectForm : Form
    {
        private MysqlServer g_mMysqlServer = new MysqlServer();
        public string g_strProjectGroup_;
        public string g_strProjectName__;
        public ProjectSelectForm()
        {
            InitializeComponent();
        }


        private void RefreshOrSearch(object sender, EventArgs e)
        {
            DataTable l_dsResultDataTable = new DataTable();

            string l_strSelect = "";
            if (Search_txt.Text == "")
            {
                if (Barcode_cbx.Checked == true)
                {
                    l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`"
                                + g_strProjectGroup_ + "` "
                                + "WHERE `BarcodeEnable`='1'";
                }
                else
                {
                    l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`"
                               + g_strProjectGroup_ + "` "
                               + "WHERE `BarcodeEnable`='0'";               
                }
            }
            else
            {
                if (Barcode_cbx.Checked == true)
                {
                    l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`"
                                + g_strProjectGroup_ + "` "
                                + "WHERE `Project`='" + Search_txt.Text + "'"
                                + " and `BarcodeEnable`='1'";
                }
                else
                {
                    l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`"
                                + g_strProjectGroup_ + "` "
                                + "WHERE `Project`='" + Search_txt.Text + "'"
                                + " and `BarcodeEnable`='0'";               
                }
            }

            int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnData(l_strSelect, l_dsResultDataTable);
            if (l_iSqlState > 0)
            {
                Project_DataGridView.DataSource = l_dsResultDataTable;
                Project_DataGridView.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd  HH:mm:ss";
            }
            else
            {
                l_dsResultDataTable.Rows.Clear();
                Project_DataGridView.DataSource = l_dsResultDataTable;
                MessageBox.Show("Can't find the project.");
            }
            try
            {
                l_dsResultDataTable.Dispose();
            }
            catch { }
            //g_strProjectName__ = "This a from answer";
           // MessageBox.Show(g_strProjectGroup_);
        }

        private void ProjectSelectForm_Load(object sender, EventArgs e)
        {
            RefreshOrSearch(sender, e);
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void Project_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int l_iSeleteRow = Project_DataGridView.CurrentRow.Index;
            Choose_txt.Text = Project_DataGridView.Rows[l_iSeleteRow].Cells[1].Value.ToString();
        }

        private void Barcode_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Barcode_cbx.Checked==true)
            {
                Search_txt.Text = "";
                Search_txt.ReadOnly = true;
                Refresh_btn.Visible = false;
                BarCode_picbox.Visible = true;
            }
            else
            {
                Search_txt.Text = "";
                Search_txt.ReadOnly = false;
                Refresh_btn.Visible = true;
                BarCode_picbox.Visible = false;            
            }
             RefreshOrSearch(sender, e);
        }

        private void Choose_btn_Click(object sender, EventArgs e)
        {
            if (Choose_txt.Text != "")
            {
                g_strProjectName__ = Choose_txt.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose a project.");
            }
        }





    }
}
