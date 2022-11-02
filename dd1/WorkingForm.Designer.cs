
namespace DigitalDesignTask
{
    partial class WorkingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingForm));
            this.playingFieldSize = new System.Windows.Forms.TextBox();
            this.lblInputN = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playingFieldSize
            // 
            this.playingFieldSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.playingFieldSize.Location = new System.Drawing.Point(462, 92);
            this.playingFieldSize.MaxLength = 100;
            this.playingFieldSize.Name = "playingFieldSize";
            this.playingFieldSize.Size = new System.Drawing.Size(51, 23);
            this.playingFieldSize.TabIndex = 0;
            this.playingFieldSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInputN
            // 
            this.lblInputN.AutoSize = true;
            this.lblInputN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputN.Location = new System.Drawing.Point(171, 47);
            this.lblInputN.Name = "lblInputN";
            this.lblInputN.Size = new System.Drawing.Size(611, 25);
            this.lblInputN.TabIndex = 1;
            this.lblInputN.Text = "Enter the size of the side of the playing field. (Integer > 3). Press Enter";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(977, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInputN);
            this.Controls.Add(this.playingFieldSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 100);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "WorkingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playingFieldSize;
        private System.Windows.Forms.Label lblInputN;
        private System.Windows.Forms.Button btnExit;
    }
}

