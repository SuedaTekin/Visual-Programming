namespace Week5_4
{
    partial class Form9
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
            btnRun = new Button();
            txtSearchKeyword = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(33, 64);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(87, 48);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run Process";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Location = new Point(126, 78);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(100, 23);
            txtSearchKeyword.TabIndex = 1;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchKeyword);
            Controls.Add(btnRun);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtSearchKeyword;
    }
}