namespace Week5_4
{
    partial class Form11
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
            radioCSharp = new RadioButton();
            radioJava = new RadioButton();
            radioRuby = new RadioButton();
            lblFPL = new Label();
            SuspendLayout();
            // 
            // radioCSharp
            // 
            radioCSharp.AutoSize = true;
            radioCSharp.Location = new Point(13, 12);
            radioCSharp.Name = "radioCSharp";
            radioCSharp.Size = new Size(40, 19);
            radioCSharp.TabIndex = 0;
            radioCSharp.Text = "C#";
            radioCSharp.UseVisualStyleBackColor = true;
            radioCSharp.CheckedChanged += radioPLS_CheckedChanged;
            // 
            // radioJava
            // 
            radioJava.AutoSize = true;
            radioJava.Location = new Point(59, 12);
            radioJava.Name = "radioJava";
            radioJava.Size = new Size(50, 19);
            radioJava.TabIndex = 0;
            radioJava.Text = "JAVA";
            radioJava.UseVisualStyleBackColor = true;
            radioJava.CheckedChanged += radioPLS_CheckedChanged;
            // 
            // radioRuby
            // 
            radioRuby.AutoSize = true;
            radioRuby.Location = new Point(115, 12);
            radioRuby.Name = "radioRuby";
            radioRuby.Size = new Size(98, 19);
            radioRuby.TabIndex = 0;
            radioRuby.Text = "Ruby On Rails";
            radioRuby.UseVisualStyleBackColor = true;
            radioRuby.CheckedChanged += radioPLS_CheckedChanged;
            // 
            // lblFPL
            // 
            lblFPL.AutoSize = true;
            lblFPL.Location = new Point(18, 45);
            lblFPL.Name = "lblFPL";
            lblFPL.Size = new Size(71, 15);
            lblFPL.TabIndex = 1;
            lblFPL.Text = "Favorite PL: ";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 104);
            Controls.Add(lblFPL);
            Controls.Add(radioRuby);
            Controls.Add(radioJava);
            Controls.Add(radioCSharp);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioCSharp;
        private RadioButton radioJava;
        private RadioButton radioRuby;
        private Label lblFPL;
    }
}