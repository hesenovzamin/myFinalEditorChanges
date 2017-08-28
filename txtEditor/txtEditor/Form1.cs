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

namespace txtEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //open butonuna click olanda  OpenFileDialog Tipinde Bir Deyise Teyin Edirik
            OpenFileDialog Fayliac2 = new OpenFileDialog();
            if (Fayliac2.ShowDialog() == DialogResult.OK)
            {
                //eger deyisenimizin showdialog - u Dialogresult - un OK -sine beraberdise asagdaki emeliyatlari 
                richTextBox1.LoadFile(Fayliac2.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Fayliac2.FileName;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fayliSaxla = new SaveFileDialog();
            fayliSaxla.Title = "Save File as .....";

            if(fayliSaxla.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(fayliSaxla.FileName);
                txtoutput.Write(richTextBox1.Text);
                txtoutput.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
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

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontumuz = new FontDialog();
            fontumuz.Font = richTextBox1.SelectionFont;
            if (fontumuz.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontumuz.Font;
            }
        }

        private void bsckgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog rengimiz = new ColorDialog();
            rengimiz.Color = richTextBox1.SelectionColor;
            if(rengimiz.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = rengimiz.Color;
            }
        }

        private void aboutEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver 1.0.0/nCreated By Cav Eko");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
             
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver 1.0.0/nCreated By Cav Eko");
            
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog arxaFonRengim = new ColorDialog();

            if(arxaFonRengim.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = arxaFonRengim.Color;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("for Connect call this number 000000000");
        }
    }
}
