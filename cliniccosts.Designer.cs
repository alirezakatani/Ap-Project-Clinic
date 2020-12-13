
namespace Ap_Project_Clinic_
{
    partial class cliniccosts
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
            this.txtexam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtroot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtonesurface = new System.Windows.Forms.TextBox();
            this.txttwosurface = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtexam
            // 
            this.txtexam.Location = new System.Drawing.Point(201, 44);
            this.txtexam.Name = "txtexam";
            this.txtexam.Size = new System.Drawing.Size(150, 22);
            this.txtexam.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "examinatincost";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtexam);
            this.groupBox1.Controls.Add(this.txtroot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtonesurface);
            this.groupBox1.Controls.Add(this.txttwosurface);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Root canal treatment";
            // 
            // txtroot
            // 
            this.txtroot.Location = new System.Drawing.Point(201, 176);
            this.txtroot.Name = "txtroot";
            this.txtroot.Size = new System.Drawing.Size(150, 22);
            this.txtroot.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Two-level restoration";
            // 
            // txtonesurface
            // 
            this.txtonesurface.Location = new System.Drawing.Point(201, 84);
            this.txtonesurface.Name = "txtonesurface";
            this.txtonesurface.Size = new System.Drawing.Size(150, 22);
            this.txtonesurface.TabIndex = 4;
            // 
            // txttwosurface
            // 
            this.txttwosurface.Location = new System.Drawing.Point(201, 131);
            this.txttwosurface.Name = "txttwosurface";
            this.txttwosurface.Size = new System.Drawing.Size(150, 22);
            this.txttwosurface.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "One surface repair";
            // 
            // cliniccosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "cliniccosts";
            this.Text = "cliniccosts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtexam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtonesurface;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttwosurface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtroot;
    }
}