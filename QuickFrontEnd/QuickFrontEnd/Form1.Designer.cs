namespace QuickFrontEnd
{
    partial class FQ2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQ2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbJzIntv = new System.Windows.Forms.GroupBox();
            this.cVoice = new System.Windows.Forms.CheckBox();
            this.cECS = new System.Windows.Forms.CheckBox();
            this.chkFull = new System.Windows.Forms.CheckBox();
            this.bHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.bRUN = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbJzIntv.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // gbJzIntv
            // 
            resources.ApplyResources(this.gbJzIntv, "gbJzIntv");
            this.gbJzIntv.Controls.Add(this.cVoice);
            this.gbJzIntv.Controls.Add(this.cECS);
            this.gbJzIntv.Controls.Add(this.chkFull);
            this.gbJzIntv.Controls.Add(this.bHelp);
            this.gbJzIntv.Controls.Add(this.label1);
            this.gbJzIntv.Controls.Add(this.comboBox1);
            this.gbJzIntv.Name = "gbJzIntv";
            this.gbJzIntv.TabStop = false;
            // 
            // cVoice
            // 
            this.cVoice.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this.cVoice, "cVoice");
            this.cVoice.Checked = true;
            this.cVoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cVoice.Name = "cVoice";
            this.cVoice.UseVisualStyleBackColor = true;
            // 
            // cECS
            // 
            this.cECS.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this.cECS, "cECS");
            this.cECS.Name = "cECS";
            this.cECS.UseVisualStyleBackColor = true;
            // 
            // chkFull
            // 
            resources.ApplyResources(this.chkFull, "chkFull");
            this.chkFull.Name = "chkFull";
            this.chkFull.UseVisualStyleBackColor = true;
            // 
            // bHelp
            // 
            resources.ApplyResources(this.bHelp, "bHelp");
            this.bHelp.Name = "bHelp";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10")});
            this.comboBox1.Name = "comboBox1";
            // 
            // labelFolder
            // 
            resources.ApplyResources(this.labelFolder, "labelFolder");
            this.labelFolder.Name = "labelFolder";
            // 
            // bRUN
            // 
            resources.ApplyResources(this.bRUN, "bRUN");
            this.bRUN.Name = "bRUN";
            this.bRUN.UseVisualStyleBackColor = true;
            this.bRUN.Click += new System.EventHandler(this.RunClick);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            // 
            // FQ2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bRUN);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.gbJzIntv);
            this.Controls.Add(this.listBox1);
            this.Name = "FQ2";
            this.Load += new System.EventHandler(this.FQLoad);
            this.ResizeBegin += new System.EventHandler(this.FQ_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FQ_ResizeEnd);
            this.gbJzIntv.ResumeLayout(false);
            this.gbJzIntv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbJzIntv;
        private System.Windows.Forms.CheckBox cVoice;
        private System.Windows.Forms.CheckBox cECS;
        private System.Windows.Forms.CheckBox chkFull;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button bRUN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}

