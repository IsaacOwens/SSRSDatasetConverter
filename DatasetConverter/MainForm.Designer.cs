namespace DatasetConverter
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
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.labelDefDatabase = new System.Windows.Forms.Label();
            this.labelDefSchema = new System.Windows.Forms.Label();
            this.labelDefDescription = new System.Windows.Forms.Label();
            this.labelDefBy = new System.Windows.Forms.Label();
            this.labelDefDate = new System.Windows.Forms.Label();
            this.labelDefNotes = new System.Windows.Forms.Label();
            this.labelDefTemplate = new System.Windows.Forms.Label();
            this.textBoxDefDatabase = new System.Windows.Forms.TextBox();
            this.textBoxDefSchema = new System.Windows.Forms.TextBox();
            this.textBoxDefDescription = new System.Windows.Forms.TextBox();
            this.textBoxDefBy = new System.Windows.Forms.TextBox();
            this.textBoxDefDate = new System.Windows.Forms.TextBox();
            this.textBoxDefNotes = new System.Windows.Forms.TextBox();
            this.textBoxDefTemplate = new System.Windows.Forms.TextBox();
            this.buttonStartProc = new System.Windows.Forms.Button();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(13, 13);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(85, 23);
            this.buttonSelectFolder.TabIndex = 0;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(150, 18);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(0, 13);
            this.labelFolderPath.TabIndex = 1;
            // 
            // labelDefDatabase
            // 
            this.labelDefDatabase.AutoSize = true;
            this.labelDefDatabase.Location = new System.Drawing.Point(13, 43);
            this.labelDefDatabase.Name = "labelDefDatabase";
            this.labelDefDatabase.Size = new System.Drawing.Size(90, 13);
            this.labelDefDatabase.TabIndex = 2;
            this.labelDefDatabase.Text = "Default Database";
            // 
            // labelDefSchema
            // 
            this.labelDefSchema.AutoSize = true;
            this.labelDefSchema.Location = new System.Drawing.Point(13, 65);
            this.labelDefSchema.Name = "labelDefSchema";
            this.labelDefSchema.Size = new System.Drawing.Size(83, 13);
            this.labelDefSchema.TabIndex = 3;
            this.labelDefSchema.Text = "Default Schema";
            // 
            // labelDefDescription
            // 
            this.labelDefDescription.AutoSize = true;
            this.labelDefDescription.Location = new System.Drawing.Point(13, 88);
            this.labelDefDescription.Name = "labelDefDescription";
            this.labelDefDescription.Size = new System.Drawing.Size(97, 13);
            this.labelDefDescription.TabIndex = 4;
            this.labelDefDescription.Text = "Default Description";
            // 
            // labelDefBy
            // 
            this.labelDefBy.AutoSize = true;
            this.labelDefBy.Location = new System.Drawing.Point(13, 111);
            this.labelDefBy.Name = "labelDefBy";
            this.labelDefBy.Size = new System.Drawing.Size(96, 13);
            this.labelDefBy.TabIndex = 5;
            this.labelDefBy.Text = "Default Created By";
            // 
            // labelDefDate
            // 
            this.labelDefDate.AutoSize = true;
            this.labelDefDate.Location = new System.Drawing.Point(13, 134);
            this.labelDefDate.Name = "labelDefDate";
            this.labelDefDate.Size = new System.Drawing.Size(109, 13);
            this.labelDefDate.TabIndex = 6;
            this.labelDefDate.Text = "Default Creation Date";
            // 
            // labelDefNotes
            // 
            this.labelDefNotes.AutoSize = true;
            this.labelDefNotes.Location = new System.Drawing.Point(13, 156);
            this.labelDefNotes.Name = "labelDefNotes";
            this.labelDefNotes.Size = new System.Drawing.Size(72, 13);
            this.labelDefNotes.TabIndex = 7;
            this.labelDefNotes.Text = "Default Notes";
            // 
            // labelDefTemplate
            // 
            this.labelDefTemplate.AutoSize = true;
            this.labelDefTemplate.Location = new System.Drawing.Point(13, 178);
            this.labelDefTemplate.Name = "labelDefTemplate";
            this.labelDefTemplate.Size = new System.Drawing.Size(88, 13);
            this.labelDefTemplate.TabIndex = 8;
            this.labelDefTemplate.Text = "Default Template";
            // 
            // textBoxDefDatabase
            // 
            this.textBoxDefDatabase.Location = new System.Drawing.Point(153, 40);
            this.textBoxDefDatabase.Name = "textBoxDefDatabase";
            this.textBoxDefDatabase.Size = new System.Drawing.Size(217, 20);
            this.textBoxDefDatabase.TabIndex = 9;
            // 
            // textBoxDefSchema
            // 
            this.textBoxDefSchema.Location = new System.Drawing.Point(153, 62);
            this.textBoxDefSchema.Name = "textBoxDefSchema";
            this.textBoxDefSchema.Size = new System.Drawing.Size(217, 20);
            this.textBoxDefSchema.TabIndex = 10;
            // 
            // textBoxDefDescription
            // 
            this.textBoxDefDescription.Location = new System.Drawing.Point(153, 85);
            this.textBoxDefDescription.Name = "textBoxDefDescription";
            this.textBoxDefDescription.Size = new System.Drawing.Size(217, 20);
            this.textBoxDefDescription.TabIndex = 11;
            // 
            // textBoxDefBy
            // 
            this.textBoxDefBy.Location = new System.Drawing.Point(153, 108);
            this.textBoxDefBy.Name = "textBoxDefBy";
            this.textBoxDefBy.Size = new System.Drawing.Size(217, 20);
            this.textBoxDefBy.TabIndex = 12;
            // 
            // textBoxDefDate
            // 
            this.textBoxDefDate.Location = new System.Drawing.Point(153, 131);
            this.textBoxDefDate.Name = "textBoxDefDate";
            this.textBoxDefDate.Size = new System.Drawing.Size(217, 20);
            this.textBoxDefDate.TabIndex = 13;
            // 
            // textBoxDefNotes
            // 
            this.textBoxDefNotes.Location = new System.Drawing.Point(153, 153);
            this.textBoxDefNotes.Name = "textBoxDefNotes";
            this.textBoxDefNotes.Size = new System.Drawing.Size(621, 20);
            this.textBoxDefNotes.TabIndex = 14;
            // 
            // textBoxDefTemplate
            // 
            this.textBoxDefTemplate.AcceptsReturn = true;
            this.textBoxDefTemplate.AcceptsTab = true;
            this.textBoxDefTemplate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefTemplate.Location = new System.Drawing.Point(153, 175);
            this.textBoxDefTemplate.Multiline = true;
            this.textBoxDefTemplate.Name = "textBoxDefTemplate";
            this.textBoxDefTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDefTemplate.Size = new System.Drawing.Size(909, 309);
            this.textBoxDefTemplate.TabIndex = 15;
            // 
            // buttonStartProc
            // 
            this.buttonStartProc.Location = new System.Drawing.Point(12, 498);
            this.buttonStartProc.Name = "buttonStartProc";
            this.buttonStartProc.Size = new System.Drawing.Size(109, 23);
            this.buttonStartProc.TabIndex = 16;
            this.buttonStartProc.Text = "Start Processing";
            this.buttonStartProc.UseVisualStyleBackColor = true;
            this.buttonStartProc.Click += new System.EventHandler(this.buttonStartProc_Click);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(1027, 9);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(35, 13);
            this.linkLabelAbout.TabIndex = 17;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 533);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.buttonStartProc);
            this.Controls.Add(this.textBoxDefTemplate);
            this.Controls.Add(this.textBoxDefNotes);
            this.Controls.Add(this.textBoxDefDate);
            this.Controls.Add(this.textBoxDefBy);
            this.Controls.Add(this.textBoxDefDescription);
            this.Controls.Add(this.textBoxDefSchema);
            this.Controls.Add(this.textBoxDefDatabase);
            this.Controls.Add(this.labelDefTemplate);
            this.Controls.Add(this.labelDefNotes);
            this.Controls.Add(this.labelDefDate);
            this.Controls.Add(this.labelDefBy);
            this.Controls.Add(this.labelDefDescription);
            this.Controls.Add(this.labelDefSchema);
            this.Controls.Add(this.labelDefDatabase);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.buttonSelectFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Dataset Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.Label labelDefDatabase;
        private System.Windows.Forms.Label labelDefSchema;
        private System.Windows.Forms.Label labelDefDescription;
        private System.Windows.Forms.Label labelDefBy;
        private System.Windows.Forms.Label labelDefDate;
        private System.Windows.Forms.Label labelDefNotes;
        private System.Windows.Forms.Label labelDefTemplate;
        private System.Windows.Forms.TextBox textBoxDefDatabase;
        private System.Windows.Forms.TextBox textBoxDefSchema;
        private System.Windows.Forms.TextBox textBoxDefDescription;
        private System.Windows.Forms.TextBox textBoxDefBy;
        private System.Windows.Forms.TextBox textBoxDefDate;
        private System.Windows.Forms.TextBox textBoxDefNotes;
        private System.Windows.Forms.TextBox textBoxDefTemplate;
        private System.Windows.Forms.Button buttonStartProc;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
    }
}

