namespace Community2._0
{
    partial class NextBottomPanel
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
            this.NextPanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.NextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextPanel
            // 
            this.NextPanel.Controls.Add(this.NextButton);
            this.NextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextPanel.Location = new System.Drawing.Point(0, 0);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Padding = new System.Windows.Forms.Padding(5);
            this.NextPanel.Size = new System.Drawing.Size(572, 41);
            this.NextPanel.TabIndex = 11;
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
            // NextBottomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.NextPanel);
            this.Name = "NextBottomPanel";
            this.Size = new System.Drawing.Size(572, 41);
            this.NextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Button NextButton;
    }
}
