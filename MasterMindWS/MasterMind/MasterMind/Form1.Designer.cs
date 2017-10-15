namespace MasterMind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Black = new System.Windows.Forms.Button();
            this.Btn_Blue = new System.Windows.Forms.Button();
            this.Btn_Gray = new System.Windows.Forms.Button();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.Btn_Orange = new System.Windows.Forms.Button();
            this.Btn_Pink = new System.Windows.Forms.Button();
            this.Btn_Red = new System.Windows.Forms.Button();
            this.Btn_Yellow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Black
            // 
            this.Btn_Black.BackgroundImage = global::MasterMind.Properties.Resources.Black;
            this.Btn_Black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Black.Location = new System.Drawing.Point(12, 846);
            this.Btn_Black.Name = "Btn_Black";
            this.Btn_Black.Size = new System.Drawing.Size(75, 75);
            this.Btn_Black.TabIndex = 0;
            this.Btn_Black.Text = "black";
            this.Btn_Black.UseVisualStyleBackColor = false;
            this.Btn_Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Blue
            // 
            this.Btn_Blue.BackgroundImage = global::MasterMind.Properties.Resources.Blue;
            this.Btn_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Blue.ForeColor = System.Drawing.Color.Black;
            this.Btn_Blue.Location = new System.Drawing.Point(93, 846);
            this.Btn_Blue.Name = "Btn_Blue";
            this.Btn_Blue.Size = new System.Drawing.Size(75, 75);
            this.Btn_Blue.TabIndex = 1;
            this.Btn_Blue.Text = "blue";
            this.Btn_Blue.UseVisualStyleBackColor = false;
            this.Btn_Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Gray
            // 
            this.Btn_Gray.BackgroundImage = global::MasterMind.Properties.Resources.Gray;
            this.Btn_Gray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Gray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gray.ForeColor = System.Drawing.Color.Black;
            this.Btn_Gray.Location = new System.Drawing.Point(174, 846);
            this.Btn_Gray.Name = "Btn_Gray";
            this.Btn_Gray.Size = new System.Drawing.Size(75, 75);
            this.Btn_Gray.TabIndex = 2;
            this.Btn_Gray.Text = "gray";
            this.Btn_Gray.UseVisualStyleBackColor = false;
            this.Btn_Gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Green
            // 
            this.Btn_Green.BackgroundImage = global::MasterMind.Properties.Resources.Green;
            this.Btn_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Green.ForeColor = System.Drawing.Color.Black;
            this.Btn_Green.Location = new System.Drawing.Point(255, 846);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(75, 75);
            this.Btn_Green.TabIndex = 3;
            this.Btn_Green.Text = "green";
            this.Btn_Green.UseVisualStyleBackColor = false;
            this.Btn_Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Orange
            // 
            this.Btn_Orange.BackgroundImage = global::MasterMind.Properties.Resources.Orange;
            this.Btn_Orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Orange.ForeColor = System.Drawing.Color.Black;
            this.Btn_Orange.Location = new System.Drawing.Point(336, 846);
            this.Btn_Orange.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Orange.Name = "Btn_Orange";
            this.Btn_Orange.Size = new System.Drawing.Size(75, 75);
            this.Btn_Orange.TabIndex = 4;
            this.Btn_Orange.Text = "orange";
            this.Btn_Orange.UseVisualStyleBackColor = false;
            this.Btn_Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Pink
            // 
            this.Btn_Pink.BackgroundImage = global::MasterMind.Properties.Resources.Pink;
            this.Btn_Pink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Pink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Pink.ForeColor = System.Drawing.Color.Black;
            this.Btn_Pink.Location = new System.Drawing.Point(417, 846);
            this.Btn_Pink.Name = "Btn_Pink";
            this.Btn_Pink.Size = new System.Drawing.Size(75, 75);
            this.Btn_Pink.TabIndex = 5;
            this.Btn_Pink.Text = "pink";
            this.Btn_Pink.UseVisualStyleBackColor = false;
            this.Btn_Pink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Red
            // 
            this.Btn_Red.BackgroundImage = global::MasterMind.Properties.Resources.Red;
            this.Btn_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Red.ForeColor = System.Drawing.Color.Black;
            this.Btn_Red.Location = new System.Drawing.Point(498, 846);
            this.Btn_Red.Name = "Btn_Red";
            this.Btn_Red.Size = new System.Drawing.Size(75, 75);
            this.Btn_Red.TabIndex = 6;
            this.Btn_Red.Text = "red";
            this.Btn_Red.UseVisualStyleBackColor = false;
            this.Btn_Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // Btn_Yellow
            // 
            this.Btn_Yellow.BackgroundImage = global::MasterMind.Properties.Resources.Yellow;
            this.Btn_Yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Yellow.ForeColor = System.Drawing.Color.Black;
            this.Btn_Yellow.Location = new System.Drawing.Point(579, 846);
            this.Btn_Yellow.Name = "Btn_Yellow";
            this.Btn_Yellow.Size = new System.Drawing.Size(75, 75);
            this.Btn_Yellow.TabIndex = 7;
            this.Btn_Yellow.TabStop = false;
            this.Btn_Yellow.Text = "yellow";
            this.Btn_Yellow.UseVisualStyleBackColor = false;
            this.Btn_Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bacisColor_mouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 805);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(579, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(498, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(417, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(336, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "SCORE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(671, 933);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Yellow);
            this.Controls.Add(this.Btn_Red);
            this.Controls.Add(this.Btn_Pink);
            this.Controls.Add(this.Btn_Orange);
            this.Controls.Add(this.Btn_Green);
            this.Controls.Add(this.Btn_Gray);
            this.Controls.Add(this.Btn_Blue);
            this.Controls.Add(this.Btn_Black);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Black;
        private System.Windows.Forms.Button Btn_Blue;
        private System.Windows.Forms.Button Btn_Gray;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.Button Btn_Orange;
        private System.Windows.Forms.Button Btn_Pink;
        private System.Windows.Forms.Button Btn_Red;
        private System.Windows.Forms.Button Btn_Yellow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

