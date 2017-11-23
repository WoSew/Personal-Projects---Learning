namespace FlowLayoutPanel
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
            this.flp_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_btnName = new System.Windows.Forms.Label();
            this.tb_btnName = new System.Windows.Forms.TextBox();
            this.tb_btnText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.cb_Alignment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddButton = new System.Windows.Forms.Button();
            this.btn_AddButtons = new System.Windows.Forms.Button();
            this.clb_Properties = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Panel
            // 
            this.flp_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flp_Panel.Location = new System.Drawing.Point(16, 108);
            this.flp_Panel.Name = "flp_Panel";
            this.flp_Panel.Size = new System.Drawing.Size(836, 350);
            this.flp_Panel.TabIndex = 0;
            // 
            // lb_btnName
            // 
            this.lb_btnName.AutoSize = true;
            this.lb_btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_btnName.Location = new System.Drawing.Point(12, 9);
            this.lb_btnName.Name = "lb_btnName";
            this.lb_btnName.Size = new System.Drawing.Size(109, 20);
            this.lb_btnName.TabIndex = 1;
            this.lb_btnName.Text = "Button name:";
            // 
            // tb_btnName
            // 
            this.tb_btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_btnName.Location = new System.Drawing.Point(16, 32);
            this.tb_btnName.Name = "tb_btnName";
            this.tb_btnName.Size = new System.Drawing.Size(160, 27);
            this.tb_btnName.TabIndex = 2;
            // 
            // tb_btnText
            // 
            this.tb_btnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_btnText.Location = new System.Drawing.Point(182, 32);
            this.tb_btnText.Name = "tb_btnText";
            this.tb_btnText.Size = new System.Drawing.Size(160, 27);
            this.tb_btnText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Button text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_Quantity.Location = new System.Drawing.Point(348, 32);
            this.nud_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(135, 27);
            this.nud_Quantity.TabIndex = 6;
            this.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.ValueChanged += new System.EventHandler(this.nud_Quantity_ValueChanged);
            // 
            // cb_Alignment
            // 
            this.cb_Alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Alignment.FormattingEnabled = true;
            this.cb_Alignment.Items.AddRange(new object[] {
            "TopDown",
            "ButtomUp",
            "LeftToRight",
            "RightToLeft"});
            this.cb_Alignment.Location = new System.Drawing.Point(489, 32);
            this.cb_Alignment.Name = "cb_Alignment";
            this.cb_Alignment.Size = new System.Drawing.Size(144, 28);
            this.cb_Alignment.TabIndex = 7;
            this.cb_Alignment.SelectedIndexChanged += new System.EventHandler(this.cb_Alignment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(485, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alignment method:";
            // 
            // btn_AddButton
            // 
            this.btn_AddButton.Location = new System.Drawing.Point(16, 65);
            this.btn_AddButton.Name = "btn_AddButton";
            this.btn_AddButton.Size = new System.Drawing.Size(326, 31);
            this.btn_AddButton.TabIndex = 9;
            this.btn_AddButton.Text = "Add button";
            this.btn_AddButton.UseVisualStyleBackColor = true;
            this.btn_AddButton.Click += new System.EventHandler(this.btn_AddButton_Click);
            // 
            // btn_AddButtons
            // 
            this.btn_AddButtons.Location = new System.Drawing.Point(348, 65);
            this.btn_AddButtons.Name = "btn_AddButtons";
            this.btn_AddButtons.Size = new System.Drawing.Size(285, 31);
            this.btn_AddButtons.TabIndex = 10;
            this.btn_AddButtons.Text = "Add buttons";
            this.btn_AddButtons.UseVisualStyleBackColor = true;
            this.btn_AddButtons.Click += new System.EventHandler(this.btn_AddButtons_Click);
            // 
            // clb_Properties
            // 
            this.clb_Properties.CheckOnClick = true;
            this.clb_Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clb_Properties.FormattingEnabled = true;
            this.clb_Properties.Items.AddRange(new object[] {
            "AutoScroll",
            "AutoSize",
            "WrapContents"});
            this.clb_Properties.Location = new System.Drawing.Point(639, 32);
            this.clb_Properties.Name = "clb_Properties";
            this.clb_Properties.Size = new System.Drawing.Size(213, 70);
            this.clb_Properties.TabIndex = 11;
            this.clb_Properties.SelectedIndexChanged += new System.EventHandler(this.clb_Properties_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(639, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Properties:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clb_Properties);
            this.Controls.Add(this.btn_AddButtons);
            this.Controls.Add(this.btn_AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Alignment);
            this.Controls.Add(this.nud_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_btnText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_btnName);
            this.Controls.Add(this.lb_btnName);
            this.Controls.Add(this.flp_Panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Panel;
        private System.Windows.Forms.Label lb_btnName;
        private System.Windows.Forms.TextBox tb_btnName;
        private System.Windows.Forms.TextBox tb_btnText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.ComboBox cb_Alignment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddButton;
        private System.Windows.Forms.Button btn_AddButtons;
        private System.Windows.Forms.CheckedListBox clb_Properties;
        private System.Windows.Forms.Label label1;
    }
}

