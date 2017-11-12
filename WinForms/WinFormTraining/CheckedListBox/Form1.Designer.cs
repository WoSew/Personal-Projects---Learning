namespace CheckedListBox
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
            this.clb_1 = new System.Windows.Forms.CheckedListBox();
            this.rtb_1 = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.textBox_del = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_1
            // 
            this.clb_1.ColumnWidth = 100;
            this.clb_1.FormattingEnabled = true;
            this.clb_1.Items.AddRange(new object[] {
            "Value 1",
            "Value 1",
            "Value 1",
            "Value 1",
            "Value 2",
            "Value 2",
            "Value 2",
            "Value 2",
            "Value 3",
            "Value 3",
            "Value 3",
            "Value 3",
            "Value 4",
            "Value 4",
            "Value 4",
            "Value 4",
            "Value 5",
            "Value 5",
            "Value 5",
            "Value 5",
            "Value 6",
            "Value 6",
            "Value 6",
            "Value 6"});
            this.clb_1.Location = new System.Drawing.Point(12, 12);
            this.clb_1.MinimumSize = new System.Drawing.Size(200, 200);
            this.clb_1.MultiColumn = true;
            this.clb_1.Name = "clb_1";
            this.clb_1.Size = new System.Drawing.Size(361, 293);
            this.clb_1.TabIndex = 0;
            this.clb_1.SelectedIndexChanged += new System.EventHandler(this.clb_1_SelectedIndexChanged);
            // 
            // rtb_1
            // 
            this.rtb_1.Location = new System.Drawing.Point(401, 47);
            this.rtb_1.Name = "rtb_1";
            this.rtb_1.Size = new System.Drawing.Size(228, 304);
            this.rtb_1.TabIndex = 1;
            this.rtb_1.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(12, 321);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 30);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del.Location = new System.Drawing.Point(12, 370);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(133, 32);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textBox_add
            // 
            this.textBox_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_add.Location = new System.Drawing.Point(161, 321);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(210, 30);
            this.textBox_add.TabIndex = 4;
            // 
            // textBox_del
            // 
            this.textBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_del.Location = new System.Drawing.Point(161, 372);
            this.textBox_del.Name = "textBox_del";
            this.textBox_del.Size = new System.Drawing.Size(210, 30);
            this.textBox_del.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(395, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Checked position";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_del);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtb_1);
            this.Controls.Add(this.clb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_1;
        private System.Windows.Forms.RichTextBox rtb_1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.TextBox textBox_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

