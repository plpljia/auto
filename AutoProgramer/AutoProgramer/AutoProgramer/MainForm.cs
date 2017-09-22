using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Net;


namespace AutoProgramer
{
    public partial class MainForm : Form
    {
        MysqlServer g_mMysqlServer = new MysqlServer();
        FileOperation g_mFileOperation = new FileOperation();
        DecryptCode g_mDecryptCode = new DecryptCode();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            //List<HashSet<string>> l_listResultSet = new List<HashSet<string>>();
            int l_iTestState;
            long l_lFilesize = 0;
            //g_mFileOperation.foFile2Bytes("Z:\\hex1.hex", ref l_lFilesize);
            //Console.Write("path路径：" + Application.StartupPath);
            DataTable l_dsResultDataTable = new DataTable();
            //string l_str = "SELECT * FROM `demo`.`takeout_food` LIMIT 1000";
            string l_str = "SELECT * FROM autoprogramer_db.project";
            l_iTestState = g_mMysqlServer.mysqlUploadFile("Z:", "hex.hex");
            Console.Write("l_iTestState" + l_iTestState);
            //string l_str = "DELETE FROM `autoprogramer_db`.`project` WHERE  `hexname`=1";
            //string l_str = "INSERT INTO `autoprogramer_db`.`project` (`projectname`, `hexname`, `fileimage`) VALUES ('1', '1', 0x11)";
            //int l_itest = g_mMysqlServer.mysqlSendCmd(l_str);
            int l_itest =0;//= g_mMysqlServer.mysqlSendCmd(l_str, l_dsResultDataTable);

            Console.Write("l_dsResultDataTable.Rows[0][4]" + l_dsResultDataTable.Rows[0][4]);
            int l_lFileBytesize = Convert.ToInt32( l_dsResultDataTable.Rows[0][4]);
            FileStream l_mFileStream = new FileStream(Application.StartupPath + "\\" +Convert.ToString( l_dsResultDataTable.Rows[0][2]) , FileMode.Create, FileAccess.Write);
            //l_lFileBytesize = l_mFileStream.Length;
            byte[] l_bFileDatas = new byte[l_lFileBytesize];
            l_bFileDatas = (byte[])l_dsResultDataTable.Rows[0][3];

            ulong l_ulCrc = g_mDecryptCode.GetCRC32ByteArray(l_bFileDatas);
            Console.Write(l_ulCrc.ToString("X"));
            l_mFileStream.Write(l_bFileDatas, 0, l_lFileBytesize);
            l_mFileStream.Close();
            //if(l_itest>0)
            //Console.Write(l_dsResultDataTable.Rows[0][0]);
            l_dsResultDataTable.Dispose();
            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string hostname = Dns.GetHostName();
            Console.Write(hostname);

        }
    }
}
