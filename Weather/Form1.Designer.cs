namespace Weather
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
            this.requestButt = new System.Windows.Forms.Button();
            this.textInfoRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // requestButt
            // 
            this.requestButt.Location = new System.Drawing.Point(579, 36);
            this.requestButt.Name = "requestButt";
            this.requestButt.Size = new System.Drawing.Size(191, 69);
            this.requestButt.TabIndex = 0;
            this.requestButt.Text = "Запрос погоды";
            this.requestButt.UseVisualStyleBackColor = true;
            this.requestButt.Click += new System.EventHandler(this.requestButt_Click);
            // 
            // textInfoRes
            // 
            this.textInfoRes.Location = new System.Drawing.Point(37, 36);
            this.textInfoRes.Multiline = true;
            this.textInfoRes.Name = "textInfoRes";
            this.textInfoRes.Size = new System.Drawing.Size(354, 305);
            this.textInfoRes.TabIndex = 1;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textInfoRes);
            this.Controls.Add(this.requestButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button requestButt;
        private System.Windows.Forms.TextBox textInfoRes;
    }
}

