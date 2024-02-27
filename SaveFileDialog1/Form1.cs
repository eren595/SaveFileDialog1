using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SaveFileDialog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*|Word|*.dock";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*|Word|*.dock";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                Belge.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtEditor.Text, txtEditor.Font,
             Brushes.Black, new Point(100, 100));
        }
    }
}
