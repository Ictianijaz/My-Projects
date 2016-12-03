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

namespace Notepad
{
    public partial class notepad : Form
    {
        private bool isFileAlreadySaved;
        private bool isFileDirty;
        private string currOpenFileName;
        public notepad()
        {
            InitializeComponent();
            this.Text = "Untitled - Notepad";
        
        }

        private void notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBox.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.txtBox.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.txtBox.Paste();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.txtBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBox.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBox.Clear();
            this.Text = "Untitled - Notepad";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Text files(*.txt)|*.txt|Rich Text From(*.rtf)|*.rtf";
            DialogResult result =  f.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(f.FileName) == ".txt")
                    txtBox.LoadFile(f.FileName, RichTextBoxStreamType.PlainText);
                else if (Path.GetExtension(f.FileName) == ".rtf")
                    txtBox.LoadFile(f.FileName, RichTextBoxStreamType.RichText);

                string[] name = Path.GetFileName(f.FileName).Split('.');
                this.Text = name[0] + " - Notepad";

                isFileAlreadySaved = true;
                isFileDirty = false;
                currOpenFileName = f.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileAlreadySaved)
            {
                if (Path.GetExtension(currOpenFileName) == ".txt")
                    txtBox.SaveFile(currOpenFileName, RichTextBoxStreamType.PlainText);
                else if (Path.GetExtension(currOpenFileName) == ".rtf")
                    txtBox.SaveFile(currOpenFileName, RichTextBoxStreamType.RichText);
                isFileDirty = false;
            }
            else
            {
                if (isFileDirty)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.Filter = "Text files(*.txt)|*.txt|Rich Text From(*.rtf)|*.rtf";
                    DialogResult result = s.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (Path.GetExtension(s.FileName) == ".txt")
                            txtBox.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
                        else if (Path.GetExtension(s.FileName) == ".rtf")
                            txtBox.SaveFile(s.FileName, RichTextBoxStreamType.RichText);

                        string[] name = Path.GetFileName(s.FileName).Split('.');
                        this.Text = name[0] + " - Notepad";

                        isFileAlreadySaved = true;
                        isFileDirty = false;
                        currOpenFileName = s.FileName;
                    }
                }
                else
                {
                    this.txtBox.Clear();
                    this.Text = "Untitled - Notepad";
                    isFileDirty = false;
                }
            }
        }

        private void notepad_Load(object sender, EventArgs e)
        {
            isFileAlreadySaved = false;
            isFileDirty = false;
            currOpenFileName = "";
    }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            isFileDirty = true;
        }

        private void aboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is VP Lab assignment and all rigth are reserved by Author", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
