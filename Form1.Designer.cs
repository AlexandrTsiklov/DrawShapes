namespace KP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstExBtn = new System.Windows.Forms.Button();
            this.SecondExBtn = new System.Windows.Forms.Button();
            this.ThirdExBtn = new System.Windows.Forms.Button();
            this.FourthExBtn = new System.Windows.Forms.Button();
            this.FifthExBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstExBtn
            // 
            this.FirstExBtn.Location = new System.Drawing.Point(770, 12);
            this.FirstExBtn.Name = "FirstExBtn";
            this.FirstExBtn.Size = new System.Drawing.Size(116, 23);
            this.FirstExBtn.TabIndex = 0;
            this.FirstExBtn.Text = "Первое задание";
            this.FirstExBtn.UseVisualStyleBackColor = true;
            this.FirstExBtn.Click += new System.EventHandler(this.FirstExBtn_Click);
            // 
            // SecondExBtn
            // 
            this.SecondExBtn.Location = new System.Drawing.Point(770, 41);
            this.SecondExBtn.Name = "SecondExBtn";
            this.SecondExBtn.Size = new System.Drawing.Size(116, 23);
            this.SecondExBtn.TabIndex = 0;
            this.SecondExBtn.Text = "Второе задание";
            this.SecondExBtn.UseVisualStyleBackColor = true;
            this.SecondExBtn.Click += new System.EventHandler(this.SecondExBtn_Click);
            // 
            // ThirdExBtn
            // 
            this.ThirdExBtn.Location = new System.Drawing.Point(770, 70);
            this.ThirdExBtn.Name = "ThirdExBtn";
            this.ThirdExBtn.Size = new System.Drawing.Size(116, 23);
            this.ThirdExBtn.TabIndex = 0;
            this.ThirdExBtn.Text = "Третье задание";
            this.ThirdExBtn.UseVisualStyleBackColor = true;
            this.ThirdExBtn.Click += new System.EventHandler(this.ThirdExBtn_Click);
            // 
            // FourthExBtn
            // 
            this.FourthExBtn.Location = new System.Drawing.Point(770, 99);
            this.FourthExBtn.Name = "FourthExBtn";
            this.FourthExBtn.Size = new System.Drawing.Size(116, 23);
            this.FourthExBtn.TabIndex = 1;
            this.FourthExBtn.Text = "Четвертое задание";
            this.FourthExBtn.UseVisualStyleBackColor = true;
            this.FourthExBtn.Click += new System.EventHandler(this.FourthExBtn_Click);
            // 
            // FifthExBtn
            // 
            this.FifthExBtn.Location = new System.Drawing.Point(770, 128);
            this.FifthExBtn.Name = "FifthExBtn";
            this.FifthExBtn.Size = new System.Drawing.Size(116, 23);
            this.FifthExBtn.TabIndex = 1;
            this.FifthExBtn.Text = "Пятое задание";
            this.FifthExBtn.UseVisualStyleBackColor = true;
            this.FifthExBtn.Click += new System.EventHandler(this.FifthExBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 671);
            this.Controls.Add(this.FifthExBtn);
            this.Controls.Add(this.FourthExBtn);
            this.Controls.Add(this.ThirdExBtn);
            this.Controls.Add(this.SecondExBtn);
            this.Controls.Add(this.FirstExBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FifthExBtn;

        private System.Windows.Forms.Button FourthExBtn;

        private System.Windows.Forms.Button ThirdExBtn;

        private System.Windows.Forms.Button FirstExBtn;
        private System.Windows.Forms.Button SecondExBtn;

        #endregion
    }
}