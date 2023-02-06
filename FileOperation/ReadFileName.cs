using FileSystemModule.Interface;
using System.Collections.Generic;
using System.IO;

namespace FileSystemModule.FileOperation
{
    public class ReadFileName : IFileReadControl
    {
        private string _filePath;
        public ReadFileName(string filePath)
        {
            _filePath = filePath;
        }
        public List<string> fileOperator()
        {
            List<string> result = new List<string>();
            string[] files = Directory.GetFiles(_filePath);
            foreach (string item in files)
            {
                result.Add(Path.GetFileName(item));
            }
            return result;
        }
    }
}
