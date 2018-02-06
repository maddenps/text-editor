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

namespace Text_Editor {
    public partial class Form1 : Form {

        // Global Variables here
        bool fileBool = false;
        string fileSaveName = "Untitled";
        bool wordWrapBool = true;


        public Form1() {
            InitializeComponent();
            wordWrapToolStripMenuItem.Checked = true;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            this.Text = "Untitled - Text Editor";
            fileSaveName = "Untitled";
            fileBool = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            this.CheckKeyword("while", Color.Purple, 0);
            this.CheckKeyword("if", Color.Green, 0);
            this.CheckKeyword("private", Color.Blue, 0);
            this.CheckKeyword("public", Color.Blue, 0);
            this.CheckKeyword("int", Color.Blue, 0);
            this.CheckKeyword("string", Color.Blue, 0);
            this.CheckKeyword("bool", Color.Blue, 0);
            this.CheckKeyword("true", Color.Blue, 0);
            this.CheckKeyword("this", Color.BlueViolet, 0);
            this.CheckKeyword("char", Color.Blue, 0);
            this.CheckKeyword("false", Color.Green, 0);
            this.CheckKeyword("new", Color.Green, 0);
            this.CheckKeyword("object", Color.Green, 0);
            this.CheckKeyword("float", Color.Green, 0);
            // else, try, catch, where, Select, 
                    
        }

        // TODO
        private void CheckKeyword(string word, Color color, int startIndex) {
            if (this.richTextBox1.Text.Contains(word)) {
                int index = -1;
                int selectStart = this.richTextBox1.SelectionStart;

                while ((index = this.richTextBox1.Text.IndexOf(word, (index + 1))) != -1) {
                    this.richTextBox1.Select((index + startIndex), word.Length);
                    this.richTextBox1.SelectionColor = color;
                    this.richTextBox1.Select(selectStart, 0);
                    this.richTextBox1.SelectionColor = Color.Black;
                }
            }
        }
     
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file...";
            if(ofd.ShowDialog() == DialogResult.OK) {
                StreamReader read = new StreamReader(ofd.FileName);
                richTextBox1.Text = read.ReadToEnd();
                read.Close();
                this.Text = ofd.SafeFileName + " - Text Editor";
                fileSaveName = ofd.SafeFileName;
                fileBool = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fileBool == true) {
                StreamWriter sWrite = new StreamWriter(fileSaveName);
                sWrite.Write(richTextBox1.Text);
                sWrite.Close();
                this.Text = fileSaveName + " - Text Editor";
            }
            else {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (.txt)|*.txt";
                sfd.Title = "Save file...";
                if (sfd.ShowDialog() == DialogResult.OK) {
                    StreamWriter sWrite = new StreamWriter(sfd.FileName);
                    sWrite.Write(richTextBox1.Text);
                    sWrite.Close();
                    this.Text = Path.GetFileNameWithoutExtension(sfd.FileName) + " - Text Editor";
                    fileSaveName = Path.GetFileNameWithoutExtension(sfd.FileName);
                    fileBool = true;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt";
            sfd.Title = "Save file...";
            if (sfd.ShowDialog() == DialogResult.OK) {
                StreamWriter sWrite = new StreamWriter(sfd.FileName);
                sWrite.Write(richTextBox1.Text);
                sWrite.Close();              
                this.Text = Path.GetFileNameWithoutExtension(sfd.FileName) + " - Text Editor";
                fileSaveName = Path.GetFileNameWithoutExtension(sfd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.SelectAll();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e) {
            if(wordWrapBool == true) {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
                wordWrapBool = false;
            }
            else {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
                wordWrapBool = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {

            DialogResult result = font4App.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK) {
                // Get Font.
                Font font = font4App.Font;
                // Set TextBox properties.
                this.richTextBox1.Text = string.Format("Font: {0}", font.Name);
                this.richTextBox1.Font = font;
            }
        }


        // Tab control stuff
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e) {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e) {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++) {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location)) {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        
    }
}
