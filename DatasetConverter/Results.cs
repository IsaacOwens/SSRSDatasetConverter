using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DatasetConverter
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            textBoxResults.Text = MainForm.finalText;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
                SaveFileDialog dialog = new SaveFileDialog();    

                dialog.Filter = "TXT files (*.txt)|*.txt|SQL files (*.sql)|*.sql";
                dialog.FilterIndex = 0;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(dialog.FileName.ToString());
                    file.WriteLine(MainForm.finalText);
                    file.Close();
                    MessageBox.Show("File saved successfully");
                }
                
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MainForm.finalText);
            MessageBox.Show("Text copied to Clipboard");
        }
    }
}
