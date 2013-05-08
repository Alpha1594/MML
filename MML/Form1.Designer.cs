namespace MML
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
            if ( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCBPaste = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.PictureBox();
            ( (System.ComponentModel.ISupportInitialize) ( this.PB ) ).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btnCBPaste
            // 
            this.btnCBPaste.Location = new System.Drawing.Point(118, 12);
            this.btnCBPaste.Name = "btnCBPaste";
            this.btnCBPaste.Size = new System.Drawing.Size(75, 23);
            this.btnCBPaste.TabIndex = 1;
            this.btnCBPaste.Text = "CB Paste";
            this.btnCBPaste.UseVisualStyleBackColor = true;
            this.btnCBPaste.Click += new System.EventHandler(this.btnCBPaste_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(197, 12);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.MParse);
            // 
            // PB
            // 
            this.PB.Image = ( (System.Drawing.Image) ( resources.GetObject("PB.Image") ) );
            this.PB.InitialImage = null;
            this.PB.Location = new System.Drawing.Point(12, 41);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(260, 209);
            this.PB.TabIndex = 3;
            this.PB.TabStop = false;
            this.PB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnCBPaste);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ( (System.ComponentModel.ISupportInitialize) ( this.PB ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCBPaste;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.PictureBox PB;
    }
}

