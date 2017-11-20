namespace ProgressBar_Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.pg_loadingBar = new System.Windows.Forms.ProgressBar();
            this.btn_activate = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(251, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading";
            // 
            // pg_loadingBar
            // 
            this.pg_loadingBar.Location = new System.Drawing.Point(12, 444);
            this.pg_loadingBar.Name = "pg_loadingBar";
            this.pg_loadingBar.Size = new System.Drawing.Size(561, 20);
            this.pg_loadingBar.Step = 100;
            this.pg_loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pg_loadingBar.TabIndex = 1;
            // 
            // btn_activate
            // 
            this.btn_activate.Location = new System.Drawing.Point(241, 215);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(108, 38);
            this.btn_activate.TabIndex = 2;
            this.btn_activate.Text = "Sing In";
            this.btn_activate.UseVisualStyleBackColor = true;
            this.btn_activate.Click += new System.EventHandler(this.btn_activate_Click);
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_login.Location = new System.Drawing.Point(206, 139);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(184, 27);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password.Location = new System.Drawing.Point(206, 172);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(184, 27);
            this.tb_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "password:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.btn_activate);
            this.Controls.Add(this.pg_loadingBar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pg_loadingBar;
        private System.Windows.Forms.Button btn_activate;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

