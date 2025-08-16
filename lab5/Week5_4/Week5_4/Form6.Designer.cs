namespace Week5_4
{
    partial class Form6
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
            tabControl1 = new TabControl();
            tabLogin = new TabPage();
            lblLoginWarning = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tabSignup = new TabPage();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            btnCreateNewTab = new Button();
            tabControl1.SuspendLayout();
            tabLogin.SuspendLayout();
            tabSignup.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLogin);
            tabControl1.Controls.Add(tabSignup);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(lblLoginWarning);
            tabLogin.Controls.Add(textBox2);
            tabLogin.Controls.Add(label2);
            tabLogin.Controls.Add(textBox1);
            tabLogin.Controls.Add(label1);
            tabLogin.Controls.Add(button1);
            tabLogin.Location = new Point(4, 24);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(792, 422);
            tabLogin.TabIndex = 0;
            tabLogin.Text = "Log In!";
            tabLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginWarning
            // 
            lblLoginWarning.AutoSize = true;
            lblLoginWarning.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblLoginWarning.ForeColor = SystemColors.ActiveCaption;
            lblLoginWarning.Location = new Point(8, 156);
            lblLoginWarning.Name = "lblLoginWarning";
            lblLoginWarning.Size = new Size(218, 21);
            lblLoginWarning.TabIndex = 9;
            lblLoginWarning.Text = "You don't have an account?";
            lblLoginWarning.Click += lblLoginWarning_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 63);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Password : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 37);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Email : ";
            // 
            // button1
            // 
            button1.Location = new Point(8, 105);
            button1.Name = "button1";
            button1.Size = new Size(168, 36);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabSignup
            // 
            tabSignup.Controls.Add(label7);
            tabSignup.Controls.Add(textBox6);
            tabSignup.Controls.Add(textBox3);
            tabSignup.Controls.Add(label6);
            tabSignup.Controls.Add(label3);
            tabSignup.Controls.Add(textBox5);
            tabSignup.Controls.Add(label5);
            tabSignup.Controls.Add(textBox4);
            tabSignup.Controls.Add(label4);
            tabSignup.Controls.Add(button2);
            tabSignup.Location = new Point(4, 24);
            tabSignup.Name = "tabSignup";
            tabSignup.Padding = new Padding(3);
            tabSignup.Size = new Size(792, 422);
            tabSignup.TabIndex = 1;
            tabSignup.Text = "Sign Up";
            tabSignup.UseVisualStyleBackColor = true;
            tabSignup.Click += tabSignup_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(8, 204);
            label7.Name = "label7";
            label7.Size = new Size(235, 21);
            label7.TabIndex = 10;
            label7.Text = "You already have an account?";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(76, 50);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 111);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 53);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 4;
            label6.Text = "City : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 24);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Full Name : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 85);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "Email : ";
            // 
            // button2
            // 
            button2.Location = new Point(8, 153);
            button2.Name = "button2";
            button2.Size = new Size(168, 36);
            button2.TabIndex = 3;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewTab
            // 
            btnCreateNewTab.Location = new Point(321, 478);
            btnCreateNewTab.Name = "btnCreateNewTab";
            btnCreateNewTab.Size = new Size(101, 44);
            btnCreateNewTab.TabIndex = 1;
            btnCreateNewTab.Text = "Create New Tab";
            btnCreateNewTab.UseVisualStyleBackColor = true;
            btnCreateNewTab.Click += btnCreateNewTab_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(btnCreateNewTab);
            Controls.Add(tabControl1);
            Name = "Form6";
            Text = "Form6";
            tabControl1.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabSignup.ResumeLayout(false);
            tabSignup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabLogin;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TabPage tabSignup;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private Label lblLoginWarning;
        private Label label7;
        private Button btnCreateNewTab;
    }
}