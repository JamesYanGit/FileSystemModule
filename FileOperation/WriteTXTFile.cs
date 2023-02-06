using FileSystemModule.Interface;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSystemModule.FileOperation
{
    public class WriteTXTFile : IFileWriteControl
    {
        private string _filePath;
        private List<string> _content;
        public WriteTXTFile(string filePath, List<string> content)
        {
            _filePath = filePath;
            _content = content;
        }

        public void writeFileContent()
        {

            FileStream fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write);

            //获得字节数组
            foreach (string item in _content)
            {
                byte[] data = Encoding.Default.GetBytes(item + "\n");
                //开始写入
                fs.Write(data, 0, data.Length);
            }

            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
    }
}
