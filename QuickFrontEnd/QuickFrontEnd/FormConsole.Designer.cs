namespace QuickFrontEnd
{
    partial class FormConsole
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
            this.listcon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listcon
            // 
            this.listcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listcon.BackColor = System.Drawing.Color.Black;
            this.listcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listcon.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listcon.FormattingEnabled = true;
            this.listcon.Location = new System.Drawing.Point(12, 12);
            this.listcon.Name = "listcon";
            this.listcon.ScrollAlwaysVisible = true;
            this.listcon.Size = new System.Drawing.Size(424, 405);
            this.listcon.TabIndex = 0;
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 433);
            this.Controls.Add(this.listcon);
            this.Name = "FormConsole";
            this.Text = "FormConsole";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listcon;
    }
}