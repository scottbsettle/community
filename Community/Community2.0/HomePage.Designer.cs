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
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SlideButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsIcon = new System.Windows.Forms.Button();
            this.ProfileIcon = new System.Windows.Forms.Button();
            this.PostIcon = new System.Windows.Forms.Button();
            this.SearchIcon = new System.Windows.Forms.Button();
            this.HomeIcon = new System.Windows.Forms.Button();
            this.slideButtonIcon = new System.Windows.Forms.Button();
            this.TopMenuPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.IconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuPanel
            // 
            this.TopMenuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.MinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
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
            this.MaxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
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
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsPanel.Controls.Add(this.SettingsButton);
            this.SettingsPanel.Controls.Add(this.ProfileButton);
            this.SettingsPanel.Controls.Add(this.PostButton);
            this.SettingsPanel.Controls.Add(this.SearchButton);
            this.SettingsPanel.Controls.Add(this.HomeButton);
            this.SettingsPanel.Controls.Add(this.panel3);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 35);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 452);
            this.SettingsPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(0, 249);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(200, 56);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProfileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.Location = new System.Drawing.Point(0, 193);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(200, 56);
            this.ProfileButton.TabIndex = 3;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostButton.FlatAppearance.BorderSize = 0;
            this.PostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.Location = new System.Drawing.Point(0, 137);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(200, 56);
            this.PostButton.TabIndex = 2;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(0, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 56);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(0, 25);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(200, 56);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SlideButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 25);
            this.panel3.TabIndex = 6;
            // 
            // SlideButton
            // 
            this.SlideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SlideButton.FlatAppearance.BorderSize = 0;
            this.SlideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideButton.Location = new System.Drawing.Point(162, 0);
            this.SlideButton.Name = "SlideButton";
            this.SlideButton.Size = new System.Drawing.Size(38, 25);
            this.SlideButton.TabIndex = 0;
            this.SlideButton.Text = "<--";
            this.SlideButton.UseVisualStyleBackColor = true;
            this.SlideButton.Click += new System.EventHandler(this.SlideButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.PagePanel);
            this.HomePanel.Controls.Add(this.IconPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(200, 35);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(572, 452);
            this.HomePanel.TabIndex = 3;
            // 
            // PagePanel
            // 
            this.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagePanel.Location = new System.Drawing.Point(47, 0);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(525, 452);
            this.PagePanel.TabIndex = 0;
            // 
            // IconPanel
            // 
            this.IconPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IconPanel.Controls.Add(this.label2);
            this.IconPanel.Controls.Add(this.SettingsIcon);
            this.IconPanel.Controls.Add(this.ProfileIcon);
            this.IconPanel.Controls.Add(this.PostIcon);
            this.IconPanel.Controls.Add(this.SearchIcon);
            this.IconPanel.Controls.Add(this.HomeIcon);
            this.IconPanel.Controls.Add(this.slideButtonIcon);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(47, 452);
            this.IconPanel.TabIndex = 0;
            this.IconPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 130);
            this.label2.TabIndex = 6;
            this.label2.Text = "C\r\no\r\nm\r\nm\r\n \r\nU\r\nn\r\ni\r\nt\r\ny";
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsIcon.FlatAppearance.BorderSize = 0;
            this.SettingsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsIcon.Location = new System.Drawing.Point(0, 245);
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.Size = new System.Drawing.Size(47, 55);
            this.SettingsIcon.TabIndex = 5;
            this.SettingsIcon.Text = "Settings";
            this.SettingsIcon.UseVisualStyleBackColor = true;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileIcon.FlatAppearance.BorderSize = 0;
            this.ProfileIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileIcon.Location = new System.Drawing.Point(0, 190);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(47, 55);
            this.ProfileIcon.TabIndex = 4;
            this.ProfileIcon.Text = "Profile";
            this.ProfileIcon.UseVisualStyleBackColor = true;
            // 
            // PostIcon
            // 
            this.PostIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostIcon.FlatAppearance.BorderSize = 0;
            this.PostIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostIcon.Location = new System.Drawing.Point(0, 135);
            this.PostIcon.Name = "PostIcon";
            this.PostIcon.Size = new System.Drawing.Size(47, 55);
            this.PostIcon.TabIndex = 3;
            this.PostIcon.Text = "Post";
            this.PostIcon.UseVisualStyleBackColor = true;
            this.PostIcon.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchIcon.FlatAppearance.BorderSize = 0;
            this.SearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchIcon.Location = new System.Drawing.Point(0, 80);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(47, 55);
            this.SearchIcon.TabIndex = 2;
            this.SearchIcon.Text = "Search";
            this.SearchIcon.UseVisualStyleBackColor = true;
            this.SearchIcon.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeIcon
            // 
            this.HomeIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeIcon.FlatAppearance.BorderSize = 0;
            this.HomeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeIcon.Location = new System.Drawing.Point(0, 25);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(47, 55);
            this.HomeIcon.TabIndex = 1;
            this.HomeIcon.Text = "Home";
            this.HomeIcon.UseVisualStyleBackColor = true;
            this.HomeIcon.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // slideButtonIcon
            // 
            this.slideButtonIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.slideButtonIcon.FlatAppearance.BorderSize = 0;
            this.slideButtonIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slideButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.slideButtonIcon.Name = "slideButtonIcon";
            this.slideButtonIcon.Size = new System.Drawing.Size(47, 25);
            this.slideButtonIcon.TabIndex = 0;
            this.slideButtonIcon.Text = "-->";
            this.slideButtonIcon.UseVisualStyleBackColor = true;
            this.slideButtonIcon.Click += new System.EventHandler(this.slideButtonIcon_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 487);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.TopMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.TopMenuPanel.ResumeLayout(false);
            this.TopMenuPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.IconPanel.ResumeLayout(false);
            this.IconPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenuPanel;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel PagePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SlideButton;
        internal System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.Button SettingsIcon;
        private System.Windows.Forms.Button ProfileIcon;
        private System.Windows.Forms.Button PostIcon;
        private System.Windows.Forms.Button SearchIcon;
        private System.Windows.Forms.Button HomeIcon;
        private System.Windows.Forms.Button slideButtonIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}