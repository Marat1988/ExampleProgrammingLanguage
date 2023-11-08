
namespace WinForm
{
    partial class FormMain
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.butStop = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(25, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(740, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(676, 68);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(89, 41);
            this.butStop.TabIndex = 1;
            this.butStop.Text = "СТОП";
            this.butStop.UseVisualStyleBackColor = true;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(562, 68);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(89, 41);
            this.butStart.TabIndex = 2;
            this.butStart.Text = "СТАРТ";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.progressBar1);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butStart;
        private System.ComponentModel.BackgroundWorker worker;
    }
}

