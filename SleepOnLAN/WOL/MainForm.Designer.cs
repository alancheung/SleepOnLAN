
namespace WOLClient
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
            this.WakeDesktopButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SleepLaptopButton = new System.Windows.Forms.Button();
            this.SleepDesktopButton = new System.Windows.Forms.Button();
            this.WakeLaptopButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WakeDesktopButton
            // 
            this.WakeDesktopButton.Location = new System.Drawing.Point(3, 3);
            this.WakeDesktopButton.Name = "WakeDesktopButton";
            this.WakeDesktopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.WakeDesktopButton.Size = new System.Drawing.Size(216, 101);
            this.WakeDesktopButton.TabIndex = 0;
            this.WakeDesktopButton.Text = "Wake Desktop";
            this.WakeDesktopButton.UseVisualStyleBackColor = true;
            this.WakeDesktopButton.Click += new System.EventHandler(this.WakeDesktopButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.SleepLaptopButton);
            this.MainPanel.Controls.Add(this.SleepDesktopButton);
            this.MainPanel.Controls.Add(this.WakeDesktopButton);
            this.MainPanel.Controls.Add(this.WakeLaptopButton);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(424, 214);
            this.MainPanel.TabIndex = 0;
            // 
            // SleepLaptopButton
            // 
            this.SleepLaptopButton.Location = new System.Drawing.Point(225, 110);
            this.SleepLaptopButton.Name = "SleepLaptopButton";
            this.SleepLaptopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.SleepLaptopButton.Size = new System.Drawing.Size(196, 101);
            this.SleepLaptopButton.TabIndex = 3;
            this.SleepLaptopButton.Text = "Sleep Laptop";
            this.SleepLaptopButton.UseVisualStyleBackColor = true;
            this.SleepLaptopButton.Click += new System.EventHandler(this.SleepLaptopButton_Click);
            // 
            // SleepDesktopButton
            // 
            this.SleepDesktopButton.Location = new System.Drawing.Point(3, 110);
            this.SleepDesktopButton.Name = "SleepDesktopButton";
            this.SleepDesktopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.SleepDesktopButton.Size = new System.Drawing.Size(216, 101);
            this.SleepDesktopButton.TabIndex = 2;
            this.SleepDesktopButton.Text = "Sleep Desktop";
            this.SleepDesktopButton.UseVisualStyleBackColor = true;
            this.SleepDesktopButton.Click += new System.EventHandler(this.SleepDesktopButton_Click);
            // 
            // WakeLaptopButton
            // 
            this.WakeLaptopButton.Location = new System.Drawing.Point(225, 3);
            this.WakeLaptopButton.Name = "WakeLaptopButton";
            this.WakeLaptopButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.WakeLaptopButton.Size = new System.Drawing.Size(196, 101);
            this.WakeLaptopButton.TabIndex = 1;
            this.WakeLaptopButton.Text = "Wake Laptop";
            this.WakeLaptopButton.UseVisualStyleBackColor = true;
            this.WakeLaptopButton.Click += new System.EventHandler(this.WakeLaptopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 241);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "WOL";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WakeDesktopButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button WakeLaptopButton;
        private System.Windows.Forms.Button SleepLaptopButton;
        private System.Windows.Forms.Button SleepDesktopButton;
    }
}

