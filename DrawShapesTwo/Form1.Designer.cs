namespace DrawShapesTwo
{
    partial class Form1
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1232, 518);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDisplay_MouseMove);
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetColor.Location = new System.Drawing.Point(48, 538);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(164, 52);
            this.buttonSetColor.TabIndex = 1;
            this.buttonSetColor.Text = "Set Color";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonSetColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 615);
            this.Controls.Add(this.buttonSetColor);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

