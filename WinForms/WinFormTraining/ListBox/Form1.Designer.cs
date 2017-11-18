using System.Windows.Forms;

namespace ListBox
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
            this.lb_valueList = new System.Windows.Forms.ListBox();
            this.l_value = new System.Windows.Forms.Label();
            this.l_new = new System.Windows.Forms.Label();
            this.rtb_new = new System.Windows.Forms.RichTextBox();
            this.rtb_del = new System.Windows.Forms.RichTextBox();
            this.l_del = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lb_selected = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_valueList
            // 
            this.lb_valueList.AllowDrop = true;
            this.lb_valueList.FormattingEnabled = true;
            this.lb_valueList.ItemHeight = 16;
            this.lb_valueList.Items.AddRange(new object[] {
            "Wojtek",
            "Kasia",
            "Piotrek",
            "Paulina",
            "Marcin",
            "Wiki"});
            this.lb_valueList.Location = new System.Drawing.Point(17, 37);
            this.lb_valueList.Name = "lb_valueList";
            this.lb_valueList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_valueList.Size = new System.Drawing.Size(280, 148);
            this.lb_valueList.TabIndex = 0;
            this.lb_valueList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_valueList_DragDrop);
            this.lb_valueList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_valueList_DragEnter);
            this.lb_valueList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_valueList_MouseDown);
            // 
            // l_value
            // 
            this.l_value.AutoSize = true;
            this.l_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_value.Location = new System.Drawing.Point(12, 9);
            this.l_value.Name = "l_value";
            this.l_value.Size = new System.Drawing.Size(104, 25);
            this.l_value.TabIndex = 1;
            this.l_value.Text = "Value List:";
            // 
            // l_new
            // 
            this.l_new.AutoSize = true;
            this.l_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_new.Location = new System.Drawing.Point(13, 205);
            this.l_new.Name = "l_new";
            this.l_new.Size = new System.Drawing.Size(91, 20);
            this.l_new.TabIndex = 2;
            this.l_new.Text = "New value:";
            // 
            // rtb_new
            // 
            this.rtb_new.Location = new System.Drawing.Point(17, 228);
            this.rtb_new.Name = "rtb_new";
            this.rtb_new.Size = new System.Drawing.Size(132, 36);
            this.rtb_new.TabIndex = 1;
            this.rtb_new.Text = "";
            // 
            // rtb_del
            // 
            this.rtb_del.Location = new System.Drawing.Point(168, 228);
            this.rtb_del.Name = "rtb_del";
            this.rtb_del.Size = new System.Drawing.Size(132, 36);
            this.rtb_del.TabIndex = 2;
            this.rtb_del.Text = "";
            // 
            // l_del
            // 
            this.l_del.AutoSize = true;
            this.l_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_del.Location = new System.Drawing.Point(164, 205);
            this.l_del.Name = "l_del";
            this.l_del.Size = new System.Drawing.Size(107, 20);
            this.l_del.TabIndex = 4;
            this.l_del.Text = "Delete value:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_add.Location = new System.Drawing.Point(17, 270);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 30);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_del.Location = new System.Drawing.Point(168, 270);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(129, 30);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_sort.Location = new System.Drawing.Point(17, 306);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(129, 30);
            this.btn_sort.TabIndex = 5;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clear.Location = new System.Drawing.Point(168, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 30);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lb_selected
            // 
            this.lb_selected.AllowDrop = true;
            this.lb_selected.FormattingEnabled = true;
            this.lb_selected.ItemHeight = 16;
            this.lb_selected.Location = new System.Drawing.Point(325, 37);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_selected.Size = new System.Drawing.Size(273, 212);
            this.lb_selected.TabIndex = 7;
            this.lb_selected.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_selected_DragDrop);
            this.lb_selected.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_selected_DragEnter);
            this.lb_selected.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_selected_DragOver);
            this.lb_selected.DoubleClick += new System.EventHandler(this.lb_selected_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected values:";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(316, 270);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(273, 30);
            this.btn_open.TabIndex = 9;
            this.btn_open.Text = "Open file";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Open file folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtb_del);
            this.Controls.Add(this.l_del);
            this.Controls.Add(this.rtb_new);
            this.Controls.Add(this.l_new);
            this.Controls.Add(this.l_value);
            this.Controls.Add(this.lb_valueList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Lb_selected_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lb_valueList;
        private System.Windows.Forms.Label l_value;
        private System.Windows.Forms.Label l_new;
        private System.Windows.Forms.RichTextBox rtb_new;
        private System.Windows.Forms.RichTextBox rtb_del;
        private System.Windows.Forms.Label l_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox lb_selected;
        private System.Windows.Forms.Label label1;
        private Button btn_open;
        private Button button1;
    }
}

