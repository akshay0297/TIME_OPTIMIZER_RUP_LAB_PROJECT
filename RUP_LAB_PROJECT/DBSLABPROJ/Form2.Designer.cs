namespace DBSLABPROJ
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fac = new System.Windows.Forms.RadioButton();
            this.stud = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noteL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.regno = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.cpass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.branch = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Number";
            // 
            // fac
            // 
            this.fac.AutoSize = true;
            this.fac.Location = new System.Drawing.Point(199, 19);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(59, 17);
            this.fac.TabIndex = 2;
            this.fac.TabStop = true;
            this.fac.Text = "Faculty";
            this.fac.UseVisualStyleBackColor = true;
            // 
            // stud
            // 
            this.stud.AutoSize = true;
            this.stud.Location = new System.Drawing.Point(38, 19);
            this.stud.Name = "stud";
            this.stud.Size = new System.Drawing.Size(62, 17);
            this.stud.TabIndex = 3;
            this.stud.TabStop = true;
            this.stud.Text = "Student";
            this.stud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stud);
            this.groupBox1.Controls.Add(this.fac);
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gb1";
            // 
            // noteL
            // 
            this.noteL.AutoSize = true;
            this.noteL.BackColor = System.Drawing.SystemColors.Control;
            this.noteL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteL.ForeColor = System.Drawing.Color.Black;
            this.noteL.Location = new System.Drawing.Point(34, 418);
            this.noteL.Name = "noteL";
            this.noteL.Size = new System.Drawing.Size(725, 20);
            this.noteL.TabIndex = 5;
            this.noteL.Text = "Note : If you are faculty the use last 4 digits of your mobile number as registra" +
    "tion number";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Branch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(237, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(381, 20);
            this.name.TabIndex = 11;
            // 
            // regno
            // 
            this.regno.Location = new System.Drawing.Point(237, 158);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(267, 20);
            this.regno.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(237, 192);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(267, 22);
            this.pass.TabIndex = 13;
            // 
            // cpass
            // 
            this.cpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpass.Location = new System.Drawing.Point(237, 228);
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(267, 22);
            this.cpass.TabIndex = 14;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(237, 259);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(381, 20);
            this.email.TabIndex = 15;
            // 
            // branch
            // 
            this.branch.Location = new System.Drawing.Point(237, 293);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(136, 20);
            this.branch.TabIndex = 16;
            // 
            // section
            // 
            this.section.Location = new System.Drawing.Point(237, 325);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(136, 20);
            this.section.TabIndex = 17;
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(576, 226);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(102, 17);
            this.showpass.TabIndex = 18;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(552, 363);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(176, 52);
            this.submit.TabIndex = 19;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Registration Page";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 455);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.section);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fac;
        private System.Windows.Forms.RadioButton stud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label noteL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox branch;
        private System.Windows.Forms.TextBox section;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label8;
    }
}