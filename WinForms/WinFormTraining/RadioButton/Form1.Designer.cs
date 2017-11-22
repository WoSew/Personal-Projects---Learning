namespace RadioButton
{
    partial class Form1
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
            this.radioBTN_A = new System.Windows.Forms.RadioButton();
            this.radioBTN_B = new System.Windows.Forms.RadioButton();
            this.radioBTN_C = new System.Windows.Forms.RadioButton();
            this.radioBTN_E = new System.Windows.Forms.RadioButton();
            this.radioBTN_D = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBTN_A
            // 
            this.radioBTN_A.AutoSize = true;
            this.radioBTN_A.Location = new System.Drawing.Point(38, 42);
            this.radioBTN_A.Name = "radioBTN_A";
            this.radioBTN_A.Size = new System.Drawing.Size(84, 21);
            this.radioBTN_A.TabIndex = 0;
            this.radioBTN_A.TabStop = true;
            this.radioBTN_A.Text = "Option A";
            this.radioBTN_A.UseVisualStyleBackColor = true;
            // 
            // radioBTN_B
            // 
            this.radioBTN_B.AutoSize = true;
            this.radioBTN_B.Location = new System.Drawing.Point(38, 69);
            this.radioBTN_B.Name = "radioBTN_B";
            this.radioBTN_B.Size = new System.Drawing.Size(84, 21);
            this.radioBTN_B.TabIndex = 1;
            this.radioBTN_B.TabStop = true;
            this.radioBTN_B.Text = "Option B";
            this.radioBTN_B.UseVisualStyleBackColor = true;
            // 
            // radioBTN_C
            // 
            this.radioBTN_C.AutoSize = true;
            this.radioBTN_C.Location = new System.Drawing.Point(38, 96);
            this.radioBTN_C.Name = "radioBTN_C";
            this.radioBTN_C.Size = new System.Drawing.Size(84, 21);
            this.radioBTN_C.TabIndex = 2;
            this.radioBTN_C.TabStop = true;
            this.radioBTN_C.Text = "Option C";
            this.radioBTN_C.UseVisualStyleBackColor = true;
            // 
            // radioBTN_E
            // 
            this.radioBTN_E.AutoSize = true;
            this.radioBTN_E.Location = new System.Drawing.Point(18, 37);
            this.radioBTN_E.Name = "radioBTN_E";
            this.radioBTN_E.Size = new System.Drawing.Size(84, 21);
            this.radioBTN_E.TabIndex = 4;
            this.radioBTN_E.TabStop = true;
            this.radioBTN_E.Text = "Option E";
            this.radioBTN_E.UseVisualStyleBackColor = true;
            // 
            // radioBTN_D
            // 
            this.radioBTN_D.AutoSize = true;
            this.radioBTN_D.Location = new System.Drawing.Point(17, 10);
            this.radioBTN_D.Name = "radioBTN_D";
            this.radioBTN_D.Size = new System.Drawing.Size(85, 21);
            this.radioBTN_D.TabIndex = 3;
            this.radioBTN_D.TabStop = true;
            this.radioBTN_D.Text = "Option D";
            this.radioBTN_D.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBTN_E);
            this.panel1.Controls.Add(this.radioBTN_D);
            this.panel1.Location = new System.Drawing.Point(22, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 71);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioBTN_C);
            this.Controls.Add(this.radioBTN_B);
            this.Controls.Add(this.radioBTN_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBTN_A;
        private System.Windows.Forms.RadioButton radioBTN_B;
        private System.Windows.Forms.RadioButton radioBTN_C;
        private System.Windows.Forms.RadioButton radioBTN_E;
        private System.Windows.Forms.RadioButton radioBTN_D;
        private System.Windows.Forms.Panel panel1;
    }
}

