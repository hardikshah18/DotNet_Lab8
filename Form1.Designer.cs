namespace Week11_Lab
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
            btnGenerate = new Button();
            txtBoxGenerate = new TextBox();
            lstBoxFibonacci = new ListBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(413, 75);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtBoxGenerate
            // 
            txtBoxGenerate.Location = new Point(213, 77);
            txtBoxGenerate.Name = "txtBoxGenerate";
            txtBoxGenerate.Size = new Size(163, 27);
            txtBoxGenerate.TabIndex = 1;
            txtBoxGenerate.TextChanged += txtBoxFind_TextChanged;
            // 
            // lstBoxFibonacci
            // 
            lstBoxFibonacci.FormattingEnabled = true;
            lstBoxFibonacci.Location = new Point(213, 153);
            lstBoxFibonacci.Name = "lstBoxFibonacci";
            lstBoxFibonacci.ScrollAlwaysVisible = true;
            lstBoxFibonacci.Size = new Size(274, 304);
            lstBoxFibonacci.TabIndex = 3;
            lstBoxFibonacci.SelectedIndexChanged += lstBoxFibonacci_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 605);
            Controls.Add(lstBoxFibonacci);
            Controls.Add(txtBoxGenerate);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Multi Threading Fibonacci";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtBoxGenerate;
        private ListBox lstBoxFibonacci;
    }
}
