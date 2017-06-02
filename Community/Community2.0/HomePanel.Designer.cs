namespace Community2._0
{
    partial class HomePanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QSettingPanel = new System.Windows.Forms.Panel();
            this.QSettingsLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuggestedPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PostingPanel = new System.Windows.Forms.Panel();
            this.postings1 = new Community2._0.Postings();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.PostingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuggestedPanel.SuspendLayout();
            this.PostingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QSettingPanel);
            this.splitContainer1.Panel1.Controls.Add(this.QSettingsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PostingPanel);
            this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel2.Controls.Add(this.PostingLabel);
            this.splitContainer1.Size = new System.Drawing.Size(572, 452);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 2;
            // 
            // QSettingPanel
            // 
            this.QSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QSettingPanel.Location = new System.Drawing.Point(0, 231);
            this.QSettingPanel.Name = "QSettingPanel";
            this.QSettingPanel.Size = new System.Drawing.Size(276, 221);
            this.QSettingPanel.TabIndex = 2;
            // 
            // QSettingsLabel
            // 
            this.QSettingsLabel.AutoSize = true;
            this.QSettingsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.QSettingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QSettingsLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QSettingsLabel.Location = new System.Drawing.Point(0, 182);
            this.QSettingsLabel.Name = "QSettingsLabel";
            this.QSettingsLabel.Size = new System.Drawing.Size(273, 49);
            this.QSettingsLabel.TabIndex = 1;
            this.QSettingsLabel.Text = "Quick Settings";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SuggestedPanel);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 182);
            this.panel3.TabIndex = 0;
            // 
            // SuggestedPanel
            // 
            this.SuggestedPanel.Controls.Add(this.label3);
            this.SuggestedPanel.Location = new System.Drawing.Point(25, 87);
            this.SuggestedPanel.Name = "SuggestedPanel";
            this.SuggestedPanel.Size = new System.Drawing.Size(248, 86);
            this.SuggestedPanel.TabIndex = 3;
            this.SuggestedPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "suggested";
            this.label3.Visible = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(98, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 19);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 18, 0);
            this.label2.Size = new System.Drawing.Size(278, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quick Search";
            // 
            // PostingPanel
            // 
            this.PostingPanel.Controls.Add(this.postings1);
            this.PostingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostingPanel.Location = new System.Drawing.Point(0, 49);
            this.PostingPanel.Name = "PostingPanel";
            this.PostingPanel.Size = new System.Drawing.Size(275, 403);
            this.PostingPanel.TabIndex = 2;
            // 
            // postings1
            // 
            this.postings1.BackColor = System.Drawing.SystemColors.Control;
            this.postings1.Dock = System.Windows.Forms.DockStyle.Top;
            this.postings1.Location = new System.Drawing.Point(0, 0);
            this.postings1.Name = "postings1";
            this.postings1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.postings1.Size = new System.Drawing.Size(275, 129);
            this.postings1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(275, 49);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 403);
            this.vScrollBar1.TabIndex = 1;
            // 
            // PostingLabel
            // 
            this.PostingLabel.AutoSize = true;
            this.PostingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PostingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostingLabel.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostingLabel.Location = new System.Drawing.Point(0, 0);
            this.PostingLabel.Name = "PostingLabel";
            this.PostingLabel.Padding = new System.Windows.Forms.Padding(60, 0, 62, 0);
            this.PostingLabel.Size = new System.Drawing.Size(289, 49);
            this.PostingLabel.TabIndex = 0;
            this.PostingLabel.Text = "Postings";
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(572, 452);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.SuggestedPanel.ResumeLayout(false);
            this.SuggestedPanel.PerformLayout();
            this.PostingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel QSettingPanel;
        private System.Windows.Forms.Label QSettingsLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SuggestedPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PostingPanel;
        private Postings postings1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label PostingLabel;
    }
}
