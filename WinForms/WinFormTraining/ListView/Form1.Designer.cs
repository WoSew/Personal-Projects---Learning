namespace ListView
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jan",
            "Kowalski",
            "20"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Men", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Anna",
            "Nowak",
            "18"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Women", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Piotr",
            "Kot",
            "33"}, -1);
            this.LV_persons = new System.Windows.Forms.ListView();
            this.Name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_selectedAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_selectedSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_selectedName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LV_persons
            // 
            this.LV_persons.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV_persons.AllowColumnReorder = true;
            this.LV_persons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV_persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_col,
            this.Surname_col,
            this.Age_col});
            this.LV_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LV_persons.FullRowSelect = true;
            this.LV_persons.GridLines = true;
            this.LV_persons.HoverSelection = true;
            listViewGroup3.Header = "Men";
            listViewGroup3.Name = "ListViewGroup_men";
            listViewItem4.Group = listViewGroup3;
            listViewItem4.StateImageIndex = 0;
            listViewGroup4.Header = "Women";
            listViewGroup4.Name = "ListViewGroup_women";
            listViewItem5.Group = listViewGroup4;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup3;
            listViewItem6.StateImageIndex = 0;
            this.LV_persons.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.LV_persons.Location = new System.Drawing.Point(275, 12);
            this.LV_persons.MultiSelect = false;
            this.LV_persons.Name = "LV_persons";
            this.LV_persons.Size = new System.Drawing.Size(351, 308);
            this.LV_persons.TabIndex = 0;
            this.LV_persons.UseCompatibleStateImageBehavior = false;
            this.LV_persons.View = System.Windows.Forms.View.Details;
            this.LV_persons.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_persons_ItemSelectionChanged);
            // 
            // Name_col
            // 
            this.Name_col.Text = "Name";
            this.Name_col.Width = 100;
            // 
            // Surname_col
            // 
            this.Surname_col.Text = "Surname";
            this.Surname_col.Width = 100;
            // 
            // Age_col
            // 
            this.Age_col.Text = "Age";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name.Location = new System.Drawing.Point(108, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(148, 27);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_surname.Location = new System.Drawing.Point(108, 60);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(148, 27);
            this.tb_surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            // 
            // tb_age
            // 
            this.tb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_age.Location = new System.Drawing.Point(108, 92);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(148, 27);
            this.tb_age.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_add.Location = new System.Drawing.Point(56, 134);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 29);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add to list";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_remove.Location = new System.Drawing.Point(163, 134);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(93, 29);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_update.Location = new System.Drawing.Point(108, 317);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 29);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Age:";
            // 
            // tb_selectedAge
            // 
            this.tb_selectedAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_selectedAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_selectedAge.Location = new System.Drawing.Point(108, 281);
            this.tb_selectedAge.Name = "tb_selectedAge";
            this.tb_selectedAge.Size = new System.Drawing.Size(148, 27);
            this.tb_selectedAge.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Surname:";
            // 
            // tb_selectedSurname
            // 
            this.tb_selectedSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_selectedSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_selectedSurname.Location = new System.Drawing.Point(108, 249);
            this.tb_selectedSurname.Name = "tb_selectedSurname";
            this.tb_selectedSurname.Size = new System.Drawing.Size(148, 27);
            this.tb_selectedSurname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name:";
            // 
            // tb_selectedName
            // 
            this.tb_selectedName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_selectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_selectedName.Location = new System.Drawing.Point(108, 216);
            this.tb_selectedName.Name = "tb_selectedName";
            this.tb_selectedName.Size = new System.Drawing.Size(148, 27);
            this.tb_selectedName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(64, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Selected item:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 358);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_selectedAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_selectedSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_selectedName);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.LV_persons);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_persons;
        private System.Windows.Forms.ColumnHeader Name_col;
        private System.Windows.Forms.ColumnHeader Surname_col;
        private System.Windows.Forms.ColumnHeader Age_col;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_selectedAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_selectedSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_selectedName;
        private System.Windows.Forms.Label label7;
    }
}

