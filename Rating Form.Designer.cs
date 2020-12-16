
namespace Ap_Project_Clinic_
{
    partial class rateform
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
            this.label8 = new System.Windows.Forms.Label();
            this.doctorform = new System.Windows.Forms.Panel();
            this.cbroot = new System.Windows.Forms.ComboBox();
            this.cbsu2 = new System.Windows.Forms.ComboBox();
            this.cbsu1 = new System.Windows.Forms.ComboBox();
            this.cbexam = new System.Windows.Forms.ComboBox();
            this.ratetime = new System.Windows.Forms.DateTimePicker();
            this.rbroot = new System.Windows.Forms.RadioButton();
            this.rb1serface = new System.Windows.Forms.RadioButton();
            this.rbsurface2 = new System.Windows.Forms.RadioButton();
            this.rbExamination = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.chkrestrictions = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chkhaveid = new System.Windows.Forms.RadioButton();
            this.chkodd = new System.Windows.Forms.RadioButton();
            this.chkeven = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.doctorform.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnratings
            // 
            this.btnratings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnratings.Location = new System.Drawing.Point(553, 551);
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
            this.groupBox1.Controls.Add(this.doctorform);
            this.groupBox1.Controls.Add(this.ratetime);
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
            this.groupBox1.BindingContextChanged += new System.EventHandler(this.groupBox1_BindingContextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(637, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date of turn";
            // 
            // doctorform
            // 
            this.doctorform.Controls.Add(this.cbroot);
            this.doctorform.Controls.Add(this.cbsu2);
            this.doctorform.Controls.Add(this.cbsu1);
            this.doctorform.Controls.Add(this.cbexam);
            this.doctorform.Location = new System.Drawing.Point(0, 101);
            this.doctorform.Name = "doctorform";
            this.doctorform.Size = new System.Drawing.Size(631, 69);
            this.doctorform.TabIndex = 21;
            // 
            // cbroot
            // 
            this.cbroot.Enabled = false;
            this.cbroot.FormattingEnabled = true;
            this.cbroot.Items.AddRange(new object[] {
            "Doctor AmirhoseinKatani"});
            this.cbroot.Location = new System.Drawing.Point(489, 29);
            this.cbroot.Name = "cbroot";
            this.cbroot.Size = new System.Drawing.Size(121, 24);
            this.cbroot.TabIndex = 24;
            // 
            // cbsu2
            // 
            this.cbsu2.Enabled = false;
            this.cbsu2.FormattingEnabled = true;
            this.cbsu2.Items.AddRange(new object[] {
            "Doctor Abarghoiee"});
            this.cbsu2.Location = new System.Drawing.Point(336, 29);
            this.cbsu2.Name = "cbsu2";
            this.cbsu2.Size = new System.Drawing.Size(121, 24);
            this.cbsu2.TabIndex = 23;
            // 
            // cbsu1
            // 
            this.cbsu1.Enabled = false;
            this.cbsu1.FormattingEnabled = true;
            this.cbsu1.Items.AddRange(new object[] {
            "Doctor Mah"});
            this.cbsu1.Location = new System.Drawing.Point(159, 29);
            this.cbsu1.Name = "cbsu1";
            this.cbsu1.Size = new System.Drawing.Size(121, 24);
            this.cbsu1.TabIndex = 22;
            // 
            // cbexam
            // 
            this.cbexam.FormattingEnabled = true;
            this.cbexam.Items.AddRange(new object[] {
            "Doctor taleb"});
            this.cbexam.Location = new System.Drawing.Point(3, 29);
            this.cbexam.Name = "cbexam";
            this.cbexam.Size = new System.Drawing.Size(121, 24);
            this.cbexam.TabIndex = 21;
            // 
            // ratetime
            // 
            this.ratetime.Location = new System.Drawing.Point(746, 128);
            this.ratetime.Name = "ratetime";
            this.ratetime.Size = new System.Drawing.Size(200, 22);
            this.ratetime.TabIndex = 13;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(505, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(348, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient File Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(175, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(139, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtfamilyname
            // 
            this.txtfamilyname.AutoSize = true;
            this.txtfamilyname.Enabled = false;
            this.txtfamilyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamilyname.Location = new System.Drawing.Point(348, 113);
            this.txtfamilyname.Name = "txtfamilyname";
            this.txtfamilyname.Size = new System.Drawing.Size(104, 20);
            this.txtfamilyname.TabIndex = 12;
            this.txtfamilyname.Text = "Family name";
            // 
            // txtfamily
            // 
            this.txtfamily.Enabled = false;
            this.txtfamily.Location = new System.Drawing.Point(509, 113);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(139, 22);
            this.txtfamily.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Enabled = false;
            this.txtphone.Location = new System.Drawing.Point(175, 148);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(139, 22);
            this.txtphone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(348, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Number";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(509, 150);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(139, 22);
            this.txtid.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(14, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Patient File Code";
            // 
            // txtfilecode
            // 
            this.txtfilecode.Enabled = false;
            this.txtfilecode.Location = new System.Drawing.Point(175, 185);
            this.txtfilecode.Name = "txtfilecode";
            this.txtfilecode.Size = new System.Drawing.Size(139, 22);
            this.txtfilecode.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(728, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Result";
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Location = new System.Drawing.Point(799, 564);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(214, 22);
            this.txtresult.TabIndex = 19;
            // 
            // chkrestrictions
            // 
            this.chkrestrictions.AutoSize = true;
            this.chkrestrictions.Location = new System.Drawing.Point(12, 32);
            this.chkrestrictions.Name = "chkrestrictions";
            this.chkrestrictions.Size = new System.Drawing.Size(147, 21);
            this.chkrestrictions.TabIndex = 21;
            this.chkrestrictions.Text = "Having restrictions";
            this.chkrestrictions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.chkhaveid);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtfamily);
            this.groupBox2.Controls.Add(this.txtfilecode);
            this.groupBox2.Controls.Add(this.txtfamilyname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(28, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 224);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "chknewpatient";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // chkhaveid
            // 
            this.chkhaveid.AutoSize = true;
            this.chkhaveid.Location = new System.Drawing.Point(13, 27);
            this.chkhaveid.Name = "chkhaveid";
            this.chkhaveid.Size = new System.Drawing.Size(130, 21);
            this.chkhaveid.TabIndex = 21;
            this.chkhaveid.TabStop = true;
            this.chkhaveid.Text = "Patient file code";
            this.chkhaveid.UseVisualStyleBackColor = true;
            // 
            // chkodd
            // 
            this.chkodd.AutoSize = true;
            this.chkodd.Location = new System.Drawing.Point(217, 32);
            this.chkodd.Name = "chkodd";
            this.chkodd.Size = new System.Drawing.Size(113, 21);
            this.chkodd.TabIndex = 25;
            this.chkodd.TabStop = true;
            this.chkodd.Text = "Not odd days";
            this.chkodd.UseVisualStyleBackColor = true;
            // 
            // chkeven
            // 
            this.chkeven.AutoSize = true;
            this.chkeven.Location = new System.Drawing.Point(355, 32);
            this.chkeven.Name = "chkeven";
            this.chkeven.Size = new System.Drawing.Size(123, 21);
            this.chkeven.TabIndex = 25;
            this.chkeven.TabStop = true;
            this.chkeven.Text = "Not Even Days";
            this.chkeven.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkrestrictions);
            this.groupBox3.Controls.Add(this.chkeven);
            this.groupBox3.Controls.Add(this.chkodd);
            this.groupBox3.Location = new System.Drawing.Point(28, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 58);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Have Problem";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(394, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "return to turns page";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rateform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnratings);
            this.Controls.Add(this.label1);
            this.Name = "rateform";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.doctorform.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ratetime;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton chkhaveid;
        private System.Windows.Forms.RadioButton chkodd;
        private System.Windows.Forms.RadioButton chkeven;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel doctorform;
        private System.Windows.Forms.ComboBox cbroot;
        private System.Windows.Forms.ComboBox cbsu2;
        private System.Windows.Forms.ComboBox cbsu1;
        private System.Windows.Forms.ComboBox cbexam;
        private System.Windows.Forms.Button button1;
    }
}