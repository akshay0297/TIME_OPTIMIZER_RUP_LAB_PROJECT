namespace DBSLABPROJ
{
    partial class Form5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.et = new System.Windows.Forms.TextBox();
            this.ed = new System.Windows.Forms.DateTimePicker();
            this.create = new System.Windows.Forms.Button();
            this.showevent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Creation Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Name\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Event Time";
            // 
            // rb
            // 
            this.rb.Location = new System.Drawing.Point(379, 135);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(200, 20);
            this.rb.TabIndex = 5;
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(379, 190);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(200, 20);
            this.en.TabIndex = 6;
            // 
            // et
            // 
            this.et.Location = new System.Drawing.Point(379, 296);
            this.et.Name = "et";
            this.et.Size = new System.Drawing.Size(200, 20);
            this.et.TabIndex = 8;
            // 
            // ed
            // 
            this.ed.Location = new System.Drawing.Point(379, 247);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(200, 20);
            this.ed.TabIndex = 9;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(261, 388);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(175, 46);
            this.create.TabIndex = 10;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // showevent
            // 
            this.showevent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showevent.Location = new System.Drawing.Point(540, 388);
            this.showevent.Name = "showevent";
            this.showevent.Size = new System.Drawing.Size(183, 46);
            this.showevent.TabIndex = 11;
            this.showevent.Text = "Show Existing Event";
            this.showevent.UseVisualStyleBackColor = false;
            this.showevent.Click += new System.EventHandler(this.showevent_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 482);
            this.Controls.Add(this.showevent);
            this.Controls.Add(this.create);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.et);
            this.Controls.Add(this.en);
            this.Controls.Add(this.rb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Event Creation Page";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rb;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.TextBox et;
        private System.Windows.Forms.DateTimePicker ed;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button showevent;
    }
}