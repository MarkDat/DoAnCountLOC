namespace CountLOC
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCS = new System.Windows.Forms.CheckBox();
            this.cbTXT = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.Label();
            this.lbBlanks = new System.Windows.Forms.Label();
            this.lbCommentLine = new System.Windows.Forms.Label();
            this.lbLOC = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFolderName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count LOC";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(85, 48);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(238, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path folder :";
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(329, 48);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(33, 23);
            this.btnFindFile.TabIndex = 3;
            this.btnFindFile.Text = "...";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(368, 48);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File types  :";
            // 
            // cbCS
            // 
            this.cbCS.AutoSize = true;
            this.cbCS.Checked = true;
            this.cbCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCS.Location = new System.Drawing.Point(85, 77);
            this.cbCS.Name = "cbCS";
            this.cbCS.Size = new System.Drawing.Size(44, 17);
            this.cbCS.TabIndex = 7;
            this.cbCS.Text = "*.cs";
            this.cbCS.UseVisualStyleBackColor = true;
            // 
            // cbTXT
            // 
            this.cbTXT.AutoSize = true;
            this.cbTXT.Location = new System.Drawing.Point(220, 77);
            this.cbTXT.Name = "cbTXT";
            this.cbTXT.Size = new System.Drawing.Size(44, 17);
            this.cbTXT.TabIndex = 8;
            this.cbTXT.Text = "*.txt";
            this.cbTXT.UseVisualStyleBackColor = true;
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(148, 77);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(53, 17);
            this.cbJava.TabIndex = 9;
            this.cbJava.Text = "*.java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Files:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lines: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLOC);
            this.groupBox1.Controls.Add(this.lbCommentLine);
            this.groupBox1.Controls.Add(this.lbBlanks);
            this.groupBox1.Controls.Add(this.lbLines);
            this.groupBox1.Controls.Add(this.lbFiles);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blanks:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(197, 25);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(78, 13);
            this.x.TabIndex = 13;
            this.x.Text = "Comment lines:";
            this.x.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "LOC, Line Of Code:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFiles
            // 
            this.lbFiles.AutoSize = true;
            this.lbFiles.Location = new System.Drawing.Point(98, 25);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(13, 13);
            this.lbFiles.TabIndex = 15;
            this.lbFiles.Text = "0";
            // 
            // lbLines
            // 
            this.lbLines.AutoSize = true;
            this.lbLines.Location = new System.Drawing.Point(98, 50);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(13, 13);
            this.lbLines.TabIndex = 16;
            this.lbLines.Text = "0";
            // 
            // lbBlanks
            // 
            this.lbBlanks.AutoSize = true;
            this.lbBlanks.Location = new System.Drawing.Point(98, 74);
            this.lbBlanks.Name = "lbBlanks";
            this.lbBlanks.Size = new System.Drawing.Size(13, 13);
            this.lbBlanks.TabIndex = 17;
            this.lbBlanks.Text = "0";
            // 
            // lbCommentLine
            // 
            this.lbCommentLine.AutoSize = true;
            this.lbCommentLine.Location = new System.Drawing.Point(326, 25);
            this.lbCommentLine.Name = "lbCommentLine";
            this.lbCommentLine.Size = new System.Drawing.Size(13, 13);
            this.lbCommentLine.TabIndex = 18;
            this.lbCommentLine.Text = "0";
            // 
            // lbLOC
            // 
            this.lbLOC.AutoSize = true;
            this.lbLOC.Location = new System.Drawing.Point(326, 50);
            this.lbLOC.Name = "lbLOC";
            this.lbLOC.Size = new System.Drawing.Size(13, 13);
            this.lbLOC.TabIndex = 19;
            this.lbLOC.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Folder name :";
            // 
            // lbFolderName
            // 
            this.lbFolderName.AutoSize = true;
            this.lbFolderName.Location = new System.Drawing.Point(82, 113);
            this.lbFolderName.Name = "lbFolderName";
            this.lbFolderName.Size = new System.Drawing.Size(13, 13);
            this.lbFolderName.TabIndex = 14;
            this.lbFolderName.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 241);
            this.Controls.Add(this.lbFolderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.cbTXT);
            this.Controls.Add(this.cbCS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CountLoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCS;
        private System.Windows.Forms.CheckBox cbTXT;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLOC;
        private System.Windows.Forms.Label lbCommentLine;
        private System.Windows.Forms.Label lbBlanks;
        private System.Windows.Forms.Label lbLines;
        private System.Windows.Forms.Label lbFiles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFolderName;
    }
}

