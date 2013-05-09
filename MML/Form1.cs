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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Raw;
        public string MType;
        public static string[] strArray = new string[3];
        public const string BaseURL = @"C:\Users\A.2\Documents\My Dropbox\Photos\meme\";
        public string URL;

        private int Validator()
        {
            int FirstDelimiterIndex;
            try
            {
                FirstDelimiterIndex = tbInput.Text.IndexOf("|");
            }
            catch ( IndexOutOfRangeException )
            {
                FirstDelimiterIndex = -1;
            }
            return FirstDelimiterIndex;
        }

        private void MParse(object sender, EventArgs e)
        {
            int FirstDelimiterIndex = Validator();
            if ( FirstDelimiterIndex != -1 )
            {
                MType = tbInput.Text.Substring(0, FirstDelimiterIndex);		// The Meme
                Raw = tbInput.Text.Substring(1 + FirstDelimiterIndex);		// The captions
                strArray = Raw.Split("|".ToCharArray());					// Text written to array.
                /* foreach ( string str in strArray ) */
                /* { */
                /*     if ( str.Length > 0 ) */
                /*         MessageBox.Show(str); */
                /* } */
                LoadInfo(MType);
                MakeImage();
            }
            else // validator failure
            {
                DialogResult EMB = MessageBox.Show("This will not work","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if ( EMB == DialogResult.Cancel )
                {
                    tbInput.Clear();
                }
            }
        }

        private void LoadInfo(string Meme)
        {
            switch ( Meme )
            {
                case "LD":
                    URL = BaseURL + "LD.jpg";
                    if ( strArray.Length < 2 )
                    {
                        Array.Resize(ref strArray, 2);
							// http://stackoverflow.com/questions/9570944/adding-elements-to-a-c-sharp-array?lq=1
                        strArray[1] = "I also like to live dangerously";
                        MessageBox.Show("String set");
                    }
                    return;
                case "ODNS":
                    URL = BaseURL + "ODNS.jpg";
                    if (strArray[0].Length ==0)
                        strArray[0] = "One does not simply";
                    return;
                default:
                    MessageBox.Show("Invalid Meme");
                    return;
            }
        }

        private void MakeImage()
        {
            Bitmap img = new Bitmap(URL);
            Graphics g = Graphics.FromImage(img);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(strArray[0], new Font("Consolas", 40), Brushes.LimeGreen, new Point(20, 10));
            try
            {
                g.DrawString(strArray[1], new Font("Consolas", 40), Brushes.Magenta, new Point(20, img.Size.Height - 100));
            }
            catch
            {
                MessageBox.Show("It fuck up");
            }
            g.Save();
            PB.Image = img;
        }

        #region EventHandlers
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            PB.Size = new Size(this.Size.Width-20, this.Size.Height-20);
        }

        private void btnCBPaste_Click(object sender, EventArgs e)	// Replace with right click menu
        {
            tbInput.Text = Clipboard.GetText();
        }

        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            if ( e.Button == System.Windows.Forms.MouseButtons.Right )
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.ShowDialog();
                string path = SFD.FileName.ToString();
                MessageBox.Show(path);
                PB.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        #endregion
    }
}
