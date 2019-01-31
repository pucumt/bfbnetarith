namespace bfbnetarith
{
    partial class setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDivide = new System.Windows.Forms.CheckBox();
            this.chkMulti = new System.Windows.Forms.CheckBox();
            this.chkminus = new System.Windows.Forms.CheckBox();
            this.chkplus = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb20);
            this.groupBox1.Controls.Add(this.rdb10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "题目难度";
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(246, 24);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(74, 19);
            this.rdb20.TabIndex = 1;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20以内";
            this.rdb20.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(74, 24);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(74, 19);
            this.rdb10.TabIndex = 0;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10以内";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDivide);
            this.groupBox2.Controls.Add(this.chkMulti);
            this.groupBox2.Controls.Add(this.chkminus);
            this.groupBox2.Controls.Add(this.chkplus);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运算符";
            // 
            // chkDivide
            // 
            this.chkDivide.AutoSize = true;
            this.chkDivide.Location = new System.Drawing.Point(360, 30);
            this.chkDivide.Name = "chkDivide";
            this.chkDivide.Size = new System.Drawing.Size(37, 19);
            this.chkDivide.TabIndex = 3;
            this.chkDivide.Text = "/";
            this.chkDivide.UseVisualStyleBackColor = true;
            // 
            // chkMulti
            // 
            this.chkMulti.AutoSize = true;
            this.chkMulti.Location = new System.Drawing.Point(246, 30);
            this.chkMulti.Name = "chkMulti";
            this.chkMulti.Size = new System.Drawing.Size(44, 19);
            this.chkMulti.TabIndex = 2;
            this.chkMulti.Text = "×";
            this.chkMulti.UseVisualStyleBackColor = true;
            // 
            // chkminus
            // 
            this.chkminus.AutoSize = true;
            this.chkminus.Location = new System.Drawing.Point(139, 30);
            this.chkminus.Name = "chkminus";
            this.chkminus.Size = new System.Drawing.Size(37, 19);
            this.chkminus.TabIndex = 1;
            this.chkminus.Text = "-";
            this.chkminus.UseVisualStyleBackColor = true;
            // 
            // chkplus
            // 
            this.chkplus.AutoSize = true;
            this.chkplus.Location = new System.Drawing.Point(32, 30);
            this.chkplus.Name = "chkplus";
            this.chkplus.Size = new System.Drawing.Size(37, 19);
            this.chkplus.TabIndex = 0;
            this.chkplus.Text = "+";
            this.chkplus.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "题型选择";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 15;
            this.cmbType.Items.AddRange(new object[] {
            "得数运算",
            "填空运算",
            "两边填空"});
            this.cmbType.Location = new System.Drawing.Point(74, 24);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(130, 23);
            this.cmbType.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(290, 238);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "生成题目";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 288);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDivide;
        private System.Windows.Forms.CheckBox chkMulti;
        private System.Windows.Forms.CheckBox chkminus;
        private System.Windows.Forms.CheckBox chkplus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnGenerate;
    }
}