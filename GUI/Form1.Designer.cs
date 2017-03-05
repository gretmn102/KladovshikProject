namespace GUI
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbNameGood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBag = new System.Windows.Forms.RadioButton();
            this.rbBox = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBarcode = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numW = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.rbDef = new System.Windows.Forms.RadioButton();
            this.rbUndefined = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbNameGood
            // 
            this.txbNameGood.Location = new System.Drawing.Point(262, 84);
            this.txbNameGood.Name = "txbNameGood";
            this.txbNameGood.Size = new System.Drawing.Size(121, 20);
            this.txbNameGood.TabIndex = 1;
            this.txbNameGood.Validating += new System.ComponentModel.CancelEventHandler(this.txbNameGood_Validating);
            this.txbNameGood.Validated += new System.EventHandler(this.txbNameGood_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name good";
            // 
            // rbBag
            // 
            this.rbBag.AutoSize = true;
            this.rbBag.Location = new System.Drawing.Point(282, 136);
            this.rbBag.Name = "rbBag";
            this.rbBag.Size = new System.Drawing.Size(44, 17);
            this.rbBag.TabIndex = 3;
            this.rbBag.TabStop = true;
            this.rbBag.Text = "Bag";
            this.rbBag.UseVisualStyleBackColor = true;
            // 
            // rbBox
            // 
            this.rbBox.AutoSize = true;
            this.rbBox.Checked = true;
            this.rbBox.Location = new System.Drawing.Point(233, 136);
            this.rbBox.Name = "rbBox";
            this.rbBox.Size = new System.Drawing.Size(43, 17);
            this.rbBox.TabIndex = 4;
            this.rbBox.TabStop = true;
            this.rbBox.Text = "Box";
            this.rbBox.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(332, 136);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 5;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bar-code";
            // 
            // txbBarcode
            // 
            this.txbBarcode.Location = new System.Drawing.Point(262, 110);
            this.txbBarcode.Name = "txbBarcode";
            this.txbBarcode.Size = new System.Drawing.Size(121, 20);
            this.txbBarcode.TabIndex = 6;
            this.txbBarcode.TextChanged += new System.EventHandler(this.txbBarcode_TextChanged);
            this.txbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbBarcode_KeyDown);
            this.txbBarcode.Validated += new System.EventHandler(this.txbBarcode_Validated);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 95);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rbDef);
            this.groupBox1.Controls.Add(this.rbUndefined);
            this.groupBox1.Location = new System.Drawing.Point(209, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numW);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numH);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 42);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "length";
            // 
            // numW
            // 
            this.numW.Location = new System.Drawing.Point(3, 18);
            this.numW.Name = "numW";
            this.numW.Size = new System.Drawing.Size(57, 20);
            this.numW.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "heigth";
            // 
            // numL
            // 
            this.numL.Location = new System.Drawing.Point(66, 18);
            this.numL.Name = "numL";
            this.numL.Size = new System.Drawing.Size(45, 20);
            this.numL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "width";
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(116, 18);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(53, 20);
            this.numH.TabIndex = 4;
            // 
            // rbDef
            // 
            this.rbDef.AutoSize = true;
            this.rbDef.Location = new System.Drawing.Point(6, 38);
            this.rbDef.Name = "rbDef";
            this.rbDef.Size = new System.Drawing.Size(42, 17);
            this.rbDef.TabIndex = 1;
            this.rbDef.Text = "Def";
            this.rbDef.UseVisualStyleBackColor = true;
            this.rbDef.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rbDef.Validating += new System.ComponentModel.CancelEventHandler(this.rbDef_Validating);
            // 
            // rbUndefined
            // 
            this.rbUndefined.AutoSize = true;
            this.rbUndefined.Checked = true;
            this.rbUndefined.Location = new System.Drawing.Point(6, 19);
            this.rbUndefined.Name = "rbUndefined";
            this.rbUndefined.Size = new System.Drawing.Size(74, 17);
            this.rbUndefined.TabIndex = 0;
            this.rbUndefined.TabStop = true;
            this.rbUndefined.Text = "Undefined";
            this.rbUndefined.UseVisualStyleBackColor = true;
            this.rbUndefined.CheckedChanged += new System.EventHandler(this.rbUndefined_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbBarcode);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbBox);
            this.Controls.Add(this.rbBag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNameGood);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbNameGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBag;
        private System.Windows.Forms.RadioButton rbBox;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBarcode;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUndefined;
        private System.Windows.Forms.RadioButton rbDef;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.NumericUpDown numL;
        private System.Windows.Forms.NumericUpDown numW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}

