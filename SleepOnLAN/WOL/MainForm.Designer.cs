
namespace WOL
{
    partial class MainForm
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
            this.DesktopButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LaptopButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DesktopButton
            // 
            this.DesktopButton.Location = new System.Drawing.Point(3, 3);
            this.DesktopButton.Name = "DesktopButton";
            this.DesktopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.DesktopButton.Size = new System.Drawing.Size(196, 161);
            this.DesktopButton.TabIndex = 0;
            this.DesktopButton.Text = "Desktop";
            this.DesktopButton.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.DesktopButton);
            this.MainPanel.Controls.Add(this.LaptopButton);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(424, 167);
            this.MainPanel.TabIndex = 0;
            // 
            // LaptopButton
            // 
            this.LaptopButton.Location = new System.Drawing.Point(225, 3);
            this.LaptopButton.Name = "LaptopButton";
            this.LaptopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.LaptopButton.Size = new System.Drawing.Size(196, 161);
            this.LaptopButton.TabIndex = 1;
            this.LaptopButton.Text = "Laptop";
            this.LaptopButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 194);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DesktopButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LaptopButton;
    }
}

