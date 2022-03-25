namespace Part_5._5___Methods
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
            this.btnAsciiArt1 = new System.Windows.Forms.Button();
            this.lblAsciiOutput = new System.Windows.Forms.Label();
            this.btnAsciiArt2 = new System.Windows.Forms.Button();
            this.btnAsciiArt3 = new System.Windows.Forms.Button();
            this.btnKnockKnock = new System.Windows.Forms.Button();
            this.lblKnockKnockOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsciiArt1
            // 
            this.btnAsciiArt1.Location = new System.Drawing.Point(12, 12);
            this.btnAsciiArt1.Name = "btnAsciiArt1";
            this.btnAsciiArt1.Size = new System.Drawing.Size(75, 23);
            this.btnAsciiArt1.TabIndex = 0;
            this.btnAsciiArt1.Text = "Frog";
            this.btnAsciiArt1.UseVisualStyleBackColor = true;
            this.btnAsciiArt1.Click += new System.EventHandler(this.btnAsciiArt1_Click);
            // 
            // lblAsciiOutput
            // 
            this.lblAsciiOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsciiOutput.Location = new System.Drawing.Point(130, 12);
            this.lblAsciiOutput.Name = "lblAsciiOutput";
            this.lblAsciiOutput.Size = new System.Drawing.Size(168, 118);
            this.lblAsciiOutput.TabIndex = 1;
            this.lblAsciiOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsciiArt2
            // 
            this.btnAsciiArt2.Location = new System.Drawing.Point(12, 59);
            this.btnAsciiArt2.Name = "btnAsciiArt2";
            this.btnAsciiArt2.Size = new System.Drawing.Size(75, 23);
            this.btnAsciiArt2.TabIndex = 2;
            this.btnAsciiArt2.Text = "Shrug";
            this.btnAsciiArt2.UseVisualStyleBackColor = true;
            this.btnAsciiArt2.Click += new System.EventHandler(this.btnAsciiArt2_Click);
            // 
            // btnAsciiArt3
            // 
            this.btnAsciiArt3.Location = new System.Drawing.Point(12, 107);
            this.btnAsciiArt3.Name = "btnAsciiArt3";
            this.btnAsciiArt3.Size = new System.Drawing.Size(75, 23);
            this.btnAsciiArt3.TabIndex = 3;
            this.btnAsciiArt3.Text = "Robot";
            this.btnAsciiArt3.UseVisualStyleBackColor = true;
            this.btnAsciiArt3.Click += new System.EventHandler(this.btnAsciiArt3_Click);
            // 
            // btnKnockKnock
            // 
            this.btnKnockKnock.Location = new System.Drawing.Point(12, 198);
            this.btnKnockKnock.Name = "btnKnockKnock";
            this.btnKnockKnock.Size = new System.Drawing.Size(108, 23);
            this.btnKnockKnock.TabIndex = 4;
            this.btnKnockKnock.Text = "Knock Knock Joke";
            this.btnKnockKnock.UseVisualStyleBackColor = true;
            // 
            // lblKnockKnockOutput
            // 
            this.lblKnockKnockOutput.Location = new System.Drawing.Point(151, 158);
            this.lblKnockKnockOutput.Name = "lblKnockKnockOutput";
            this.lblKnockKnockOutput.Size = new System.Drawing.Size(147, 105);
            this.lblKnockKnockOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 272);
            this.Controls.Add(this.lblKnockKnockOutput);
            this.Controls.Add(this.btnKnockKnock);
            this.Controls.Add(this.btnAsciiArt3);
            this.Controls.Add(this.btnAsciiArt2);
            this.Controls.Add(this.lblAsciiOutput);
            this.Controls.Add(this.btnAsciiArt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsciiArt1;
        private System.Windows.Forms.Label lblAsciiOutput;
        private System.Windows.Forms.Button btnAsciiArt2;
        private System.Windows.Forms.Button btnAsciiArt3;
        private System.Windows.Forms.Button btnKnockKnock;
        private System.Windows.Forms.Label lblKnockKnockOutput;
    }
}

