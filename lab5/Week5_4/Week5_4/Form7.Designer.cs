namespace Week5_4
{
    partial class Form7
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
            numericUpDown1 = new NumericUpDown();
            lblDouble = new Label();
            btnIncrement = new Button();
            btnDecrement = new Button();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(29, 33);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(103, 40);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(56, 15);
            lblDouble.TabIndex = 1;
            lblDouble.Text = "Counter: ";
            // 
            // btnIncrement
            // 
            btnIncrement.Location = new Point(29, 73);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(29, 23);
            btnIncrement.TabIndex = 2;
            btnIncrement.Text = "+";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // btnDecrement
            // 
            btnDecrement.Location = new Point(63, 73);
            btnDecrement.Name = "btnDecrement";
            btnDecrement.Size = new Size(29, 23);
            btnDecrement.TabIndex = 2;
            btnDecrement.Text = "-";
            btnDecrement.UseVisualStyleBackColor = true;
            btnDecrement.Click += btnDecrement_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(29, 116);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(btnDecrement);
            Controls.Add(btnIncrement);
            Controls.Add(lblDouble);
            Controls.Add(numericUpDown1);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label lblDouble;
        private Button btnIncrement;
        private Button btnDecrement;
        private NumericUpDown numericUpDown2;
    }
}