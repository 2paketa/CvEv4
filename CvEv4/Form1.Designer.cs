namespace CvEv4
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.patentBox = new System.Windows.Forms.CheckBox();
            this.markBox = new System.Windows.Forms.CheckBox();
            this.medBox = new System.Windows.Forms.CheckBox();
            this.finBox = new System.Windows.Forms.CheckBox();
            this.legalBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericDoc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericFields = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numericYearExp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 230);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enhance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 230);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 278);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.patentBox);
            this.tabPage1.Controls.Add(this.markBox);
            this.tabPage1.Controls.Add(this.medBox);
            this.tabPage1.Controls.Add(this.finBox);
            this.tabPage1.Controls.Add(this.legalBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fields";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // patentBox
            // 
            this.patentBox.AutoSize = true;
            this.patentBox.Location = new System.Drawing.Point(6, 101);
            this.patentBox.Name = "patentBox";
            this.patentBox.Size = new System.Drawing.Size(62, 17);
            this.patentBox.TabIndex = 4;
            this.patentBox.Text = "Patents";
            this.patentBox.UseVisualStyleBackColor = true;
            // 
            // markBox
            // 
            this.markBox.AutoSize = true;
            this.markBox.Location = new System.Drawing.Point(7, 78);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(73, 17);
            this.markBox.TabIndex = 3;
            this.markBox.Text = "Marketing";
            this.markBox.UseVisualStyleBackColor = true;
            // 
            // medBox
            // 
            this.medBox.AutoSize = true;
            this.medBox.Location = new System.Drawing.Point(7, 54);
            this.medBox.Name = "medBox";
            this.medBox.Size = new System.Drawing.Size(63, 17);
            this.medBox.TabIndex = 2;
            this.medBox.Text = "Medical";
            this.medBox.UseVisualStyleBackColor = true;
            // 
            // finBox
            // 
            this.finBox.AutoSize = true;
            this.finBox.Location = new System.Drawing.Point(7, 30);
            this.finBox.Name = "finBox";
            this.finBox.Size = new System.Drawing.Size(68, 17);
            this.finBox.TabIndex = 1;
            this.finBox.Text = "Financial";
            this.finBox.UseVisualStyleBackColor = true;
            // 
            // legalBox
            // 
            this.legalBox.AutoSize = true;
            this.legalBox.Location = new System.Drawing.Point(7, 7);
            this.legalBox.Name = "legalBox";
            this.legalBox.Size = new System.Drawing.Size(52, 17);
            this.legalBox.TabIndex = 0;
            this.legalBox.Text = "Legal";
            this.legalBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericDoc
            // 
            this.numericDoc.Location = new System.Drawing.Point(502, 50);
            this.numericDoc.Name = "numericDoc";
            this.numericDoc.Size = new System.Drawing.Size(98, 20);
            this.numericDoc.TabIndex = 13;
            this.numericDoc.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericDoc.ValueChanged += new System.EventHandler(this.numericDoc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of random documents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number of random fields";
            // 
            // numericFields
            // 
            this.numericFields.Location = new System.Drawing.Point(501, 88);
            this.numericFields.Name = "numericFields";
            this.numericFields.Size = new System.Drawing.Size(99, 20);
            this.numericFields.TabIndex = 16;
            this.numericFields.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericFields.ValueChanged += new System.EventHandler(this.numericFields_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numericYearExp
            // 
            this.numericYearExp.Location = new System.Drawing.Point(501, 127);
            this.numericYearExp.Name = "numericYearExp";
            this.numericYearExp.Size = new System.Drawing.Size(99, 20);
            this.numericYearExp.TabIndex = 18;
            this.numericYearExp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericYearExp.ValueChanged += new System.EventHandler(this.numericYearExp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Years of experience";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericYearExp);
            this.Controls.Add(this.numericFields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericDoc);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "CvEv4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox legalBox;
        private System.Windows.Forms.CheckBox finBox;
        private System.Windows.Forms.CheckBox markBox;
        private System.Windows.Forms.CheckBox medBox;
        private System.Windows.Forms.CheckBox patentBox;
        private System.Windows.Forms.NumericUpDown numericDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericFields;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown numericYearExp;
        private System.Windows.Forms.Label label3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

