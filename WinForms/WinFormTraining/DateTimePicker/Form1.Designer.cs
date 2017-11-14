namespace DateTimePicker
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
            this.dtp_current = new System.Windows.Forms.DateTimePicker();
            this.dtp_new = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_time = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.Btn_Current_Time = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_current
            // 
            this.dtp_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_current.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_current.Location = new System.Drawing.Point(29, 57);
            this.dtp_current.Name = "dtp_current";
            this.dtp_current.Size = new System.Drawing.Size(163, 30);
            this.dtp_current.TabIndex = 0;
            // 
            // dtp_new
            // 
            this.dtp_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_new.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_new.Location = new System.Drawing.Point(241, 57);
            this.dtp_new.Name = "dtp_new";
            this.dtp_new.Size = new System.Drawing.Size(163, 30);
            this.dtp_new.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "New date";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_update.Location = new System.Drawing.Point(29, 105);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(375, 36);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update date";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_time
            // 
            this.btn_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_time.Location = new System.Drawing.Point(223, 188);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(181, 36);
            this.btn_time.TabIndex = 5;
            this.btn_time.Text = "Add hour";
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Click += new System.EventHandler(this.Btn_time_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time:";
            // 
            // dtp_time
            // 
            this.dtp_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time.Location = new System.Drawing.Point(29, 189);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.ShowUpDown = true;
            this.dtp_time.Size = new System.Drawing.Size(163, 30);
            this.dtp_time.TabIndex = 6;
            // 
            // Btn_Current_Time
            // 
            this.Btn_Current_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Current_Time.Location = new System.Drawing.Point(223, 243);
            this.Btn_Current_Time.Name = "Btn_Current_Time";
            this.Btn_Current_Time.Size = new System.Drawing.Size(181, 36);
            this.Btn_Current_Time.TabIndex = 8;
            this.Btn_Current_Time.Text = "Current time";
            this.Btn_Current_Time.UseVisualStyleBackColor = true;
            this.Btn_Current_Time.Click += new System.EventHandler(this.Btn_Current_Time_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 416);
            this.Controls.Add(this.Btn_Current_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_new);
            this.Controls.Add(this.dtp_current);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_current;
        private System.Windows.Forms.DateTimePicker dtp_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.Button Btn_Current_Time;
    }
}

