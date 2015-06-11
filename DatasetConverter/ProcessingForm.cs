using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatasetConverter
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
        }

        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            labelCount.Text = MainForm.filesProcessed + "/" + MainForm.filesFound;

            textBoxTempDatabase.Text = MainForm.defDatabase;
            textBoxTempSchema.Text = MainForm.defSchema;
            textBoxTempDescription.Text = MainForm.defDesc;
            textBoxTempBy.Text = MainForm.defBy;
            textBoxTempDate.Text = MainForm.defDate;
            textBoxTempNotes.Text = MainForm.defNotes;

            textBoxTempDatasetName.Text = MainForm.tempDatasetName;
            textBoxTempParameters.Text = MainForm.tempParameters;

            textBoxTempOutput.Text = String.Format(MainForm.defTemplate, textBoxTempDatabase.Text, textBoxTempSchema.Text, textBoxTempDatasetName.Text, textBoxTempParameters.Text, textBoxTempDescription.Text, textBoxTempBy.Text, textBoxTempDate.Text, textBoxTempParameters.Text, textBoxTempNotes.Text, MainForm.tempQuery);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("If you cancel, all progress will be lost.",
                                                "Are you sure you want to cancel?",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MainForm.cancelled = true;
                this.Close();
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxTempOutput.Text = String.Format(MainForm.defTemplate, textBoxTempDatabase.Text, textBoxTempSchema.Text, textBoxTempDatasetName.Text, textBoxTempParameters.Text, textBoxTempDescription.Text, textBoxTempBy.Text, textBoxTempDate.Text, textBoxTempParameters.Text, textBoxTempNotes.Text, MainForm.tempQuery);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MainForm.finalText += textBoxTempOutput.Text;
                this.Close();
            }
        }
    }
}
