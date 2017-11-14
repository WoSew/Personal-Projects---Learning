namespace TextBox
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
            this.tb_value = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.rtb_1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_value.Location = new System.Drawing.Point(200, 69);
            this.tb_value.Name = "tb_value";
            this.tb_value.PasswordChar = '*';
            this.tb_value.Size = new System.Drawing.Size(179, 27);
            this.tb_value.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_show.Location = new System.Drawing.Point(226, 121);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(124, 40);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Show value";
            this.btn_show.UseVisualStyleBackColor = true;
            // 
            // rtb_1
            // 
            this.rtb_1.Location = new System.Drawing.Point(68, 239);
            this.rtb_1.Name = "rtb_1";
            this.rtb_1.Size = new System.Drawing.Size(535, 105);
            this.rtb_1.TabIndex = 2;
            this.rtb_1.Text = "";
            this.rtb_1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 511);
            this.Controls.Add(this.rtb_1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.tb_value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.RichTextBox rtb_1;
    }
}

