using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace DatasetConverter
{
    public partial class MainForm : Form
    {

        public static String folderPath = "";
        public static String defDatabase = "";
        public static String defSchema = "";
        public static String defDesc = "";
        public static String defBy = "";
        public static String defDate = "";
        public static String defNotes = "";
        public static String defTemplate = "\r\n\r\nUSE {0}\r\n\r\nGO\r\n\r\nCREATE PROCEDURE {1}.{2}\r\n\r\n{3}\r\n\r\nAS\r\n\r\n/***********************************************************************************************************\r\nDESCRIPTION: {4}\r\n\r\nBY: 	{5}\r\n\r\nCREATION DATE: {6}\r\n\r\nINPUT PARAMETERS:	{7}\r\n\r\nNOTES:  {8}\r\n\r\n\r\nREVISIONS:\r\nDate:		By:			Description of change:														Q.A.'d By:\r\n==========	=========	=========================================================================	============\r\n\r\n**************************************************************************************************************/\r\n\r\n\r\n{9}\r\n\r\n\r\nGO\r\n";
        public static String tempText = "";
        public static String tempQuery = "";
        public static String tempDatasetName = "";
        public static String tempParameters = "";
        public static String outputText = "";
        public static String finalText = "";
        public static int filesFound = 0;
        public static int filesProcessed = 1;
        public static bool cancelled = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            folderPath = fbd.SelectedPath;

            labelFolderPath.Text = folderPath;
        }

        private void buttonStartProc_Click(object sender, EventArgs e)
        {
            
            defDatabase = textBoxDefDatabase.Text;
            defSchema = textBoxDefSchema.Text;
            defDesc = textBoxDefDescription.Text;
            defBy = textBoxDefBy.Text;
            defDate = textBoxDefDate.Text;
            defNotes = textBoxDefNotes.Text;
            defTemplate = textBoxDefTemplate.Text;

            cancelled = false;

            if (folderPath == "")
            {
                MessageBox.Show("Folder path must be selected.");
            }
            else
            {
                DirectoryInfo d = new DirectoryInfo(folderPath);

                foreach (var file in d.GetFiles("*.rsd"))
                {
                    filesFound++;
                }

                var form = new ProcessingForm();

                foreach (var file in d.GetFiles("*.rsd"))
                {
                    tempQuery = "";
                    tempDatasetName = "";
                    tempParameters = "";

                    if (cancelled == true)
                    {
                        break;
                    }
                    else
                    {
                        
                        XmlDataDocument xmldoc = new XmlDataDocument();
                        XmlNodeList xmlnode;

                        int i = 0;
                        FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                        xmldoc.Load(fs);

                        tempDatasetName = file.Name.Replace(".rsd", "").Replace("Dataset", "").Replace("dataset", "");

                        xmlnode = xmldoc.GetElementsByTagName("CommandText");
                        for (i = 0; i <= xmlnode.Count - 1; i++)
                        {
                            tempQuery += xmlnode[i].ChildNodes.Item(0).InnerText;
                        }

                        tempQuery = tempQuery.Replace("&lt;", "<").Replace("&gt;", ">");

                        xmlnode = xmldoc.GetElementsByTagName("DataSetParameter");
                        for (i = 0; i <= xmlnode.Count - 1; i++)
                        {
                            tempParameters += xmlnode[i].Attributes["Name"].Value +" ";
                            tempParameters += xmlnode[i].ChildNodes.Item(3).InnerText + ", ";
                        }

                        tempParameters = tempParameters.TrimEnd(' ').TrimEnd(',');
                        
                        form.ShowDialog();
                        filesProcessed++;
                    }
                }

                //Show final text in new form
                var formResults = new Results();

                formResults.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxDefTemplate.Text = defTemplate;
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Batch Dataset Converter for .rsd files" + "\n" +
                              "Created by Isaac Owens - isaacowens@outlook.com" + "\n" +
                              "2015");
        }
    }
}
