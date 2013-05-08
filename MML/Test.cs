using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MML
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(@"C:\Users\A.2\Documents\My Dropbox\Photos\meme\LD.jpg");
            Graphics g = Graphics.FromImage(img);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString("Testing", new Font("Consolas", 40), Brushes.Maroon, new Point(20, 40));
            g.Save();
            pictureBox1.Image = img;
        }
    }
}
