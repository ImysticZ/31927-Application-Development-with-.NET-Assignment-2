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


namespace Assignment_2
{
    public partial class Text_Editor : Form
    {
        private String filename;
        public Text_Editor(String userName, String userType)
        {
            filename = "";
            InitializeComponent();
            toolStripLabel1.Text = "User Name: " + userName;
            if (userType == "View")
            {
                richTextBox1.ReadOnly = true;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                toolStripButton5.Enabled = false;
                toolStripButton6.Enabled = false;
                toolStripButton7.Enabled = false;
                toolStripButton8.Enabled = false;
                toolStripButton9.Enabled = false;
                toolStripButton10.Enabled = false;
                toolStripButton11.Enabled = false;
            }
            else
            {
                richTextBox1.ReadOnly = false;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Bold)
            {
                if (currentFont.Italic && currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic | FontStyle.Underline);
                else if (currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else if (currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Italic)
            {
                if (currentFont.Bold && currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Underline);
                else if (currentFont.Bold)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Underline)
            {
                if (currentFont.Bold && currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Italic);
                else if (currentFont.Bold)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
            }
        }

        private void toolStripButton8_Change(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0 && Single.TryParse(toolStripButton8.Text, out Single fontSize))
            {
                Font currentFont = richTextBox1.SelectionFont;
                if (currentFont != null)
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filename = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.RichText);

            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(filename.Equals("")))
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
                DialogResult dr = dialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.SaveFile(dialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SaveFile(dialog.FileName, RichTextBoxStreamType.RichText);


            }
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filename = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!(filename.Equals("")))
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
                DialogResult dr = dialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.SaveFile(dialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf| All Files(*.*) | *.*";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SaveFile(dialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Editor\nVersion 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
