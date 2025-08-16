namespace Week5_4
{
    partial class Form2
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
            colorDialog1 = new ColorDialog();
            btnPickColor = new Button();
            SuspendLayout();
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(198, 152);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(146, 61);
            btnPickColor.TabIndex = 0;
            btnPickColor.Text = "Pick Color For Background";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 429);
            Controls.Add(btnPickColor);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnPickColor;
    }
}