using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPExample
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }


    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += ButOpenFile_Click;
            butSaveFile.Click += ButSaveFile_Click;
            fldContent.TextChanged += FldContent_TextChanged;
            butSelectFile.Click += ButSelectFile_Click;
            numFont.ValueChanged += NumFont_ValueChanged;
        }

        #region Проброс событий
        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            FileOpenClick?.Invoke(this, EventArgs.Empty);
        }
        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }
        private void FldContent_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm
        public string FilePath
        {
            get { return fldFilePath.Text; }
        }
        public string Content
        {
            get { return fldContent.Text; }
            set { fldContent.Text = value; }
        }
        public void SetSymbolCount(int count)
        {
            lblSymbolCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dlg.FileName;
                FileOpenClick?.Invoke(this, EventArgs.Empty);
            }
        }
        private void NumFont_ValueChanged(object sender, EventArgs e)
        {
            fldContent.Font = new Font("Calibri", (float)numFont.Value);
        }
    }
}
