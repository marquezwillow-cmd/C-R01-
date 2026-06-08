namespace MarquezP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            txtOrderNumber = new TextBox();
            label2 = new Label();
            grpItemType = new GroupBox();
            radUsb = new RadioButton();
            radMug = new RadioButton();
            radPen = new RadioButton();
            label3 = new Label();
            txtText = new TextBox();
            chkLogo = new CheckBox();
            lblColors = new Label();
            txtColors = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            txtResults = new TextBox();
            grpItemType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Order Number: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(147, 40);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(112, 23);
            txtOrderNumber.TabIndex = 2;
            txtOrderNumber.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of Items: ";
            // 
            // grpItemType
            // 
            grpItemType.Controls.Add(radUsb);
            grpItemType.Controls.Add(radMug);
            grpItemType.Controls.Add(radPen);
            grpItemType.Location = new Point(312, 24);
            grpItemType.Name = "grpItemType";
            grpItemType.Size = new Size(178, 115);
            grpItemType.TabIndex = 4;
            grpItemType.TabStop = false;
            grpItemType.Text = "Item Type: ";
            // 
            // radUsb
            // 
            radUsb.AutoSize = true;
            radUsb.Location = new Point(10, 75);
            radUsb.Name = "radUsb";
            radUsb.Size = new Size(76, 19);
            radUsb.TabIndex = 2;
            radUsb.TabStop = true;
            radUsb.Text = "USB Drive";
            radUsb.UseVisualStyleBackColor = true;
            // 
            // radMug
            // 
            radMug.AutoSize = true;
            radMug.Location = new Point(10, 50);
            radMug.Name = "radMug";
            radMug.Size = new Size(50, 19);
            radMug.TabIndex = 1;
            radMug.TabStop = true;
            radMug.Text = "Mug";
            radMug.UseVisualStyleBackColor = true;
            // 
            // radPen
            // 
            radPen.AutoSize = true;
            radPen.Location = new Point(10, 25);
            radPen.Name = "radPen";
            radPen.Size = new Size(45, 19);
            radPen.TabIndex = 0;
            radPen.TabStop = true;
            radPen.Text = "Pen";
            radPen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 40);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Text to Print: ";
            // 
            // txtText
            // 
            txtText.Location = new Point(526, 71);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(203, 68);
            txtText.TabIndex = 6;
            // 
            // chkLogo
            // 
            chkLogo.AutoSize = true;
            chkLogo.Location = new Point(758, 88);
            chkLogo.Name = "chkLogo";
            chkLogo.Size = new Size(81, 19);
            chkLogo.TabIndex = 7;
            chkLogo.Text = "Add Logo ";
            chkLogo.UseVisualStyleBackColor = true;
            // 
            // lblColors
            // 
            lblColors.AutoSize = true;
            lblColors.Location = new Point(38, 175);
            lblColors.Name = "lblColors";
            lblColors.Size = new Size(108, 15);
            lblColors.TabIndex = 8;
            lblColors.Text = "Number of Colors: ";
            lblColors.Visible = false;
            // 
            // txtColors
            // 
            txtColors.Location = new Point(38, 193);
            txtColors.Name = "txtColors";
            txtColors.Size = new Size(168, 23);
            txtColors.TabIndex = 9;
            txtColors.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(38, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(262, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(577, 269);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(262, 23);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(0, 298);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(883, 196);
            txtResults.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 491);
            Controls.Add(txtResults);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(txtColors);
            Controls.Add(lblColors);
            Controls.Add(chkLogo);
            Controls.Add(txtText);
            Controls.Add(label3);
            Controls.Add(grpItemType);
            Controls.Add(label2);
            Controls.Add(txtOrderNumber);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpItemType.ResumeLayout(false);
            grpItemType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtOrderNumber;
        private Label label2;
        private GroupBox grpItemType;
        private RadioButton radUsb;
        private RadioButton radMug;
        private RadioButton radPen;
        private Label label3;
        private TextBox txtText;
        private CheckBox chkLogo;
        private Label lblColors;
        private TextBox txtColors;
        private Button btnClear;
        private Button btnSubmit;
        private TextBox txtResults;
    }
}
