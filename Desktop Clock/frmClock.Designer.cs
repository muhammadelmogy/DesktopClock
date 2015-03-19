namespace Desktop_Clock
{
    partial class frmClock
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
            this.lblClockDisplay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrangeTheme = new System.Windows.Forms.Label();
            this.lblBlueTheme = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClockDisplay
            // 
            this.lblClockDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.lblClockDisplay.Font = new System.Drawing.Font("Consolas", 52F, System.Drawing.FontStyle.Bold);
            this.lblClockDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblClockDisplay.Name = "lblClockDisplay";
            this.lblClockDisplay.Size = new System.Drawing.Size(225, 98);
            this.lblClockDisplay.TabIndex = 0;
            this.lblClockDisplay.Text = "label1";
            this.lblClockDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClockDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClockDisplay_MouseDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblDate.Location = new System.Drawing.Point(12, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "lblDate";
            this.lblDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDate_MouseDown);
            // 
            // lblOrangeTheme
            // 
            this.lblOrangeTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrangeTheme.Location = new System.Drawing.Point(222, 122);
            this.lblOrangeTheme.Name = "lblOrangeTheme";
            this.lblOrangeTheme.Size = new System.Drawing.Size(15, 15);
            this.lblOrangeTheme.TabIndex = 3;
            this.lblOrangeTheme.Click += new System.EventHandler(this.lblOrangeTheme_Click);
            // 
            // lblBlueTheme
            // 
            this.lblBlueTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlueTheme.Location = new System.Drawing.Point(201, 122);
            this.lblBlueTheme.Name = "lblBlueTheme";
            this.lblBlueTheme.Size = new System.Drawing.Size(15, 15);
            this.lblBlueTheme.TabIndex = 4;
            this.lblBlueTheme.Click += new System.EventHandler(this.lblBlueTheme_Click);
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblClose.Location = new System.Drawing.Point(222, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 15);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(249, 151);
            this.ControlBox = false;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblBlueTheme);
            this.Controls.Add(this.lblOrangeTheme);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClockDisplay);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClock_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClockDisplay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrangeTheme;
        private System.Windows.Forms.Label lblBlueTheme;
        private System.Windows.Forms.Label lblClose;
    }
}

