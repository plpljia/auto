using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AutoProgramer
{
    public partial class ProjectManagerForm : Form
    {
        private MysqlServer g_mMysqlServer = new MysqlServer();
        public ProjectManagerForm()
        {
            InitializeComponent();
        }

        private bool CheckParemeterNotNull()
        {
            if (Project_txt.Text == "") { MessageBox.Show("Project name not allow null , please fill in."); return false; }
            else if (Hex_txt.Text == "") { MessageBox.Show("Hex name not allow null , please fill in."); return false; }
            else if (Manu_txt.Text == "") { MessageBox.Show("Manufacture name not allow null , please fill in."); return false; }
            else if (Model_txt.Text == "") { MessageBox.Show("Model name not allow null , please fill in."); return false; }
            else if (PCB_txt.Text == "") { MessageBox.Show("PCB name not allow null , please fill in."); return false; }
            else if (PartName_txt.Text == "") { MessageBox.Show("Part name not allow null , please fill in."); return false; }
            else if (Fireware_txt.Text == "") { MessageBox.Show("Fireware Version not allow null , please fill in."); return false; }
            else if (Barcode_cbx.Checked == true)
            {
                if (Barcode_txt.Text == "")
                {
                    { MessageBox.Show("Barcode name not allow null , please fill in."); return false; }
                }
                else return true;

            }
            else
            {
                return true;
            }
            //return false;

        }
        private void Hex_txt_Click(object sender, EventArgs e)
        {
            if (Hex_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DecryptCode l_mDecryptCode = new DecryptCode();

                Hex_txt.Text = Hex_OpenFileDialog.FileName;
                FileInfo l_mFinfo = new FileInfo(Hex_txt.Text);         //实例化FileInfo对象
                Hex_lbl.Text = l_mFinfo.Name;
                ulong l_ulCRC = l_mDecryptCode.decryCodeGetFileCRC32(l_mFinfo.FullName);
                //MessageBox.Show(l_mFinfo.FullName);
                //MessageBox.Show(Path.GetFileName(l_mFinfo.FullName));
                
                if (l_ulCRC != 0)
                {
                    CheckSum_lbl.Text = l_ulCRC.ToString("X");
                }
                else
                {
                    CheckSum_lbl.Text = "0";
                }

            }
        }

        private void AddProject_btn_Click(object sender, EventArgs e)
        {
            if (CheckParemeterNotNull())
            {
                if (CheckSum_lbl.Text == "0")
                {
                    MessageBox.Show("CheckSum Error");
                    return;
                }
                else
                {
                    string l_strProject = Project_txt.Text;
                    string l_strHexFullPath = Hex_txt.Text;
                    string l_strBarcode = Barcode_txt.Text;
                    bool l_bBarcodeEn = Barcode_cbx.Checked ? true : false;
                    string l_strManufacture = Manu_txt.Text;
                    string l_strFireware = Fireware_txt.Text;
                    string l_strModel = Model_txt.Text;
                    string l_strPCBNum = PCB_txt.Text;
                    string l_strPartNum = PartName_txt.Text;
                    long l_lHexSize = 0;
                    string l_strHexCRC32 = "";

                    int l_iState = g_mMysqlServer.isa3AddProject(
                                l_strProject,
                                l_strHexFullPath,
                                l_strBarcode,
                                l_bBarcodeEn,
                                l_strManufacture,
                                l_strFireware,
                                l_strModel,
                                l_strPCBNum,
                                l_strPartNum,
                                ref l_lHexSize,
                                ref l_strHexCRC32);
                    switch (l_iState)
                    {
                        case -1:
                            Hex_lbl.Text = Path.GetFileName(l_strHexFullPath) + "  " + l_lHexSize.ToString() + "  Byte";
                            CheckSum_lbl.Text = l_strHexCRC32;
                            MessageBox.Show("Add project success."); break;
                        case -2: MessageBox.Show("Insert project error."); break;
                        case -3: MessageBox.Show("Load file error."); break;
                        case -4: MessageBox.Show("Project already exist,please check after add project."); break;
                        default: MessageBox.Show("Unknown Exception."); break;

                    }

                }

            }
            else
            {
                MessageBox.Show("Add project parameter error."); 
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataTable l_dsResultDataTable = new DataTable();

            string l_strSelect = "";
            if (Search_txt.Text == "")
            {
                l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`isa3project` ";
            }
            else
            {
                l_strSelect = "SELECT `Time`, `Project`, `HexName`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum` FROM `autoprogramerdb`.`isa3project` "
                    + "WHERE `Project`='" + Search_txt.Text +"'";
            }

            int l_iSqlState = g_mMysqlServer.mysqlSendCmdSelectReturnData(l_strSelect, l_dsResultDataTable);
            if ( l_iSqlState> 0)
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

        }

        private void Project_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int l_iSeleteRow = Project_DataGridView.CurrentRow.Index;
            Search_txt.Text = Project_DataGridView.Rows[l_iSeleteRow].Cells[1].Value.ToString();
            //Console.Write(Project_DataGridView.Rows[l_iSeleteRow].Cells[1].Value.ToString()+"\n");
      
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string l_strDelete = "";
            if (Search_txt.Text == "")
            {
                MessageBox.Show("Please fill in the project name.");
                return;
            }
            else
            {
                l_strDelete = "DELETE FROM `autoprogramerdb`.`isa3project`  "
                    + "WHERE  `Project`='" + Search_txt.Text + "'";
            }

            int l_iSqlState = g_mMysqlServer.mysqlSendCmdNonQuery(l_strDelete);
            if (l_iSqlState > 0)
            {
                MessageBox.Show("Already delete project : " + Search_txt.Text);
            }
            else
            {
                MessageBox.Show("Delete project fail.Can't find the project : " + Search_txt.Text);
            }
        }
        

    }
}
