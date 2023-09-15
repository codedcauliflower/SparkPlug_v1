namespace SparkPlug_v1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewProjects = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbxIndustry = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxComplexity = new System.Windows.Forms.ComboBox();
            this.cbxPlatform = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(335, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "SparkPlug";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewProjects
            // 
            this.btnViewProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnViewProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProjects.ForeColor = System.Drawing.Color.MistyRose;
            this.btnViewProjects.Location = new System.Drawing.Point(24, 119);
            this.btnViewProjects.Name = "btnViewProjects";
            this.btnViewProjects.Size = new System.Drawing.Size(84, 28);
            this.btnViewProjects.TabIndex = 1;
            this.btnViewProjects.Text = "view projects";
            this.btnViewProjects.UseVisualStyleBackColor = false;
            this.btnViewProjects.Click += new System.EventHandler(this.btnViewProjects_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.cbxIndustry);
            this.panel2.Controls.Add(this.cbxStyle);
            this.panel2.Controls.Add(this.cbxComplexity);
            this.panel2.Controls.Add(this.cbxPlatform);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(219, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 608);
            this.panel2.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.MistyRose;
            this.btnGenerate.Location = new System.Drawing.Point(171, 544);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(84, 28);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // cbxIndustry
            // 
            this.cbxIndustry.BackColor = System.Drawing.Color.MistyRose;
            this.cbxIndustry.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndustry.FormattingEnabled = true;
            this.cbxIndustry.Location = new System.Drawing.Point(187, 292);
            this.cbxIndustry.Name = "cbxIndustry";
            this.cbxIndustry.Size = new System.Drawing.Size(191, 21);
            this.cbxIndustry.TabIndex = 14;
            // 
            // cbxStyle
            // 
            this.cbxStyle.BackColor = System.Drawing.Color.MistyRose;
            this.cbxStyle.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(187, 232);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(191, 21);
            this.cbxStyle.TabIndex = 13;
            // 
            // cbxComplexity
            // 
            this.cbxComplexity.BackColor = System.Drawing.Color.MistyRose;
            this.cbxComplexity.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComplexity.FormattingEnabled = true;
            this.cbxComplexity.Location = new System.Drawing.Point(187, 169);
            this.cbxComplexity.Name = "cbxComplexity";
            this.cbxComplexity.Size = new System.Drawing.Size(191, 21);
            this.cbxComplexity.TabIndex = 12;
            // 
            // cbxPlatform
            // 
            this.cbxPlatform.BackColor = System.Drawing.Color.MistyRose;
            this.cbxPlatform.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlatform.FormattingEnabled = true;
            this.cbxPlatform.Location = new System.Drawing.Point(187, 114);
            this.cbxPlatform.Name = "cbxPlatform";
            this.cbxPlatform.Size = new System.Drawing.Size(191, 21);
            this.cbxPlatform.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(38, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Industry:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(38, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Style:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Complexity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Platform:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(64, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set your constraints:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(845, 896);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnViewProjects);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewProjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbxIndustry;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxComplexity;
        private System.Windows.Forms.ComboBox cbxPlatform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

