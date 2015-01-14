namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetLine = new System.Windows.Forms.Button();
            this.btnSetCircle = new System.Windows.Forms.Button();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 432);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSetLine
            // 
            this.btnSetLine.Location = new System.Drawing.Point(12, 450);
            this.btnSetLine.Name = "btnSetLine";
            this.btnSetLine.Size = new System.Drawing.Size(75, 23);
            this.btnSetLine.TabIndex = 2;
            this.btnSetLine.Text = "Lijn";
            this.btnSetLine.UseVisualStyleBackColor = true;
            this.btnSetLine.Click += new System.EventHandler(this.btnSetLine_Click);
            // 
            // btnSetCircle
            // 
            this.btnSetCircle.Location = new System.Drawing.Point(93, 450);
            this.btnSetCircle.Name = "btnSetCircle";
            this.btnSetCircle.Size = new System.Drawing.Size(75, 23);
            this.btnSetCircle.TabIndex = 3;
            this.btnSetCircle.Text = "Cirkel";
            this.btnSetCircle.UseVisualStyleBackColor = true;
            this.btnSetCircle.Click += new System.EventHandler(this.btnSetCircle_Click);
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.Location = new System.Drawing.Point(174, 450);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnDrawRectangle.TabIndex = 4;
            this.btnDrawRectangle.Text = "Rechthoek";
            this.btnDrawRectangle.UseVisualStyleBackColor = true;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "button1";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrawRectangle);
            this.Controls.Add(this.btnSetCircle);
            this.Controls.Add(this.btnSetLine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSetLine;
        private System.Windows.Forms.Button btnSetCircle;
        private System.Windows.Forms.Button btnDrawRectangle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;

    }
}

