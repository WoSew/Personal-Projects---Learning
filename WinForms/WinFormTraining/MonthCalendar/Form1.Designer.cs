namespace MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lb_currentDate = new System.Windows.Forms.Label();
            this.tb_currentDate = new System.Windows.Forms.TextBox();
            this.lb_newDate = new System.Windows.Forms.Label();
            this.dtp_newDate = new System.Windows.Forms.DateTimePicker();
            this.btn_updateDate = new System.Windows.Forms.Button();
            this.btn_weeksNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 151);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lb_currentDate
            // 
            this.lb_currentDate.AutoSize = true;
            this.lb_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_currentDate.Location = new System.Drawing.Point(22, 55);
            this.lb_currentDate.Name = "lb_currentDate";
            this.lb_currentDate.Size = new System.Drawing.Size(107, 20);
            this.lb_currentDate.TabIndex = 1;
            this.lb_currentDate.Text = "Current date:";
            // 
            // tb_currentDate
            // 
            this.tb_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_currentDate.Location = new System.Drawing.Point(26, 78);
            this.tb_currentDate.Name = "tb_currentDate";
            this.tb_currentDate.ReadOnly = true;
            this.tb_currentDate.ShortcutsEnabled = false;
            this.tb_currentDate.Size = new System.Drawing.Size(146, 27);
            this.tb_currentDate.TabIndex = 2;
            // 
            // lb_newDate
            // 
            this.lb_newDate.AutoSize = true;
            this.lb_newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_newDate.Location = new System.Drawing.Point(198, 55);
            this.lb_newDate.Name = "lb_newDate";
            this.lb_newDate.Size = new System.Drawing.Size(84, 20);
            this.lb_newDate.TabIndex = 3;
            this.lb_newDate.Text = "New date:";
            // 
            // dtp_newDate
            // 
            this.dtp_newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_newDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_newDate.Location = new System.Drawing.Point(202, 78);
            this.dtp_newDate.Name = "dtp_newDate";
            this.dtp_newDate.Size = new System.Drawing.Size(173, 27);
            this.dtp_newDate.TabIndex = 4;
            // 
            // btn_updateDate
            // 
            this.btn_updateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_updateDate.Location = new System.Drawing.Point(26, 111);
            this.btn_updateDate.Name = "btn_updateDate";
            this.btn_updateDate.Size = new System.Drawing.Size(349, 28);
            this.btn_updateDate.TabIndex = 5;
            this.btn_updateDate.Text = "Update date";
            this.btn_updateDate.UseVisualStyleBackColor = true;
            this.btn_updateDate.Click += new System.EventHandler(this.btn_updateDate_Click);
            // 
            // btn_weeksNumbers
            // 
            this.btn_weeksNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_weeksNumbers.Location = new System.Drawing.Point(18, 370);
            this.btn_weeksNumbers.Name = "btn_weeksNumbers";
            this.btn_weeksNumbers.Size = new System.Drawing.Size(357, 28);
            this.btn_weeksNumbers.TabIndex = 6;
            this.btn_weeksNumbers.Text = "Show weeks numbers";
            this.btn_weeksNumbers.UseVisualStyleBackColor = true;
            this.btn_weeksNumbers.Click += new System.EventHandler(this.btn_weeksNumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quick Calendar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_weeksNumbers);
            this.Controls.Add(this.btn_updateDate);
            this.Controls.Add(this.dtp_newDate);
            this.Controls.Add(this.lb_newDate);
            this.Controls.Add(this.tb_currentDate);
            this.Controls.Add(this.lb_currentDate);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lb_currentDate;
        private System.Windows.Forms.TextBox tb_currentDate;
        private System.Windows.Forms.Label lb_newDate;
        private System.Windows.Forms.DateTimePicker dtp_newDate;
        private System.Windows.Forms.Button btn_updateDate;
        private System.Windows.Forms.Button btn_weeksNumbers;
        private System.Windows.Forms.Label label1;
    }
}

