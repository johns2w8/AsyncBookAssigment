namespace AsyncBookLab
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
            txtFile1 = new TextBox();
            btnBrowse = new Button();
            btnExit = new Button();
            btnSubmit = new Button();
            openFileDialog1 = new OpenFileDialog();
            lstReport = new ListBox();
            lstReport2 = new ListBox();
            btnBrowse2 = new Button();
            txtFile2 = new TextBox();
            label2 = new Label();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Book 1";
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(98, 38);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(145, 23);
            txtFile1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(263, 38);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(276, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(411, 368);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(33, 84);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(318, 229);
            lstReport.TabIndex = 6;
            // 
            // lstReport2
            // 
            lstReport2.FormattingEnabled = true;
            lstReport2.Location = new Point(411, 84);
            lstReport2.Name = "lstReport2";
            lstReport2.Size = new Size(318, 229);
            lstReport2.TabIndex = 7;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(638, 38);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(75, 23);
            btnBrowse2.TabIndex = 10;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(473, 38);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(145, 23);
            txtFile2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 41);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Book 2";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse2);
            Controls.Add(txtFile2);
            Controls.Add(label2);
            Controls.Add(lstReport2);
            Controls.Add(lstReport);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(btnBrowse);
            Controls.Add(txtFile1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Wes Johnson's Book Word Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFile1;
        private Button btnBrowse;
        private Button btnExit;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog1;
        private ListBox lstReport;
        private ListBox lstReport2;
        private Button btnBrowse2;
        private TextBox txtFile2;
        private Label label2;
        private OpenFileDialog openFileDialog2;
    }
}
