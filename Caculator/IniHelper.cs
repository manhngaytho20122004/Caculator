using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    internal class IniHelper
    {
        private string filePath;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniHelper(string path)
        {
            filePath = path;
        }
        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }
        public string Read(string section, string key)
        {
            int currentSize = 256;
            StringBuilder temp = new StringBuilder(currentSize);

            while (true)
            {
                int readChars = GetPrivateProfileString(section, key, "", temp, currentSize, filePath);

                if (readChars >= currentSize - 2)
                {
                    currentSize *= 2;
                    temp = new StringBuilder(currentSize);
                }
                else
                {
                    break;
                }
            }
            return temp.ToString();
        }
    }
}
