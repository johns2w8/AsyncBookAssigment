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
            ListBox lstReport1;
            label1 = new Label();
            txtFile1 = new TextBox();
            btnBrowse = new Button();
            btnExit = new Button();
            btnSubmit = new Button();
            openFileDialog1 = new OpenFileDialog();
            lstReport1 = new ListBox();
            SuspendLayout();
            // 
            // lstReport1
            // 
            lstReport1.FormattingEnabled = true;
            lstReport1.Location = new Point(87, 153);
            lstReport1.Name = "lstReport1";
            lstReport1.Size = new Size(290, 214);
            lstReport1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 98);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "File 1";
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(136, 95);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(145, 23);
            txtFile1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(302, 95);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(136, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(240, 402);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(btnBrowse);
            Controls.Add(lstReport1);
            Controls.Add(txtFile1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFile1;
        private ListBox lstReport1;
        private Button btnBrowse;
        private Button btnExit;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog1;
    }
}
