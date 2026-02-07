using System;
using System.Windows.Forms;

namespace treeview_imagelist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            treeView1.AfterSelect += treeView1_AfterSelect;
            listView1.DoubleClick += listView1_DoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;

            TreeNode root = new TreeNode("Projects");
            root.ImageIndex = 0;
            root.SelectedImageIndex = 0;

            TreeNode projectA = new TreeNode("Project A");
            projectA.ImageIndex = 1;
            projectA.SelectedImageIndex = 1;

            TreeNode projectB = new TreeNode("Project B");
            projectB.ImageIndex = 1;
            projectB.SelectedImageIndex = 1;

            root.Nodes.Add(projectA);
            root.Nodes.Add(projectB);

            treeView1.Nodes.Add(root);
            root.Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            if (e.Node.Text == "Project A")
            {
                listView1.Items.Add("Task A1");
                listView1.Items.Add("Task A2");
            }
            else if (e.Node.Text == "Project B")
            {
                listView1.Items.Add("Task B1");
                listView1.Items.Add("Task B2");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            string text = listView1.SelectedItems[0].Text;

            DialogResult result = MessageBox.Show(
                "Do you want to select " + text + "?",
                "Confirmation",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Selected: " + text);
            }
        }
    }
}
