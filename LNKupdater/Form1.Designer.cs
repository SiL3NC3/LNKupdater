namespace LNKupdater
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
            this.checkBoxSubDirs = new System.Windows.Forms.CheckBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.labelFind = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSubDirs
            // 
            this.checkBoxSubDirs.AutoSize = true;
            this.checkBoxSubDirs.Checked = true;
            this.checkBoxSubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSubDirs.Location = new System.Drawing.Point(180, 78);
            this.checkBoxSubDirs.Name = "checkBoxSubDirs";
            this.checkBoxSubDirs.Size = new System.Drawing.Size(261, 29);
            this.checkBoxSubDirs.TabIndex = 20;
            this.checkBoxSubDirs.Text = "include sub-directories";
            this.checkBoxSubDirs.UseVisualStyleBackColor = true;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.Location = new System.Drawing.Point(1083, 173);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(215, 45);
            this.buttonReplace.TabIndex = 19;
            this.buttonReplace.Text = "Replace Targets";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(1083, 121);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(215, 45);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Tag = "";
            this.buttonDelete.Text = "Delete Files";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(175, 183);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(91, 25);
            this.labelReplace.TabIndex = 17;
            this.labelReplace.Text = "Replace";
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(175, 131);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(54, 25);
            this.labelFind.TabIndex = 16;
            this.labelFind.Text = "Find";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectory.Location = new System.Drawing.Point(24, 27);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(107, 25);
            this.labelDirectory.TabIndex = 15;
            this.labelDirectory.Text = "Directory";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplace.Location = new System.Drawing.Point(282, 180);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(602, 31);
            this.textBoxReplace.TabIndex = 14;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.Location = new System.Drawing.Point(282, 128);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(602, 31);
            this.textBoxFind.TabIndex = 13;
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectory.Location = new System.Drawing.Point(1083, 17);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(215, 45);
            this.buttonDirectory.TabIndex = 12;
            this.buttonDirectory.Text = "Choose";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(180, 24);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(877, 31);
            this.textBoxDirectory.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(29, 255);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxResult);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 862);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 21;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.ItemHeight = 25;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFiles.MinimumSize = new System.Drawing.Size(915, 4);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(1269, 430);
            this.listBoxFiles.TabIndex = 11;
            // 
            // listBoxResult
            // 
            this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(0, 0);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1269, 428);
            this.listBoxResult.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(1083, 69);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(215, 45);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.Text = "Find Files";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(640, 76);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(417, 31);
            this.textBoxFilter.TabIndex = 23;
            this.textBoxFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filename-Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(24, 157);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(125, 25);
            this.labelTarget.TabIndex = 25;
            this.labelTarget.Text = "TargetURL";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(890, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "case-sensitive!";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(890, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "case-sensitive!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 1140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.checkBoxSubDirs);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.textBoxDirectory);
            this.MinimumSize = new System.Drawing.Size(1000, 71);
            this.Name = "Form1";
            this.Text = "LNKupdater";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSubDirs;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTarget;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

