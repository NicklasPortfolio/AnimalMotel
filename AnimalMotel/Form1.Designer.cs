namespace AnimalMotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSpecifications = new System.Windows.Forms.GroupBox();
            this.lblSpec1 = new System.Windows.Forms.Label();
            this.lblSpec2 = new System.Windows.Forms.Label();
            this.txtSpec1 = new System.Windows.Forms.TextBox();
            this.txtSpec2 = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAnimal = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.cbListAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbSpecifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbAnimals);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Registered Animals";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Specifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(6, 37);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(747, 186);
            this.lbAnimals.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbListAll);
            this.groupBox2.Controls.Add(this.btnLoadImg);
            this.groupBox2.Controls.Add(this.picAnimal);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbAnimal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbCategory);
            this.groupBox2.Controls.Add(this.gbSpecifications);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.groupBox2.Size = new System.Drawing.Size(758, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal Specifications";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbGender);
            this.groupBox3.Location = new System.Drawing.Point(10, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.Location = new System.Drawing.Point(6, 19);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(150, 69);
            this.lbGender.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(51, 54);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(45, 20);
            this.txtAge.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Age:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbSpecifications
            // 
            this.gbSpecifications.Controls.Add(this.txtSpec2);
            this.gbSpecifications.Controls.Add(this.txtSpec1);
            this.gbSpecifications.Controls.Add(this.lblSpec2);
            this.gbSpecifications.Controls.Add(this.lblSpec1);
            this.gbSpecifications.Location = new System.Drawing.Point(10, 187);
            this.gbSpecifications.Name = "gbSpecifications";
            this.gbSpecifications.Size = new System.Drawing.Size(162, 77);
            this.gbSpecifications.TabIndex = 5;
            this.gbSpecifications.TabStop = false;
            // 
            // lblSpec1
            // 
            this.lblSpec1.Location = new System.Drawing.Point(9, 18);
            this.lblSpec1.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpec1.Name = "lblSpec1";
            this.lblSpec1.Size = new System.Drawing.Size(103, 17);
            this.lblSpec1.TabIndex = 0;
            this.lblSpec1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpec2
            // 
            this.lblSpec2.Location = new System.Drawing.Point(6, 48);
            this.lblSpec2.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpec2.Name = "lblSpec2";
            this.lblSpec2.Size = new System.Drawing.Size(106, 13);
            this.lblSpec2.TabIndex = 1;
            this.lblSpec2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpec1
            // 
            this.txtSpec1.Location = new System.Drawing.Point(115, 17);
            this.txtSpec1.Name = "txtSpec1";
            this.txtSpec1.Size = new System.Drawing.Size(41, 20);
            this.txtSpec1.TabIndex = 2;
            // 
            // txtSpec2
            // 
            this.txtSpec2.Location = new System.Drawing.Point(115, 45);
            this.txtSpec2.Name = "txtSpec2";
            this.txtSpec2.Size = new System.Drawing.Size(41, 20);
            this.txtSpec2.TabIndex = 3;
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(188, 39);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(174, 225);
            this.lbCategory.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(248, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Category";
            // 
            // lbAnimal
            // 
            this.lbAnimal.FormattingEnabled = true;
            this.lbAnimal.Location = new System.Drawing.Point(378, 34);
            this.lbAnimal.Margin = new System.Windows.Forms.Padding(0);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(174, 186);
            this.lbAnimal.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(429, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Animal Object";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(380, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(565, 68);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(163, 140);
            this.picAnimal.TabIndex = 11;
            this.picAnimal.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadImg.Location = new System.Drawing.Point(565, 34);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(163, 28);
            this.btnLoadImg.TabIndex = 12;
            this.btnLoadImg.Text = "Load Photo";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            // 
            // cbListAll
            // 
            this.cbListAll.AutoSize = true;
            this.cbListAll.ForeColor = System.Drawing.Color.Blue;
            this.cbListAll.Location = new System.Drawing.Point(565, 223);
            this.cbListAll.Name = "cbListAll";
            this.cbListAll.Size = new System.Drawing.Size(94, 17);
            this.cbListAll.TabIndex = 13;
            this.cbListAll.Text = "List all Animals";
            this.cbListAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Animal Motel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbSpecifications.ResumeLayout(false);
            this.gbSpecifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.GroupBox gbSpecifications;
        private System.Windows.Forms.TextBox txtSpec2;
        private System.Windows.Forms.TextBox txtSpec1;
        private System.Windows.Forms.Label lblSpec2;
        private System.Windows.Forms.Label lblSpec1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ListBox lbAnimal;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbListAll;
        private System.Windows.Forms.Button btnLoadImg;
    }
}

