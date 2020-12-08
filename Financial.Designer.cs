
namespace Ap_Project_Clinic_
{
    partial class FinancialForm
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
            this.btnEquity = new System.Windows.Forms.Button();
            this.btnsalary = new System.Windows.Forms.Button();
            this.btnClinic = new System.Windows.Forms.Button();
            this.btnmedical = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(114, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Section";
            // 
            // btnEquity
            // 
            this.btnEquity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEquity.Location = new System.Drawing.Point(98, 115);
            this.btnEquity.Name = "btnEquity";
            this.btnEquity.Size = new System.Drawing.Size(153, 46);
            this.btnEquity.TabIndex = 1;
            this.btnEquity.Text = "Equity affairs";
            this.btnEquity.UseVisualStyleBackColor = true;
            // 
            // btnsalary
            // 
            this.btnsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsalary.Location = new System.Drawing.Point(98, 163);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(153, 51);
            this.btnsalary.TabIndex = 3;
            this.btnsalary.Text = "employees\' salary";
            this.btnsalary.UseVisualStyleBackColor = true;
            this.btnsalary.Click += new System.EventHandler(this.btnsalary_Click);
            // 
            // btnClinic
            // 
            this.btnClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClinic.Location = new System.Drawing.Point(98, 217);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Size = new System.Drawing.Size(153, 52);
            this.btnClinic.TabIndex = 5;
            this.btnClinic.Text = "Clinic costs";
            this.btnClinic.UseVisualStyleBackColor = true;
            // 
            // btnmedical
            // 
            this.btnmedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnmedical.Location = new System.Drawing.Point(98, 275);
            this.btnmedical.Name = "btnmedical";
            this.btnmedical.Size = new System.Drawing.Size(153, 52);
            this.btnmedical.TabIndex = 6;
            this.btnmedical.Text = "medical expenses";
            this.btnmedical.UseVisualStyleBackColor = true;
            // 
            // FinancialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 513);
            this.Controls.Add(this.btnmedical);
            this.Controls.Add(this.btnClinic);
            this.Controls.Add(this.btnsalary);
            this.Controls.Add(this.btnEquity);
            this.Controls.Add(this.label1);
            this.Name = "FinancialForm";
            this.Text = "Financial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEquity;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.Button btnClinic;
        private System.Windows.Forms.Button btnmedical;
    }
}