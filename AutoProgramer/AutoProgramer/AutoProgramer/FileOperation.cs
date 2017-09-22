using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AutoProgramer
{
    class FileOperation
    {

        /// <summary>
        /// 将文件转换为Bytes
        /// </summary>
        /// <param name="_strFileFullPath"></param>
        /// <returns></returns>
        public long foFile2Bytes(string _strFileFullPath,ref byte[] __bFileDatas)
        {
            long l_lFileBytesize;
            FileStream l_mFileStream = new FileStream(_strFileFullPath, FileMode.OpenOrCreate, FileAccess.Read);
            l_lFileBytesize = l_mFileStream.Length;
            __bFileDatas = new byte[l_lFileBytesize];
            l_mFileStream.Read(__bFileDatas, 0, System.Convert.ToInt32(l_mFileStream.Length));
            l_mFileStream.Close();
            return l_lFileBytesize;
        }
    }

}
