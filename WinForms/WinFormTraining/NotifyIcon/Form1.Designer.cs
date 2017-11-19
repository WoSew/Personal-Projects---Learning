namespace NotifyIcon
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon_1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_showNotyfication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon_1
            // 
            this.notifyIcon_1.Text = "notifyIcon1";
            this.notifyIcon_1.Visible = true;
            // 
            // btn_showNotyfication
            // 
            this.btn_showNotyfication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_showNotyfication.Location = new System.Drawing.Point(45, 27);
            this.btn_showNotyfication.Name = "btn_showNotyfication";
            this.btn_showNotyfication.Size = new System.Drawing.Size(204, 40);
            this.btn_showNotyfication.TabIndex = 0;
            this.btn_showNotyfication.Text = "Show notyfication";
            this.btn_showNotyfication.UseVisualStyleBackColor = true;
            this.btn_showNotyfication.Click += new System.EventHandler(this.btn_showNotyfication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 112);
            this.Controls.Add(this.btn_showNotyfication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon_1;
        private System.Windows.Forms.Button btn_showNotyfication;
    }
}

