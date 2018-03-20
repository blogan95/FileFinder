using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileFinder
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PathButton_Click(object sender, EventArgs e)
        {


        }

        private void ExtInput_SelectChanged(object sender, EventArgs e)
        {

        }

        public bool SearchFiles(string fileName, string userString)
        {
            bool foundMatch = false;

            FileStream temp = new FileStream(fileName, FileMode.Open);
            StreamReader tempFile = new StreamReader(temp);

            while (!tempFile.EndOfStream)
            {
                string line = tempFile.ReadLine().ToLower();

                if (line.Contains(userString.ToLower()))
                {
                    foundMatch = true;
                    break;
                }
            }

            return foundMatch;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Items.Clear();
            string userExt = ExtInput.Text;
            string userPath = PathInput.Text;
            string userString = StringInput.Text;
            string[] files = Directory.GetFiles(userPath, "*" + userExt);


            foreach (var file in files)
            {
                bool results = SearchFiles(file.ToString(), userString);

                if (results)
                {
                    ResultsBox.Items.Add(file.ToString());
                    EnterLog("Located file "+file, DateTime.Now);
                }
            }

            if (ResultsBox.Items.Count == 0)
            {
                ResultsBox.Items.Add("No files found with '" + userString + "' in " + userPath);
                EnterLog("Nothing found with " + userString,DateTime.Now);
            }
        }

        static void EnterLog(string logLine, DateTime logTime)
        {
            string path = "Log.txt";
            FileStream newlf = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter logIt = new StreamWriter(newlf);
            logIt.WriteLine(logLine + " " + logTime);
            logIt.Close();
        }
        
    }

}
    


//---------
