namespace CheckBox
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
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_1.Location = new System.Drawing.Point(281, 217);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(60, 29);
            this.cb_1.TabIndex = 0;
            this.cb_1.Text = "Ok";
            this.cb_1.UseVisualStyleBackColor = true;
            this.cb_1.CheckedChanged += new System.EventHandler(this.cb_1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 482);
            this.Controls.Add(this.cb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_1;
    }
}

