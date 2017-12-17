namespace sjjg
{
    partial class shiyan4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.dispbox = new System.Windows.Forms.TextBox();
            this.dispbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.du1 = new System.Windows.Forms.RadioButton();
            this.du2 = new System.Windows.Forms.RadioButton();
            this.getdu = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "图1"});
            this.comboBox1.Location = new System.Drawing.Point(28, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(170, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "建立";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // dispbox
            // 
            this.dispbox.Location = new System.Drawing.Point(28, 90);
            this.dispbox.Multiline = true;
            this.dispbox.Name = "dispbox";
            this.dispbox.Size = new System.Drawing.Size(237, 199);
            this.dispbox.TabIndex = 3;
            // 
            // dispbutton
            // 
            this.dispbutton.Location = new System.Drawing.Point(420, 134);
            this.dispbutton.Name = "dispbutton";
            this.dispbutton.Size = new System.Drawing.Size(75, 23);
            this.dispbutton.TabIndex = 5;
            this.dispbutton.Text = "输出";
            this.dispbutton.UseVisualStyleBackColor = true;
            this.dispbutton.Click += new System.EventHandler(this.dispbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 21);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "手动输入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // du1
            // 
            this.du1.AutoSize = true;
            this.du1.Location = new System.Drawing.Point(294, 193);
            this.du1.Name = "du1";
            this.du1.Size = new System.Drawing.Size(107, 16);
            this.du1.TabIndex = 8;
            this.du1.TabStop = true;
            this.du1.Text = "由邻接矩阵求度";
            this.du1.UseVisualStyleBackColor = true;
            this.du1.CheckedChanged += new System.EventHandler(this.du1_CheckedChanged);
            // 
            // du2
            // 
            this.du2.AutoSize = true;
            this.du2.Location = new System.Drawing.Point(420, 193);
            this.du2.Name = "du2";
            this.du2.Size = new System.Drawing.Size(95, 16);
            this.du2.TabIndex = 9;
            this.du2.TabStop = true;
            this.du2.Text = "由邻接表求度";
            this.du2.UseVisualStyleBackColor = true;
            this.du2.CheckedChanged += new System.EventHandler(this.du2_CheckedChanged);
            // 
            // getdu
            // 
            this.getdu.Location = new System.Drawing.Point(420, 235);
            this.getdu.Name = "getdu";
            this.getdu.Size = new System.Drawing.Size(75, 23);
            this.getdu.TabIndex = 10;
            this.getdu.Text = "求顶点的度";
            this.getdu.UseVisualStyleBackColor = true;
            this.getdu.Click += new System.EventHandler(this.getdu_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(294, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "输出邻接矩阵";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(420, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "输出邻接表";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "输入格式：1 0 1 0 1, 1 1 0 1 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "选择预置图";
            // 
            // shiyan4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.getdu);
            this.Controls.Add(this.du2);
            this.Controls.Add(this.du1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dispbutton);
            this.Controls.Add(this.dispbox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox1);
            this.Name = "shiyan4";
            this.Text = "shiyan4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox dispbox;
        private System.Windows.Forms.Button dispbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton du1;
        private System.Windows.Forms.RadioButton du2;
        private System.Windows.Forms.Button getdu;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}