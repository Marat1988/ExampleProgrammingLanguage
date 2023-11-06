using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encondin);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);

    }

    public class FileManager: IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }
        public string GetContent(string filePath)
        {
            string content = File.ReadAllText(filePath, _defaultEncoding);
            return content;
        }
        public string GetContent(string filePath, Encoding encondin)
        {
            string content = File.ReadAllText(filePath, encondin);
            return content;
        }
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defaultEncoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }
    }
}
