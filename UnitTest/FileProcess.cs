using System;
using System.IO;

namespace UnitTest
{
    class FileProcess
    {
        public  bool FileExist(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }
    }
}
