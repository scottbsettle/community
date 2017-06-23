namespace Community2._0
{
    partial class PostPanel
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MenuePanel = new System.Windows.Forms.Panel();
            this.CustButton = new System.Windows.Forms.Button();
            this.CatButton = new System.Windows.Forms.Button();
            this.ImgButton = new System.Windows.Forms.Button();
            this.NextPanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.MenuePanel.SuspendLayout();
            this.NextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.NextPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(572, 412);
            this.MainPanel.TabIndex = 1;
            // 
            // MenuePanel
            // 
            this.MenuePanel.BackgroundImage = global::Community2._0.Properties.Resources.ButtonTest;
            this.MenuePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuePanel.Controls.Add(this.CustButton);
            this.MenuePanel.Controls.Add(this.CatButton);
            this.MenuePanel.Controls.Add(this.ImgButton);
            this.MenuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuePanel.Location = new System.Drawing.Point(0, 0);
            this.MenuePanel.MaximumSize = new System.Drawing.Size(572, 40);
            this.MenuePanel.Name = "MenuePanel";
            this.MenuePanel.Size = new System.Drawing.Size(572, 40);
            this.MenuePanel.TabIndex = 0;
            // 
            // CustButton
            // 
            this.CustButton.BackColor = System.Drawing.Color.Transparent;
            this.CustButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustButton.FlatAppearance.BorderSize = 0;
            this.CustButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.CustButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.CustButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustButton.ForeColor = System.Drawing.Color.Black;
            this.CustButton.Location = new System.Drawing.Point(189, 0);
            this.CustButton.Name = "CustButton";
            this.CustButton.Size = new System.Drawing.Size(194, 40);
            this.CustButton.TabIndex = 1;
            this.CustButton.Text = "Customize";
            this.CustButton.UseVisualStyleBackColor = false;
            this.CustButton.Click += new System.EventHandler(this.CustButton_Click);
            // 
            // CatButton
            // 
            this.CatButton.BackColor = System.Drawing.Color.Transparent;
            this.CatButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CatButton.FlatAppearance.BorderSize = 0;
            this.CatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.CatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.CatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatButton.ForeColor = System.Drawing.Color.Black;
            this.CatButton.Location = new System.Drawing.Point(0, 0);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(189, 40);
            this.CatButton.TabIndex = 0;
            this.CatButton.Text = "Category";
            this.CatButton.UseVisualStyleBackColor = false;
            this.CatButton.Click += new System.EventHandler(this.CatButton_Click);
            // 
            // ImgButton
            // 
            this.ImgButton.BackColor = System.Drawing.Color.Transparent;
            this.ImgButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImgButton.FlatAppearance.BorderSize = 0;
            this.ImgButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.ImgButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgButton.ForeColor = System.Drawing.Color.Black;
            this.ImgButton.Location = new System.Drawing.Point(383, 0);
            this.ImgButton.Name = "ImgButton";
            this.ImgButton.Size = new System.Drawing.Size(189, 40);
            this.ImgButton.TabIndex = 2;
            this.ImgButton.Text = "Images";
            this.ImgButton.UseVisualStyleBackColor = false;
            this.ImgButton.Click += new System.EventHandler(this.ImgButton_Click);
            // 
            // NextPanel
            // 
            this.NextPanel.Controls.Add(this.NextButton);
            this.NextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextPanel.Location = new System.Drawing.Point(0, 371);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Padding = new System.Windows.Forms.Padding(5);
            this.NextPanel.Size = new System.Drawing.Size(572, 41);
            this.NextPanel.TabIndex = 10;
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(443, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(124, 31);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PostPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuePanel);
            this.Name = "PostPanel";
            this.Size = new System.Drawing.Size(572, 452);
            this.MainPanel.ResumeLayout(false);
            this.MenuePanel.ResumeLayout(false);
            this.NextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuePanel;
        private System.Windows.Forms.Button ImgButton;
        private System.Windows.Forms.Button CustButton;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Button NextButton;
    }
}
