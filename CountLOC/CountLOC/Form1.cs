using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountLOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        int numFiles = 0;
        string[] filePahts;
        string[] lines = null;
        string fileName;
        string filtersFileType;
      // string rootFile= "E:\\WorkSpace\\Test\\NGUYEN_HAI_DUONG_FINAL_EXAM_CMU-CS303_2020S";
      string rootFile = "E:\\Test\\CountTheLinesCode";
   
        public void findFile()
        { 
            //filePahts = Directory.GetFiles(rootFile, "*.cs", SearchOption.AllDirectories);
            //numFiles = filePahts.Length;

            //filtersFileType = "*.cs|*.txt|*.java";
            var filteredFiles = filtersFileType.Split('|').SelectMany(filter => Directory.GetFiles(rootFile, filter, SearchOption.AllDirectories)).ToList();
            filePahts = filteredFiles.ToArray();
            //foreach (string item in filePahts)
            //{
            //    Console.WriteLine(item);
            //}

        }

        int commentLine = 0;
        bool checkCML = false;
        int numLines = 0;
        int numBlanks = 0;
        int numLOC = 0;
        public void readFiles()
        {
            foreach (string item in filePahts)
            {
                fileName = item;
                lines = File.ReadAllLines(fileName);
                process();
            }
                    
            
            numLOC = numLines - numBlanks - commentLine;
            Console.WriteLine("Files: " + filePahts.Length);
            Console.WriteLine("Lines: " + numLines);
            Console.WriteLine("Blanks: " + numBlanks);
            Console.WriteLine("Comments: " + commentLine);
            Console.WriteLine("Line Of Code: " + numLOC);
            lbFiles.Text = filePahts.Length.ToString();
            lbLines.Text = numLines.ToString();
            lbBlanks.Text = numBlanks.ToString();
            lbCommentLine.Text = commentLine.ToString();
            lbLOC.Text = numLOC.ToString();

            commentLine = 0;
            checkCML = false;
            numLines = 0;
            numBlanks = 0;
            numLOC = 0;
        }
        public void process()
        {
                numLines += getLOC(lines);
                numBlanks += numEmpty(lines);

                foreach (string s in lines)
                {
                    if (isEmpty(s) || s.IndexOf("\"//\"") != -1 || s.IndexOf("\"/*\"") != -1|| s.IndexOf("\"*/\"") != -1) continue;
                    if (s.IndexOf("/*") != -1) checkCML = true;
                    if (s.IndexOf("*/") != -1) checkCML = false;
                    
                    if (s.IndexOf("/*") != -1 && s.IndexOf("*/") != -1) ++commentLine;

                    if (s.IndexOf("//") != -1 || checkCML) ++commentLine;
                }        
        }
        public  int getLOC(string[] s)
        {
            return s.Length;
        }
        public int numEmpty(string[] lines)
        {
            string[] filteredbirds = Array.FindAll(lines, x => x.Trim().Equals(""));
            return filteredbirds.Length;
        }

        public bool isEmpty(string s)
        {
            return s.Trim() == "";
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                rootFile = folderDlg.SelectedPath;
                txtPath.Text = rootFile;
                lbFolderName.Text = Path.GetFileName(rootFile);
            }
        }
        List<string> lFileTypes = new List<string>();
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (cbCS.Checked) lFileTypes.Add("*.cs");
            if (cbJava.Checked) lFileTypes.Add("*.java");
            if (cbTXT.Checked) lFileTypes.Add("*.txt");

            foreach(string ss in lFileTypes)
            {
                filtersFileType += ss + "|";
            }


            findFile();
            readFiles();

            lFileTypes.Clear();
            filtersFileType = "";
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
     
        }
    }
}
