namespace Week5_4
{
    partial class Form3
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
            fontDialog1 = new FontDialog();
            btnChangeFont = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnChangeFont
            // 
            btnChangeFont.Location = new Point(47, 51);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(75, 23);
            btnChangeFont.TabIndex = 0;
            btnChangeFont.Text = "Change Font";
            btnChangeFont.UseVisualStyleBackColor = true;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(45, 92);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(134, 15);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message For FontDialog";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 192);
            Controls.Add(lblMessage);
            Controls.Add(btnChangeFont);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Button btnChangeFont;
        private Label lblMessage;
    }
}