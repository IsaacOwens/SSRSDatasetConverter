namespace DatasetConverter
{
    partial class ProcessingForm
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
            this.textBoxTempOutput = new System.Windows.Forms.TextBox();
            this.textBoxTempNotes = new System.Windows.Forms.TextBox();
            this.textBoxTempDate = new System.Windows.Forms.TextBox();
            this.textBoxTempBy = new System.Windows.Forms.TextBox();
            this.textBoxTempDescription = new System.Windows.Forms.TextBox();
            this.textBoxTempSchema = new System.Windows.Forms.TextBox();
            this.textBoxTempDatabase = new System.Windows.Forms.TextBox();
            this.labelTempTemplate = new System.Windows.Forms.Label();
            this.labelTempNotes = new System.Windows.Forms.Label();
            this.labelTempDate = new System.Windows.Forms.Label();
            this.labelTempBy = new System.Windows.Forms.Label();
            this.labelTempDescription = new System.Windows.Forms.Label();
            this.labelTempSchema = new System.Windows.Forms.Label();
            this.labelTempDatabase = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTempDatasetName = new System.Windows.Forms.Label();
            this.labelTempParameters = new System.Windows.Forms.Label();
            this.textBoxTempDatasetName = new System.Windows.Forms.TextBox();
            this.textBoxTempParameters = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTempOutput
            // 
            this.textBoxTempOutput.AcceptsReturn = true;
            this.textBoxTempOutput.AcceptsTab = true;
            this.textBoxTempOutput.Font = new System.Drawing.Font("Courier New", 8F);
            this.textBoxTempOutput.Location = new System.Drawing.Point(90, 144);
            this.textBoxTempOutput.Multiline = true;
            this.textBoxTempOutput.Name = "textBoxTempOutput";
            this.textBoxTempOutput.ReadOnly = true;
            this.textBoxTempOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTempOutput.Size = new System.Drawing.Size(955, 386);
            this.textBoxTempOutput.TabIndex = 29;
            // 
            // textBoxTempNotes
            // 
            this.textBoxTempNotes.Location = new System.Drawing.Point(90, 122);
            this.textBoxTempNotes.Name = "textBoxTempNotes";
            this.textBoxTempNotes.Size = new System.Drawing.Size(621, 20);
            this.textBoxTempNotes.TabIndex = 28;
            // 
            // textBoxTempDate
            // 
            this.textBoxTempDate.Location = new System.Drawing.Point(90, 100);
            this.textBoxTempDate.Name = "textBoxTempDate";
            this.textBoxTempDate.Size = new System.Drawing.Size(217, 20);
            this.textBoxTempDate.TabIndex = 27;
            // 
            // textBoxTempBy
            // 
            this.textBoxTempBy.Location = new System.Drawing.Point(90, 77);
            this.textBoxTempBy.Name = "textBoxTempBy";
            this.textBoxTempBy.Size = new System.Drawing.Size(217, 20);
            this.textBoxTempBy.TabIndex = 26;
            // 
            // textBoxTempDescription
            // 
            this.textBoxTempDescription.Location = new System.Drawing.Point(90, 54);
            this.textBoxTempDescription.Name = "textBoxTempDescription";
            this.textBoxTempDescription.Size = new System.Drawing.Size(217, 20);
            this.textBoxTempDescription.TabIndex = 25;
            // 
            // textBoxTempSchema
            // 
            this.textBoxTempSchema.Location = new System.Drawing.Point(90, 31);
            this.textBoxTempSchema.Name = "textBoxTempSchema";
            this.textBoxTempSchema.Size = new System.Drawing.Size(217, 20);
            this.textBoxTempSchema.TabIndex = 24;
            // 
            // textBoxTempDatabase
            // 
            this.textBoxTempDatabase.Location = new System.Drawing.Point(90, 9);
            this.textBoxTempDatabase.Name = "textBoxTempDatabase";
            this.textBoxTempDatabase.Size = new System.Drawing.Size(217, 20);
            this.textBoxTempDatabase.TabIndex = 23;
            // 
            // labelTempTemplate
            // 
            this.labelTempTemplate.AutoSize = true;
            this.labelTempTemplate.Location = new System.Drawing.Point(12, 144);
            this.labelTempTemplate.Name = "labelTempTemplate";
            this.labelTempTemplate.Size = new System.Drawing.Size(39, 13);
            this.labelTempTemplate.TabIndex = 22;
            this.labelTempTemplate.Text = "Output";
            // 
            // labelTempNotes
            // 
            this.labelTempNotes.AutoSize = true;
            this.labelTempNotes.Location = new System.Drawing.Point(12, 122);
            this.labelTempNotes.Name = "labelTempNotes";
            this.labelTempNotes.Size = new System.Drawing.Size(35, 13);
            this.labelTempNotes.TabIndex = 21;
            this.labelTempNotes.Text = "Notes";
            // 
            // labelTempDate
            // 
            this.labelTempDate.AutoSize = true;
            this.labelTempDate.Location = new System.Drawing.Point(12, 100);
            this.labelTempDate.Name = "labelTempDate";
            this.labelTempDate.Size = new System.Drawing.Size(72, 13);
            this.labelTempDate.TabIndex = 20;
            this.labelTempDate.Text = "Creation Date";
            // 
            // labelTempBy
            // 
            this.labelTempBy.AutoSize = true;
            this.labelTempBy.Location = new System.Drawing.Point(12, 77);
            this.labelTempBy.Name = "labelTempBy";
            this.labelTempBy.Size = new System.Drawing.Size(59, 13);
            this.labelTempBy.TabIndex = 19;
            this.labelTempBy.Text = "Created By";
            // 
            // labelTempDescription
            // 
            this.labelTempDescription.AutoSize = true;
            this.labelTempDescription.Location = new System.Drawing.Point(12, 54);
            this.labelTempDescription.Name = "labelTempDescription";
            this.labelTempDescription.Size = new System.Drawing.Size(60, 13);
            this.labelTempDescription.TabIndex = 18;
            this.labelTempDescription.Text = "Description";
            // 
            // labelTempSchema
            // 
            this.labelTempSchema.AutoSize = true;
            this.labelTempSchema.Location = new System.Drawing.Point(12, 31);
            this.labelTempSchema.Name = "labelTempSchema";
            this.labelTempSchema.Size = new System.Drawing.Size(46, 13);
            this.labelTempSchema.TabIndex = 17;
            this.labelTempSchema.Text = "Schema";
            // 
            // labelTempDatabase
            // 
            this.labelTempDatabase.AutoSize = true;
            this.labelTempDatabase.Location = new System.Drawing.Point(12, 9);
            this.labelTempDatabase.Name = "labelTempDatabase";
            this.labelTempDatabase.Size = new System.Drawing.Size(53, 13);
            this.labelTempDatabase.TabIndex = 16;
            this.labelTempDatabase.Text = "Database";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(784, 536);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 30;
            this.buttonConfirm.Text = "Looks Good";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(876, 536);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(15, 388);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 13);
            this.labelCount.TabIndex = 32;
            // 
            // labelTempDatasetName
            // 
            this.labelTempDatasetName.AutoSize = true;
            this.labelTempDatasetName.Location = new System.Drawing.Point(355, 8);
            this.labelTempDatasetName.Name = "labelTempDatasetName";
            this.labelTempDatasetName.Size = new System.Drawing.Size(75, 13);
            this.labelTempDatasetName.TabIndex = 33;
            this.labelTempDatasetName.Text = "Dataset Name";
            // 
            // labelTempParameters
            // 
            this.labelTempParameters.AutoSize = true;
            this.labelTempParameters.Location = new System.Drawing.Point(358, 31);
            this.labelTempParameters.Name = "labelTempParameters";
            this.labelTempParameters.Size = new System.Drawing.Size(60, 13);
            this.labelTempParameters.TabIndex = 34;
            this.labelTempParameters.Text = "Parameters";
            // 
            // textBoxTempDatasetName
            // 
            this.textBoxTempDatasetName.Location = new System.Drawing.Point(436, 6);
            this.textBoxTempDatasetName.Name = "textBoxTempDatasetName";
            this.textBoxTempDatasetName.Size = new System.Drawing.Size(229, 20);
            this.textBoxTempDatasetName.TabIndex = 35;
            // 
            // textBoxTempParameters
            // 
            this.textBoxTempParameters.Location = new System.Drawing.Point(436, 31);
            this.textBoxTempParameters.Name = "textBoxTempParameters";
            this.textBoxTempParameters.Size = new System.Drawing.Size(229, 20);
            this.textBoxTempParameters.TabIndex = 36;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(490, 536);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 37;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 571);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxTempParameters);
            this.Controls.Add(this.textBoxTempDatasetName);
            this.Controls.Add(this.labelTempParameters);
            this.Controls.Add(this.labelTempDatasetName);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxTempOutput);
            this.Controls.Add(this.textBoxTempNotes);
            this.Controls.Add(this.textBoxTempDate);
            this.Controls.Add(this.textBoxTempBy);
            this.Controls.Add(this.textBoxTempDescription);
            this.Controls.Add(this.textBoxTempSchema);
            this.Controls.Add(this.textBoxTempDatabase);
            this.Controls.Add(this.labelTempTemplate);
            this.Controls.Add(this.labelTempNotes);
            this.Controls.Add(this.labelTempDate);
            this.Controls.Add(this.labelTempBy);
            this.Controls.Add(this.labelTempDescription);
            this.Controls.Add(this.labelTempSchema);
            this.Controls.Add(this.labelTempDatabase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessingForm";
            this.Text = "Processing Form";
            this.Load += new System.EventHandler(this.ProcessingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTempOutput;
        private System.Windows.Forms.TextBox textBoxTempNotes;
        private System.Windows.Forms.TextBox textBoxTempDate;
        private System.Windows.Forms.TextBox textBoxTempBy;
        private System.Windows.Forms.TextBox textBoxTempDescription;
        private System.Windows.Forms.TextBox textBoxTempSchema;
        private System.Windows.Forms.TextBox textBoxTempDatabase;
        private System.Windows.Forms.Label labelTempTemplate;
        private System.Windows.Forms.Label labelTempNotes;
        private System.Windows.Forms.Label labelTempDate;
        private System.Windows.Forms.Label labelTempBy;
        private System.Windows.Forms.Label labelTempDescription;
        private System.Windows.Forms.Label labelTempSchema;
        private System.Windows.Forms.Label labelTempDatabase;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTempDatasetName;
        private System.Windows.Forms.Label labelTempParameters;
        private System.Windows.Forms.TextBox textBoxTempDatasetName;
        private System.Windows.Forms.TextBox textBoxTempParameters;
        private System.Windows.Forms.Button buttonRefresh;
    }
}