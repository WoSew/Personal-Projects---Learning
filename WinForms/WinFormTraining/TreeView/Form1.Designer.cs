namespace TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_Nodes = new System.Windows.Forms.Label();
            this.nud_NodesNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_addNode = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.nud_ChildsNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addNodes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NodesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ChildsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView.ImageIndex = 3;
            this.treeView.ImageList = this.imageList1;
            this.treeView.ItemHeight = 25;
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView.SelectedImageIndex = 2;
            this.treeView.Size = new System.Drawing.Size(461, 267);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            // 
            // lb_Nodes
            // 
            this.lb_Nodes.AutoSize = true;
            this.lb_Nodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Nodes.Location = new System.Drawing.Point(489, 12);
            this.lb_Nodes.Name = "lb_Nodes";
            this.lb_Nodes.Size = new System.Drawing.Size(142, 20);
            this.lb_Nodes.TabIndex = 1;
            this.lb_Nodes.Text = "Number of nodes:";
            // 
            // nud_NodesNumber
            // 
            this.nud_NodesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_NodesNumber.Location = new System.Drawing.Point(493, 44);
            this.nud_NodesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_NodesNumber.Name = "nud_NodesNumber";
            this.nud_NodesNumber.Size = new System.Drawing.Size(119, 27);
            this.nud_NodesNumber.TabIndex = 2;
            this.nud_NodesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addNode
            // 
            this.btn_addNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addNode.Location = new System.Drawing.Point(493, 174);
            this.btn_addNode.Name = "btn_addNode";
            this.btn_addNode.Size = new System.Drawing.Size(119, 30);
            this.btn_addNode.TabIndex = 3;
            this.btn_addNode.Text = "Add node";
            this.btn_addNode.UseVisualStyleBackColor = true;
            this.btn_addNode.Click += new System.EventHandler(this.btn_addNode_Click);
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_path.Location = new System.Drawing.Point(12, 293);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(58, 25);
            this.lb_path.TabIndex = 4;
            this.lb_path.Text = "Path:";
            // 
            // nud_ChildsNumber
            // 
            this.nud_ChildsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_ChildsNumber.Location = new System.Drawing.Point(493, 122);
            this.nud_ChildsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_ChildsNumber.Name = "nud_ChildsNumber";
            this.nud_ChildsNumber.Size = new System.Drawing.Size(119, 27);
            this.nud_ChildsNumber.TabIndex = 6;
            this.nud_ChildsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(489, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of childs:";
            // 
            // btn_addNodes
            // 
            this.btn_addNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addNodes.Location = new System.Drawing.Point(493, 228);
            this.btn_addNodes.Name = "btn_addNodes";
            this.btn_addNodes.Size = new System.Drawing.Size(119, 30);
            this.btn_addNodes.TabIndex = 7;
            this.btn_addNodes.Text = "Add nodes";
            this.btn_addNodes.UseVisualStyleBackColor = true;
            this.btn_addNodes.Click += new System.EventHandler(this.btn_addNodes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 331);
            this.Controls.Add(this.btn_addNodes);
            this.Controls.Add(this.nud_ChildsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.btn_addNode);
            this.Controls.Add(this.nud_NodesNumber);
            this.Controls.Add(this.lb_Nodes);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_NodesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ChildsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label lb_Nodes;
        private System.Windows.Forms.NumericUpDown nud_NodesNumber;
        private System.Windows.Forms.Button btn_addNode;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.NumericUpDown nud_ChildsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addNodes;
        private System.Windows.Forms.ImageList imageList1;
    }
}

