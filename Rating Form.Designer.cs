
namespace Ap_Project_Clinic_
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
            this.btnratings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExamination = new System.Windows.Forms.RadioButton();
            this.rbsurface2 = new System.Windows.Forms.RadioButton();
            this.rb1serface = new System.Windows.Forms.RadioButton();
            this.rbroot = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.chkhaveid = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chknewpatient = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamilyname = new System.Windows.Forms.Label();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfilecode = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.chkrestrictions = new System.Windows.Forms.CheckBox();
            this.chkeven = new System.Windows.Forms.CheckBox();
            this.chkodd = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnratings
            // 
            this.btnratings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnratings.Location = new System.Drawing.Point(520, 549);
            this.btnratings.Name = "btnratings";
            this.btnratings.Size = new System.Drawing.Size(153, 46);
            this.btnratings.TabIndex = 3;
            this.btnratings.Text = "Turn ratings";
            this.btnratings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rating Section";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rbroot);
            this.groupBox1.Controls.Add(this.rb1serface);
            this.groupBox1.Controls.Add(this.rbsurface2);
            this.groupBox1.Controls.Add(this.rbExamination);
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service and Doctors";
            // 
            // rbExamination
            // 
            this.rbExamination.AutoSize = true;
            this.rbExamination.Location = new System.Drawing.Point(6, 51);
            this.rbExamination.Name = "rbExamination";
            this.rbExamination.Size = new System.Drawing.Size(105, 21);
            this.rbExamination.TabIndex = 5;
            this.rbExamination.TabStop = true;
            this.rbExamination.Text = "Examination";
            this.rbExamination.UseVisualStyleBackColor = true;
            // 
            // rbsurface2
            // 
            this.rbsurface2.AutoSize = true;
            this.rbsurface2.Location = new System.Drawing.Point(327, 51);
            this.rbsurface2.Name = "rbsurface2";
            this.rbsurface2.Size = new System.Drawing.Size(161, 21);
            this.rbsurface2.TabIndex = 6;
            this.rbsurface2.TabStop = true;
            this.rbsurface2.Text = "Two-level restoration";
            this.rbsurface2.UseVisualStyleBackColor = true;
            // 
            // rb1serface
            // 
            this.rb1serface.AutoSize = true;
            this.rb1serface.Location = new System.Drawing.Point(162, 51);
            this.rb1serface.Name = "rb1serface";
            this.rb1serface.Size = new System.Drawing.Size(148, 21);
            this.rb1serface.TabIndex = 7;
            this.rb1serface.TabStop = true;
            this.rb1serface.Text = "One surface repair";
            this.rb1serface.UseVisualStyleBackColor = true;
            // 
            // rbroot
            // 
            this.rbroot.AutoSize = true;
            this.rbroot.Location = new System.Drawing.Point(503, 51);
            this.rbroot.Name = "rbroot";
            this.rbroot.Size = new System.Drawing.Size(161, 21);
            this.rbroot.TabIndex = 9;
            this.rbroot.TabStop = true;
            this.rbroot.Text = "Root canal treatment";
            this.rbroot.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(162, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(339, 126);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(492, 126);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 12;
            // 
            // chkhaveid
            // 
            this.chkhaveid.AutoSize = true;
            this.chkhaveid.Location = new System.Drawing.Point(28, 283);
            this.chkhaveid.Name = "chkhaveid";
            this.chkhaveid.Size = new System.Drawing.Size(131, 21);
            this.chkhaveid.TabIndex = 5;
            this.chkhaveid.Text = "Patient file code";
            this.chkhaveid.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(520, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(363, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient File Code";
            // 
            // chknewpatient
            // 
            this.chknewpatient.AutoSize = true;
            this.chknewpatient.Location = new System.Drawing.Point(28, 321);
            this.chknewpatient.Name = "chknewpatient";
            this.chknewpatient.Size = new System.Drawing.Size(105, 21);
            this.chknewpatient.TabIndex = 8;
            this.chknewpatient.Text = "New Patient";
            this.chknewpatient.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(29, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(190, 368);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(139, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtfamilyname
            // 
            this.txtfamilyname.AutoSize = true;
            this.txtfamilyname.Enabled = false;
            this.txtfamilyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamilyname.Location = new System.Drawing.Point(363, 368);
            this.txtfamilyname.Name = "txtfamilyname";
            this.txtfamilyname.Size = new System.Drawing.Size(104, 20);
            this.txtfamilyname.TabIndex = 12;
            this.txtfamilyname.Text = "Family name";
            // 
            // txtfamily
            // 
            this.txtfamily.Enabled = false;
            this.txtfamily.Location = new System.Drawing.Point(524, 368);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(139, 22);
            this.txtfamily.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(29, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Enabled = false;
            this.txtphone.Location = new System.Drawing.Point(190, 403);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(139, 22);
            this.txtphone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(363, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Number";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(524, 405);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(139, 22);
            this.txtid.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(29, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Patient File Code";
            // 
            // txtfilecode
            // 
            this.txtfilecode.Enabled = false;
            this.txtfilecode.Location = new System.Drawing.Point(190, 440);
            this.txtfilecode.Name = "txtfilecode";
            this.txtfilecode.Size = new System.Drawing.Size(139, 22);
            this.txtfilecode.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(746, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(642, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date of turn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(695, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Result";
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Location = new System.Drawing.Point(790, 562);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(139, 22);
            this.txtresult.TabIndex = 19;
            // 
            // chkrestrictions
            // 
            this.chkrestrictions.AutoSize = true;
            this.chkrestrictions.Location = new System.Drawing.Point(16, 500);
            this.chkrestrictions.Name = "chkrestrictions";
            this.chkrestrictions.Size = new System.Drawing.Size(147, 21);
            this.chkrestrictions.TabIndex = 21;
            this.chkrestrictions.Text = "Having restrictions";
            this.chkrestrictions.UseVisualStyleBackColor = true;
            // 
            // chkeven
            // 
            this.chkeven.AutoSize = true;
            this.chkeven.Location = new System.Drawing.Point(343, 500);
            this.chkeven.Name = "chkeven";
            this.chkeven.Size = new System.Drawing.Size(124, 21);
            this.chkeven.TabIndex = 22;
            this.chkeven.Text = "Not Even Days";
            this.chkeven.UseVisualStyleBackColor = true;
            // 
            // chkodd
            // 
            this.chkodd.AutoSize = true;
            this.chkodd.Location = new System.Drawing.Point(206, 500);
            this.chkodd.Name = "chkodd";
            this.chkodd.Size = new System.Drawing.Size(114, 21);
            this.chkodd.TabIndex = 23;
            this.chkodd.Text = "Not odd days";
            this.chkodd.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 609);
            this.Controls.Add(this.chkodd);
            this.Controls.Add(this.chkeven);
            this.Controls.Add(this.chkrestrictions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfilecode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfamilyname);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.chknewpatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkhaveid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnratings);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnratings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExamination;
        private System.Windows.Forms.RadioButton rbroot;
        private System.Windows.Forms.RadioButton rb1serface;
        private System.Windows.Forms.RadioButton rbsurface2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkhaveid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chknewpatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label txtfamilyname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfilecode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.CheckBox chkrestrictions;
        private System.Windows.Forms.CheckBox chkeven;
        private System.Windows.Forms.CheckBox chkodd;
    }
}