using FileSystemModule.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSystemModule.FileOperation
{
    public class ReadTXTFile : IFileReadControl
    {
        private string _filePath;
        public ReadTXTFile(string filePath)
        {
            _filePath = filePath;
        }
        public List<string> fileOperator()
        {
            List<string> result = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(_filePath, Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Add(line.ToString());
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
            return result;
        }
    }
}
