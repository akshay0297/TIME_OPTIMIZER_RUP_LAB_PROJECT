namespace DBSLABPROJ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbox = new System.Windows.Forms.TextBox();
            this.rbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.TextBox();
            this.cpbox = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.Button();
            this.showp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Recovery Page\r\n";
            // 
            // nbox
            // 
            this.nbox.Location = new System.Drawing.Point(504, 142);
            this.nbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbox.Name = "nbox";
            this.nbox.Size = new System.Drawing.Size(276, 22);
            this.nbox.TabIndex = 3;
            // 
            // rbox
            // 
            this.rbox.Location = new System.Drawing.Point(504, 203);
            this.rbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbox.Name = "rbox";
            this.rbox.Size = new System.Drawing.Size(276, 22);
            this.rbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm New Password";
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(504, 258);
            this.pbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(276, 22);
            this.pbox.TabIndex = 7;
            this.pbox.UseSystemPasswordChar = true;
            // 
            // cpbox
            // 
            this.cpbox.Location = new System.Drawing.Point(504, 313);
            this.cpbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpbox.Name = "cpbox";
            this.cpbox.Size = new System.Drawing.Size(276, 22);
            this.cpbox.TabIndex = 8;
            this.cpbox.UseSystemPasswordChar = true;
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(352, 400);
            this.sub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(236, 41);
            this.sub.TabIndex = 9;
            this.sub.Text = "Submit";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // showp
            // 
            this.showp.AutoSize = true;
            this.showp.Location = new System.Drawing.Point(504, 361);
            this.showp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showp.Name = "showp";
            this.showp.Size = new System.Drawing.Size(136, 20);
            this.showp.TabIndex = 10;
            this.showp.Text = "Show Password";
            this.showp.UseVisualStyleBackColor = true;
            this.showp.CheckedChanged += new System.EventHandler(this.showp_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 490);
            this.Controls.Add(this.showp);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.cpbox);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbox);
            this.Controls.Add(this.nbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Password Recovery Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nbox;
        private System.Windows.Forms.TextBox rbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpbox;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.TextBox pbox;
        private System.Windows.Forms.CheckBox showp;
    }
}