namespace Color_Dialoge
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
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.myColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.AutoSize = true;
            this.btnSelectColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectColor.ForeColor = System.Drawing.Color.White;
            this.btnSelectColor.Location = new System.Drawing.Point(393, 23);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(253, 68);
            this.btnSelectColor.TabIndex = 0;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.UseVisualStyleBackColor = false;
            this.btnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(393, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(393, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(393, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Red:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(393, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alpha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(391, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Blue:";
            // 
            // picColor
            // 
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(12, 23);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(359, 397);
            this.picColor.TabIndex = 11;
            this.picColor.TabStop = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(549, 383);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(36, 37);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "0";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(551, 188);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(36, 37);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "0";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(551, 253);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(36, 37);
            this.lblR.TabIndex = 14;
            this.lblR.Text = "0";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(551, 318);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(36, 37);
            this.lblG.TabIndex = 13;
            this.lblG.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(551, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 37);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 449);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Colors";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColorDialog myColor;
    }
}

