namespace Community2._0
{
    partial class PostCustPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Titletxt = new System.Windows.Forms.Label();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.Label();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.DeleteDate = new System.Windows.Forms.DateTimePicker();
            this.DeleteTxt = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            this.DatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.textBox3);
            this.TitlePanel.Controls.Add(this.Titletxt);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Padding = new System.Windows.Forms.Padding(60, 25, 0, 0);
            this.TitlePanel.Size = new System.Drawing.Size(572, 63);
            this.TitlePanel.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox3.Location = new System.Drawing.Point(94, 25);
            this.textBox3.MaxLength = 255;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 26);
            this.textBox3.TabIndex = 1;
            // 
            // Titletxt
            // 
            this.Titletxt.AutoSize = true;
            this.Titletxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Titletxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titletxt.Location = new System.Drawing.Point(60, 25);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Titletxt.Size = new System.Drawing.Size(34, 21);
            this.Titletxt.TabIndex = 0;
            this.Titletxt.Text = "Title";
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Controls.Add(this.label3);
            this.DescriptionPanel.Controls.Add(this.textBox4);
            this.DescriptionPanel.Controls.Add(this.textBox2);
            this.DescriptionPanel.Controls.Add(this.DescriptionTxt);
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DescriptionPanel.Location = new System.Drawing.Point(0, 63);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.DescriptionPanel.Size = new System.Drawing.Size(572, 135);
            this.DescriptionPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox4.Location = new System.Drawing.Point(446, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Location = new System.Drawing.Point(98, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 115);
            this.textBox2.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.AutoSize = true;
            this.DescriptionTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.DescriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxt.Location = new System.Drawing.Point(20, 10);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(78, 19);
            this.DescriptionTxt.TabIndex = 0;
            this.DescriptionTxt.Text = "Description";
            // 
            // DatePanel
            // 
            this.DatePanel.Controls.Add(this.DeleteDate);
            this.DatePanel.Controls.Add(this.DeleteTxt);
            this.DatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatePanel.Location = new System.Drawing.Point(0, 198);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Padding = new System.Windows.Forms.Padding(15, 13, 10, 0);
            this.DatePanel.Size = new System.Drawing.Size(572, 49);
            this.DatePanel.TabIndex = 3;
            // 
            // DeleteDate
            // 
            this.DeleteDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteDate.Location = new System.Drawing.Point(96, 13);
            this.DeleteDate.Name = "DeleteDate";
            this.DeleteDate.Size = new System.Drawing.Size(200, 20);
            this.DeleteDate.TabIndex = 0;
            // 
            // DeleteTxt
            // 
            this.DeleteTxt.AutoSize = true;
            this.DeleteTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTxt.Location = new System.Drawing.Point(15, 13);
            this.DeleteTxt.Name = "DeleteTxt";
            this.DeleteTxt.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.DeleteTxt.Size = new System.Drawing.Size(81, 20);
            this.DeleteTxt.TabIndex = 1;
            this.DeleteTxt.Text = "Delete Date";
            // 
            // PostCustPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.DescriptionPanel);
            this.Controls.Add(this.TitlePanel);
            this.Name = "PostCustPanel";
            this.Size = new System.Drawing.Size(572, 412);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.DescriptionPanel.ResumeLayout(false);
            this.DescriptionPanel.PerformLayout();
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Titletxt;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DescriptionTxt;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.DateTimePicker DeleteDate;
        private System.Windows.Forms.Label DeleteTxt;
    }
}
