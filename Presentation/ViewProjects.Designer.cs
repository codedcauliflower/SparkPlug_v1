namespace SparkPlug_v1
{
    partial class ViewProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProjects));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextPanelsPage = new System.Windows.Forms.Button();
            this.btnPreviousPanelsPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 112);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.MistyRose;
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(452, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "SparkPlug";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNextPanelsPage
            // 
            this.btnNextPanelsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnNextPanelsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPanelsPage.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNextPanelsPage.Location = new System.Drawing.Point(989, 129);
            this.btnNextPanelsPage.Name = "btnNextPanelsPage";
            this.btnNextPanelsPage.Size = new System.Drawing.Size(59, 25);
            this.btnNextPanelsPage.TabIndex = 3;
            this.btnNextPanelsPage.Text = "Next";
            this.btnNextPanelsPage.UseVisualStyleBackColor = false;
            this.btnNextPanelsPage.Click += new System.EventHandler(this.btnNextPanelsPage_Click);
            // 
            // btnPreviousPanelsPage
            // 
            this.btnPreviousPanelsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnPreviousPanelsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPanelsPage.ForeColor = System.Drawing.Color.MistyRose;
            this.btnPreviousPanelsPage.Location = new System.Drawing.Point(907, 129);
            this.btnPreviousPanelsPage.Name = "btnPreviousPanelsPage";
            this.btnPreviousPanelsPage.Size = new System.Drawing.Size(59, 25);
            this.btnPreviousPanelsPage.TabIndex = 4;
            this.btnPreviousPanelsPage.Text = "Prev";
            this.btnPreviousPanelsPage.UseVisualStyleBackColor = false;
            this.btnPreviousPanelsPage.Click += new System.EventHandler(this.btnPreviousPanelsPage_Click);
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1080, 829);
            this.Controls.Add(this.btnPreviousPanelsPage);
            this.Controls.Add(this.btnNextPanelsPage);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Projects";
            this.Load += new System.EventHandler(this.ViewProjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNextPanelsPage;
        private System.Windows.Forms.Button btnPreviousPanelsPage;
    }
}