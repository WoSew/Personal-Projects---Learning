namespace SplitContainer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_AddOne = new System.Windows.Forms.Button();
            this.btn_AddMany = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_HidePanel_1 = new System.Windows.Forms.Button();
            this.btn_HidePanel_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(562, 368);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_AddOne);
            this.flowLayoutPanel1.Controls.Add(this.btn_AddMany);
            this.flowLayoutPanel1.Controls.Add(this.btn_HidePanel_2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 644);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_HidePanel_1);
            this.splitContainer2.Size = new System.Drawing.Size(410, 368);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_AddOne
            // 
            this.btn_AddOne.Location = new System.Drawing.Point(3, 3);
            this.btn_AddOne.Name = "btn_AddOne";
            this.btn_AddOne.Size = new System.Drawing.Size(145, 40);
            this.btn_AddOne.TabIndex = 0;
            this.btn_AddOne.Text = "Add one";
            this.btn_AddOne.UseVisualStyleBackColor = true;
            this.btn_AddOne.Click += new System.EventHandler(this.btn_AddOne_Click);
            // 
            // btn_AddMany
            // 
            this.btn_AddMany.Location = new System.Drawing.Point(3, 49);
            this.btn_AddMany.Name = "btn_AddMany";
            this.btn_AddMany.Size = new System.Drawing.Size(145, 40);
            this.btn_AddMany.TabIndex = 1;
            this.btn_AddMany.Text = "Add many";
            this.btn_AddMany.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(408, 49);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btn_HidePanel_1
            // 
            this.btn_HidePanel_1.Location = new System.Drawing.Point(116, 131);
            this.btn_HidePanel_1.Name = "btn_HidePanel_1";
            this.btn_HidePanel_1.Size = new System.Drawing.Size(159, 33);
            this.btn_HidePanel_1.TabIndex = 1;
            this.btn_HidePanel_1.Text = "Hide Panel 1";
            this.btn_HidePanel_1.UseVisualStyleBackColor = true;
            this.btn_HidePanel_1.Click += new System.EventHandler(this.btn_HidePanel_1_Click);
            // 
            // btn_HidePanel_2
            // 
            this.btn_HidePanel_2.Location = new System.Drawing.Point(3, 95);
            this.btn_HidePanel_2.Name = "btn_HidePanel_2";
            this.btn_HidePanel_2.Size = new System.Drawing.Size(142, 33);
            this.btn_HidePanel_2.TabIndex = 2;
            this.btn_HidePanel_2.Text = "Hide Panel 2";
            this.btn_HidePanel_2.UseVisualStyleBackColor = true;
            this.btn_HidePanel_2.Click += new System.EventHandler(this.btn_HidePanel_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 368);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_AddOne;
        private System.Windows.Forms.Button btn_AddMany;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_HidePanel_2;
        private System.Windows.Forms.Button btn_HidePanel_1;
    }
}

