
namespace MVPExample
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fldFilePath = new System.Windows.Forms.TextBox();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.fldContent = new System.Windows.Forms.TextBox();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл:";
            // 
            // fldFilePath
            // 
            this.fldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldFilePath.Location = new System.Drawing.Point(151, 19);
            this.fldFilePath.Name = "fldFilePath";
            this.fldFilePath.Size = new System.Drawing.Size(509, 22);
            this.fldFilePath.TabIndex = 1;
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Location = new System.Drawing.Point(672, 14);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(89, 32);
            this.butSelectFile.TabIndex = 2;
            this.butSelectFile.Text = "Выбрать";
            this.butSelectFile.UseVisualStyleBackColor = true;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOpenFile.Location = new System.Drawing.Point(781, 14);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(89, 32);
            this.butOpenFile.TabIndex = 3;
            this.butOpenFile.Text = "Открыть";
            this.butOpenFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт:";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(151, 52);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(120, 22);
            this.numFont.TabIndex = 5;
            this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // fldContent
            // 
            this.fldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldContent.Location = new System.Drawing.Point(30, 90);
            this.fldContent.Multiline = true;
            this.fldContent.Name = "fldContent";
            this.fldContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fldContent.Size = new System.Drawing.Size(852, 401);
            this.fldContent.TabIndex = 6;
            // 
            // butSaveFile
            // 
            this.butSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveFile.Location = new System.Drawing.Point(775, 506);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(107, 36);
            this.butSaveFile.TabIndex = 7;
            this.butSaveFile.Text = "Сохранить";
            this.butSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabel1.Text = "Кол-во символов:";
            // 
            // lblSymbolCount
            // 
            this.lblSymbolCount.Name = "lblSymbolCount";
            this.lblSymbolCount.Size = new System.Drawing.Size(0, 20);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.fldContent);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.butSelectFile);
            this.Controls.Add(this.fldFilePath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fldFilePath;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.TextBox fldContent;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
    }
}

