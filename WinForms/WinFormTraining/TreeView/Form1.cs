using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addNode_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("Node");
            treeView.Nodes.Add(node);
            node.Nodes.Add("Child", "test", 2);
        }

        private void btn_addNodes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nud_NodesNumber.Value; i++)
            {
                TreeNode node = new TreeNode("Parent" + (i + 1));

                for (int j = 0; j < nud_ChildsNumber.Value; j++)
                {
                    node.Nodes.Add("", "Child" + (j + 1), 1);
                }
                treeView.Nodes.Add(node);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lb_path.Text = "Path: " + treeView.SelectedNode.FullPath;
        }
    }
}
