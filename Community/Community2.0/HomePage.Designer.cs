namespace Community2._0
{
    partial class HomePage
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
            this.TopMenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.TopMenuPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuPanel
            // 
            this.TopMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopMenuPanel.BackgroundImage = global::Community2._0.Properties.Resources._30Top2;
            this.TopMenuPanel.Controls.Add(this.label1);
            this.TopMenuPanel.Controls.Add(this.MinButton);
            this.TopMenuPanel.Controls.Add(this.MaxButton);
            this.TopMenuPanel.Controls.Add(this.ExitButton);
            this.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMenuPanel.Name = "TopMenuPanel";
            this.TopMenuPanel.Size = new System.Drawing.Size(772, 35);
            this.TopMenuPanel.TabIndex = 1;
            this.TopMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuPanel_MouseDown);
            this.TopMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMenuPanel_MouseMove);
            this.TopMenuPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopMenuPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "No logs, No limits";
            // 
            // MinButton
            // 
            this.MinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Location = new System.Drawing.Point(670, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(34, 35);
            this.MinButton.TabIndex = 2;
            this.MinButton.Text = "_";
            this.MinButton.UseVisualStyleBackColor = true;
            // 
            // MaxButton
            // 
            this.MaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxButton.FlatAppearance.BorderSize = 0;
            this.MaxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.MaxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.Location = new System.Drawing.Point(704, 0);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(34, 35);
            this.MaxButton.TabIndex = 1;
            this.MaxButton.Text = "[ ]";
            this.MaxButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(738, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.Transparent;
            this.HomePanel.Controls.Add(this.PagePanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 35);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(772, 452);
            this.HomePanel.TabIndex = 3;
            // 
            // PagePanel
            // 
            this.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagePanel.Location = new System.Drawing.Point(0, 0);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(772, 452);
            this.PagePanel.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Community2._0.Properties.Resources.jPj13Lo;
            this.ClientSize = new System.Drawing.Size(772, 487);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.TopMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.TopMenuPanel.ResumeLayout(false);
            this.TopMenuPanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenuPanel;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel PagePanel;
        private System.Windows.Forms.Label label1;
    }
}