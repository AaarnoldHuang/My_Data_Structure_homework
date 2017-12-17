namespace sjjg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.class1 = new System.Windows.Forms.Button();
            this.class2 = new System.Windows.Forms.Button();
            this.class3 = new System.Windows.Forms.Button();
            this.class4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // class1
            // 
            this.class1.Location = new System.Drawing.Point(31, 46);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(75, 23);
            this.class1.TabIndex = 0;
            this.class1.Text = "实验1";
            this.class1.UseVisualStyleBackColor = true;
            this.class1.Click += new System.EventHandler(this.button1_Click);
            // 
            // class2
            // 
            this.class2.Location = new System.Drawing.Point(163, 46);
            this.class2.Name = "class2";
            this.class2.Size = new System.Drawing.Size(75, 23);
            this.class2.TabIndex = 1;
            this.class2.Text = "实验2";
            this.class2.UseVisualStyleBackColor = true;
            this.class2.Click += new System.EventHandler(this.button2_Click);
            // 
            // class3
            // 
            this.class3.Location = new System.Drawing.Point(31, 86);
            this.class3.Name = "class3";
            this.class3.Size = new System.Drawing.Size(75, 23);
            this.class3.TabIndex = 2;
            this.class3.Text = "实验3";
            this.class3.UseVisualStyleBackColor = true;
            this.class3.Click += new System.EventHandler(this.button3_Click);
            // 
            // class4
            // 
            this.class4.Location = new System.Drawing.Point(163, 86);
            this.class4.Name = "class4";
            this.class4.Size = new System.Drawing.Size(75, 23);
            this.class4.TabIndex = 3;
            this.class4.Text = "实验4";
            this.class4.UseVisualStyleBackColor = true;
            this.class4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "-------------数据结构-------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class4);
            this.Controls.Add(this.class3);
            this.Controls.Add(this.class2);
            this.Controls.Add(this.class1);
            this.Name = "Form1";
            this.Text = "数据结构";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button class1;
        private System.Windows.Forms.Button class2;
        private System.Windows.Forms.Button class3;
        private System.Windows.Forms.Button class4;
        private System.Windows.Forms.Label label1;
    }
}

