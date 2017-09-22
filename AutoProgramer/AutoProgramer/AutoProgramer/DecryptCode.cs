using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AutoProgramer
{
    class DecryptCode
    {
        private ulong[] Crc32Table;
        //Creat CRC32 Table
        private void GetCRC32Table() 
         {
            ulong Crc;
           Crc32Table = new ulong[256];
            int i,j;
            for(i = 0;i < 256; i++) 
            {
                Crc = (ulong)i;
                for (j = 8; j > 0; j--)
                 {
                     if ((Crc & 1) == 1)
                        Crc = (Crc >> 1) ^ 0xEDB88320;
                     else
                         Crc >>= 1;
                }
                 Crc32Table[i] = Crc;
             }
         }
 

        public ulong GetCRC32ByteArray(byte[] buffer)
         {
             //Creat CRC32 Table
             GetCRC32Table();
             //byte[] buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(sInputString);
             ulong value = 0xffffffff;
             int len = buffer.Length;
             for (int i = 0; i < len; i++)
             {
                 value = (value >> 8) ^ Crc32Table[(value & 0xFF)^ buffer[i]];
             }
             return value ^ 0xffffffff; 
        }
        //Error return 0;
        public ulong decryCodeGetFileCRC32(string _strFileFullPath)
        {
            long l_lFileBytesize;
            FileStream l_mFileStream = new FileStream(_strFileFullPath, FileMode.OpenOrCreate, FileAccess.Read);
            l_lFileBytesize = l_mFileStream.Length;
            if (l_lFileBytesize == 0) return 0;
            byte[]  l_bFileDatas = new byte[l_lFileBytesize];
            l_mFileStream.Read(l_bFileDatas, 0, System.Convert.ToInt32(l_mFileStream.Length));
            l_mFileStream.Close();
            return GetCRC32ByteArray(l_bFileDatas);
        
        }


    }
}
