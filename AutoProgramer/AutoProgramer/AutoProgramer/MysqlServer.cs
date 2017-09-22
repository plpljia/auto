using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoProgramer
{
    class MysqlServer
    {
        private const string g_strMySqlCon = "server=127.0.0.1;user id=root; password=x5; database=autoprogramerdb; pooling=false";

        DecryptCode g_mDecryptCode = new DecryptCode();

        /// <summary>
        /// return Have row:>0 return the effect row;Not result:=0;Exception=-2
        /// </summary>
        /// <param name="_strMysqlCmd"></param>
        /// <param name="__dsResultSet"></param>
        /// <returns></returns>
        public int mysqlSendCmdSelectReturnRow(string _strMysqlCmd)
        {
            MySqlConnection l_mMySqlConnection = null;
            MySqlCommand    l_mMySqlCommand = null;
            MySqlDataReader l_mMySqlDataReader = null;

            int l_iRowNum = 0;
            try
            {
                l_mMySqlConnection = new MySqlConnection(g_strMySqlCon);
                l_mMySqlCommand = new MySqlCommand(_strMysqlCmd, l_mMySqlConnection);
                l_mMySqlConnection.Open();
                l_mMySqlDataReader = l_mMySqlCommand.ExecuteReader();
                
                if (l_mMySqlDataReader.HasRows)
                {
                    while (l_mMySqlDataReader.Read())
                    {
                        l_iRowNum++;
                    }
                }
                Console.Write(" l_mMySqlCommand.Execute_____;" + l_iRowNum);            
            }
            catch (Exception)
            {
                Console.Write("mysqlSendCmd Exception");
                l_iRowNum = -2;
            }
            finally
            {
                try
                {
                    l_mMySqlConnection.Close();
                    l_mMySqlCommand.Dispose();
                    l_mMySqlDataReader.Dispose();
                }
                catch (Exception) { }
            }
            return l_iRowNum;
        }
        /// <summary>
        /// return the datatable, Have row:>0 return the effect row;Not result:=0;Exception=-2
        /// </summary>
        /// <param name="_strMysqlCmd"></param>
        /// <param name="__dsResultSet"></param>
        /// <returns></returns>
        public int mysqlSendCmdSelectReturnData(string _strMysqlCmd, DataTable __dsResultTable)
        {           
            MySqlConnection l_mMySqlConnection = null;
            MySqlCommand l_mMySqlCommand = null;
            MySqlDataAdapter l_mMySqlAdapter = null;

            int l_iRowNum = 0;
            try
            {
                l_mMySqlConnection = new MySqlConnection(g_strMySqlCon);
                l_mMySqlCommand = new MySqlCommand(_strMysqlCmd, l_mMySqlConnection);
                l_mMySqlAdapter = new MySqlDataAdapter();

                l_mMySqlConnection.Open();
                l_mMySqlAdapter.SelectCommand = l_mMySqlCommand;
                l_mMySqlAdapter.Fill(__dsResultTable);
                l_iRowNum = __dsResultTable.Rows.Count;
                Console.Write(" l_mMySqlCommand.Execute_____;" + l_iRowNum);
            }
            catch (Exception)
            {
                Console.Write("mysqlSendCmd Exception");
                l_iRowNum = -2;
            }
            finally 
            {
                try
                {
                    l_mMySqlConnection.Close();
                    l_mMySqlCommand.Dispose();
                    l_mMySqlAdapter.Dispose();                   
                }
                catch (Exception){ }
            }
            return l_iRowNum;
        }

        /// <summary>
        /// return OK:>0 return the effect row;NotOK:=0;Exception=-2
        /// </summary>
        /// <param name="_strMysqlCmd"></param>
        /// <param name="__dsResultSet"></param>
        /// <returns></returns>
        // For UPDATE, INSERT, and DELETE statements, the return value is the number of rows affected by the command. 
        // For all other types of statements, the return value is -1. 
        public int mysqlSendCmdNonQuery(string _strMysqlCmd)
        {
            MySqlConnection l_mMySqlConnection = null;
            MySqlCommand l_mMySqlCommand = null;
            
            int l_iRowNum = 0;
            try
            {
                l_mMySqlConnection = new MySqlConnection(g_strMySqlCon);
                l_mMySqlCommand = new MySqlCommand(_strMysqlCmd, l_mMySqlConnection);

                l_mMySqlConnection.Open();
                l_iRowNum = l_mMySqlCommand.ExecuteNonQuery();

                Console.Write(" mysqlSendCmdNonQuery_____;" + l_iRowNum);
            }
            catch (Exception)
            {
                Console.Write("mysqlSendCmdNonQuery Exception");
                l_iRowNum = -2;
            }
            finally
            {
                try
                {
                    l_mMySqlConnection.Close();
                    l_mMySqlCommand.Dispose();
                }
                catch (Exception) { }
            }
            return l_iRowNum;
        }

        
        public int isa3AddProject(string _strProject,string _strHexFullPath,string _strBarcode,bool _bBarcodeEn,
                                  string _strManufacture,string _strFireware,string _strModel,string _strPCBNum,string _strPartNum,
                                  ref long __lHexSize , ref string __strHexCRC32)
        { 
 
            MySqlConnection l_mMySqlConnection = null;
            MySqlCommand l_mMySqlCommand = null;

            long l_lFileBytesize;
            FileStream l_mFileStream = new FileStream(_strHexFullPath, FileMode.OpenOrCreate, FileAccess.Read);
            l_lFileBytesize = l_mFileStream.Length;
            byte[]  l_bFileByteDatas = new byte[l_lFileBytesize];
            l_mFileStream.Read(l_bFileByteDatas, 0, System.Convert.ToInt32(l_mFileStream.Length));
            l_mFileStream.Close();

            if (l_lFileBytesize == 0) return -3;//文件加载失败
            else
            {
                __lHexSize = l_lFileBytesize;
                __strHexCRC32 = g_mDecryptCode.GetCRC32ByteArray(l_bFileByteDatas).ToString("X");
            }

            string l_strSelectProject = "SELECT  `Project` FROM `autoprogramerdb`.`isa3project` WHERE `Project`='" + _strProject+ "'";
            if(mysqlSendCmdSelectReturnRow(l_strSelectProject)>0)
            {
                return -4;//Project exist       
            }
            else
            {
                string l_strInsertProject = "INSERT INTO `autoprogramerdb`.`isa3project` "
                     +"(`Time`, `Project`, `HexName`, `HexImage`, `HexSize`, `HexCRC32`, `Barcode`, `BarcodeEnable`, `Manufacture`, `Fireware`, `ModelName`, `PCBNum`, `PartNum`) "
                     +"VALUES (NOW(), @Project, @HexName, @HexImage, @HexSize, @HexCRC32, @Barcode, @BarcodeEnable, @Manufacture, @Fireware, @ModelName, @PCBNum, @PartNum)";
                int l_iMySqlState = 0;
                try
                {
                    l_mMySqlConnection = new MySqlConnection(g_strMySqlCon);
                    l_mMySqlCommand = new MySqlCommand(l_strInsertProject, l_mMySqlConnection);

                    l_mMySqlCommand.Parameters.AddWithValue("@Project", _strProject);
                    l_mMySqlCommand.Parameters.AddWithValue("@HexName", Path.GetFileName(_strHexFullPath));
                    l_mMySqlCommand.Parameters.AddWithValue("@HexImage", l_bFileByteDatas);
                    l_mMySqlCommand.Parameters.AddWithValue("@HexSize", __lHexSize);
                    l_mMySqlCommand.Parameters.AddWithValue("@HexCRC32", __strHexCRC32);
                    l_mMySqlCommand.Parameters.AddWithValue("@Barcode", _strBarcode);
                    l_mMySqlCommand.Parameters.AddWithValue("@BarcodeEnable", _bBarcodeEn);
                    l_mMySqlCommand.Parameters.AddWithValue("@Manufacture", _strManufacture);
                    l_mMySqlCommand.Parameters.AddWithValue("@Fireware", _strFireware);
                    l_mMySqlCommand.Parameters.AddWithValue("@ModelName", _strModel);
                    l_mMySqlCommand.Parameters.AddWithValue("@PCBNum", _strPCBNum);
                    l_mMySqlCommand.Parameters.AddWithValue("@PartNum", _strPartNum);
                 
                    l_mMySqlConnection.Open();
                    l_iMySqlState = l_mMySqlCommand.ExecuteNonQuery();
                    if(l_iMySqlState==1)
                    {
                        return -1;//Add Funtion normal
                    }

                }
                catch (Exception)
                {
                    Console.Write("mysqlSendCmd Exception");
                    return  -2;//数据库连接失败
                }
                finally
                {
                    try
                    {
                        l_mMySqlConnection.Close();
                        l_mMySqlCommand.Dispose();
                    }
                    catch (Exception) { }
                }            

            }
            return -1;  
      }

        /// <summary>
        /// return OK:-1;NotOK:1
        /// </summary>
        /// <param name="_strMysqlCmd"></param>
        /// <param name="__dsResultSet"></param>
        /// <returns></returns>
        public int mysqlUploadFile(string _strFilePath,string _strFileName )
        {
            FileOperation l_mFileOperation = new FileOperation();
            MySqlConnection l_mMySqlConnection = null;
            MySqlCommand l_mMySqlCommand = null;

            long l_lFileBytesize;
            FileStream l_mFileStream = new FileStream(_strFilePath + "\\" + _strFileName, FileMode.OpenOrCreate, FileAccess.Read);
            l_lFileBytesize = l_mFileStream.Length;
            byte[]  l_bFileDatas = new byte[l_lFileBytesize];
            l_mFileStream.Read(l_bFileDatas, 0, System.Convert.ToInt32(l_mFileStream.Length));
            l_mFileStream.Close();

            if (l_lFileBytesize == 0) return -3;//文件加载失败

            DataTable l_dsResultTable = new DataTable();

            string l_strMysqlCmdCheck  = "SELECT * FROM `autoprogramer_db`.`project` WHERE  `hexname`='" + _strFileName +"'";
            string l_strMysqlCmdDelete = "DELETE   FROM `autoprogramer_db`.`project` WHERE  `hexname`='" + _strFileName + "'";
            string l_strMysqlCmdInsert = "INSERT   INTO `autoprogramer_db`.`project` (`projectname`, `hexname`, `fileimage`, `filesize`) VALUES (@projectname, @hexname, @fileimage,@filesize)";

            int l_iMySqlState = 0;
            int l_iCheckIfExist=0 ;//= mysqlSendCmd(l_strMysqlCmdCheck, l_dsResultTable);
            l_dsResultTable.Dispose();

            if (l_iCheckIfExist > 0)
            {
                //if (mysqlSendCmd(l_strMysqlCmdDelete) < 0)
                    return -4;//删除数据表失败            
            }
            else if (l_iCheckIfExist < 0)
            {
                return -5;//查询失败
            }
            else
            {
                

                try
                {
                    l_mMySqlConnection = new MySqlConnection(g_strMySqlCon);
                    l_mMySqlCommand = new MySqlCommand(l_strMysqlCmdInsert, l_mMySqlConnection);
                    //l_mMySqlCommand = new MySqlCommand();

                    l_mMySqlCommand.Parameters.AddWithValue("@projectname", 6666);
                    l_mMySqlCommand.Parameters.AddWithValue("@hexname", _strFileName);
                    l_mMySqlCommand.Parameters.AddWithValue("@fileimage", l_bFileDatas);
                    l_mMySqlCommand.Parameters.AddWithValue("@filesize", l_lFileBytesize); 
                    //l_mMySqlCommand.Connection  = l_mMySqlConnection;
                    //l_mMySqlCommand.CommandText = l_strMysqlCmdInsert;
                    //l_mMySqlCommand.Parameters.Clear();
                    /*l_mMySqlCommand.Parameters.Add("5555");//.Value = "1111";
                    l_mMySqlCommand.Parameters.Add("7777");
                    l_mMySqlCommand.Parameters.Add(l_bFileDatas);*/
                    /*
                    l_mMySqlCommand.Parameters.Add("@projectname", MySqlDbType.VarChar);//.Value = "1111";
                    l_mMySqlCommand.Parameters["@projectname"].Value = 6666;
                    l_mMySqlCommand.Parameters.Add("@hexname", MySqlDbType.VarChar);//.Value = _strFileName;
                    l_mMySqlCommand.Parameters["@projectname"].Value = 888;
                    l_mMySqlCommand.Parameters.Add("@fileimage", MySqlDbType.MediumBlob);//.Value = l_bFileDatas;//这句需传参数;
                    l_mMySqlCommand.Parameters["@fileimage"].Value = l_bFileDatas;
                    */
                    //l_mMySqlCommand.Parameters[0].Value = "1111";
                    //l_mMySqlCommand.Parameters[1].Value = _strFileName;
                    //l_mMySqlCommand.Parameters[2].Value = l_bFileDatas;
                    
                    l_mMySqlConnection.Open();
                    l_iMySqlState = l_mMySqlCommand.ExecuteNonQuery();


                }
                catch (Exception)
                {
                    Console.Write("mysqlSendCmd Exception");
                    l_iMySqlState = -2;//数据库连接失败
                }
                finally
                {
                    try
                    {
                        l_mMySqlConnection.Close();
                        l_mMySqlCommand.Dispose();
                    }
                    catch (Exception) { }
                }               
            }

            return l_iMySqlState;
        }




    }
}
