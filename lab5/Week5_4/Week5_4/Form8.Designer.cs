namespace Week5_4
{
    partial class Form8
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
            components = new System.ComponentModel.Container();
            lblCounter = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStartTimer = new Button();
            btnStopTimer = new Button();
            numericUpDown1 = new NumericUpDown();
            btnCatchme = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(84, 60);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(59, 15);
            lblCounter.TabIndex = 0;
            lblCounter.Text = "Counter : ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnStartTimer
            // 
            btnStartTimer.Location = new Point(26, 12);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(75, 23);
            btnStartTimer.TabIndex = 1;
            btnStartTimer.Text = "Start Timer";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // btnStopTimer
            // 
            btnStopTimer.Location = new Point(107, 12);
            btnStopTimer.Name = "btnStopTimer";
            btnStopTimer.Size = new Size(75, 23);
            btnStopTimer.TabIndex = 2;
            btnStopTimer.Text = "Stop Timer";
            btnStopTimer.UseVisualStyleBackColor = true;
            btnStopTimer.Click += btnStopTimer_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Location = new Point(26, 96);
            numericUpDown1.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnCatchme
            // 
            btnCatchme.Location = new Point(185, 106);
            btnCatchme.Name = "btnCatchme";
            btnCatchme.Size = new Size(133, 67);
            btnCatchme.TabIndex = 4;
            btnCatchme.Text = "Catch Me!";
            btnCatchme.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 507);
            Controls.Add(btnCatchme);
            Controls.Add(numericUpDown1);
            Controls.Add(btnStopTimer);
            Controls.Add(btnStartTimer);
            Controls.Add(lblCounter);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCounter;
        private System.Windows.Forms.Timer timer1;
        private Button btnStartTimer;
        private Button btnStopTimer;
        private NumericUpDown numericUpDown1;
        private Button btnCatchme;
        private System.Windows.Forms.Timer timer2;
    }
}