
namespace _19.ThreadTest
{
    partial class Form1
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
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 36);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 19);
            this.progressBar1.TabIndex = 0;
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butStart.Location = new System.Drawing.Point(398, 68);
            this.butStart.Margin = new System.Windows.Forms.Padding(2);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(67, 30);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Старт";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // butStop
            // 
            this.butStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butStop.Location = new System.Drawing.Point(490, 68);
            this.butStop.Margin = new System.Windows.Forms.Padding(2);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(67, 30);
            this.butStop.TabIndex = 2;
            this.butStop.Text = "СТОП";
            this.butStop.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Label lblTime;
    }
}

