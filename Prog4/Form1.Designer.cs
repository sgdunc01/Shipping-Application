namespace Prog4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.originZipTxt = new System.Windows.Forms.TextBox();
            this.destZipTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addPackageBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.sendToBtn = new System.Windows.Forms.Button();
            this.sendFromBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Zip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dest Zip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // originZipTxt
            // 
            this.originZipTxt.Location = new System.Drawing.Point(61, 2);
            this.originZipTxt.Name = "originZipTxt";
            this.originZipTxt.Size = new System.Drawing.Size(100, 20);
            this.originZipTxt.TabIndex = 6;
            // 
            // destZipTxt
            // 
            this.destZipTxt.Location = new System.Drawing.Point(61, 28);
            this.destZipTxt.Name = "destZipTxt";
            this.destZipTxt.Size = new System.Drawing.Size(100, 20);
            this.destZipTxt.TabIndex = 7;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(61, 54);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 20);
            this.lengthTxt.TabIndex = 8;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(61, 80);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 20);
            this.widthTxt.TabIndex = 9;
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(61, 106);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(100, 20);
            this.heightTxt.TabIndex = 10;
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(61, 132);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(100, 20);
            this.weightTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // addPackageBtn
            // 
            this.addPackageBtn.AutoSize = true;
            this.addPackageBtn.Location = new System.Drawing.Point(12, 169);
            this.addPackageBtn.Name = "addPackageBtn";
            this.addPackageBtn.Size = new System.Drawing.Size(149, 23);
            this.addPackageBtn.TabIndex = 13;
            this.addPackageBtn.Text = "Add Ground Package";
            this.addPackageBtn.UseVisualStyleBackColor = true;
            this.addPackageBtn.Click += new System.EventHandler(this.addPackageBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(359, 9);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(75, 39);
            this.detailsBtn.TabIndex = 14;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // sendToBtn
            // 
            this.sendToBtn.Location = new System.Drawing.Point(359, 61);
            this.sendToBtn.Name = "sendToBtn";
            this.sendToBtn.Size = new System.Drawing.Size(75, 39);
            this.sendToBtn.TabIndex = 15;
            this.sendToBtn.Text = " Send to UofL";
            this.sendToBtn.UseVisualStyleBackColor = true;
            this.sendToBtn.Click += new System.EventHandler(this.sendToBtn_Click);
            // 
            // sendFromBtn
            // 
            this.sendFromBtn.Location = new System.Drawing.Point(359, 113);
            this.sendFromBtn.Name = "sendFromBtn";
            this.sendFromBtn.Size = new System.Drawing.Size(75, 39);
            this.sendFromBtn.TabIndex = 16;
            this.sendFromBtn.Text = "Send from UofL";
            this.sendFromBtn.UseVisualStyleBackColor = true;
            this.sendFromBtn.Click += new System.EventHandler(this.sendFromBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Weight:";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(186, 9);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(167, 147);
            this.priceListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 201);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sendFromBtn);
            this.Controls.Add(this.sendToBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.addPackageBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.destZipTxt);
            this.Controls.Add(this.originZipTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox originZipTxt;
        private System.Windows.Forms.TextBox destZipTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addPackageBtn;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button sendToBtn;
        private System.Windows.Forms.Button sendFromBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox priceListBox;
    }
}

