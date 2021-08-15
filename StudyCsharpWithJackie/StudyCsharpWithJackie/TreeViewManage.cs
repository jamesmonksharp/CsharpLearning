using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCsharpWithJackie
{
    public class TreeViewManage
    {       
        public void AddNode(string NodeName, TreeView tw1)
        {
            //Đặt đk kiểm tra node đã tồn tại chưa
            bool doesNodeAlreadyExist = false;

            //Tìm các node trong danh sách treeview 
            foreach (TreeNode node in tw1.Nodes)
            {
                //Nếu mỗi node trong danh sách có text tên là == NodeName
                //NodeName là biến truyền vào
                if (node.Text == NodeName)
                {
                    //Set đk doesNodeAlreadyExist
                    doesNodeAlreadyExist = true;
                    //Ngắt
                    break;
                }
            }
            
            //Nếu biến doesNodeAlreadyExist = true 
            //Tức là đã có tồn tại tên node
            if (doesNodeAlreadyExist)
            {
                //Cảnh báo
                MessageBox.Show("Please Rename");
            }
            else
            {
                //Nếu chưa có tên node

                //Tạo 1 node mới
                TreeNode newTreeNode = new TreeNode();

                //Set tên cho node này bằng tên truyền vào NodeName
                newTreeNode.Text = NodeName;

                //Add vào tree view
                tw1.Nodes.Add(newTreeNode);

                //Set giá trị checkbox
                //newTreeNode.Checked = true;                
            }
        }

        public void AddChildNode(string ChildNodeName, TreeNode rootNode)
        {            
            //Kiểm tra rootnode tồn tại hay không
            if (rootNode != null)
            {           
                //Tồn tại thị tạo sub node
                TreeNode Subnode = new TreeNode();

                //Tên subnode là tên truyền vào từ ChildNodeName
                Subnode.Text = ChildNodeName;

                //Thêm childnode vào rootnode
                rootNode.Nodes.Add(Subnode);

                //Expand tree view ra
                rootNode.Expand();
            }
        }

        public void AddChildNodeSelected(string ChildNodeName, TreeNode selectedNode)
        {
            if (selectedNode != null)
            {
                TreeNode subNode = new TreeNode();
                subNode.Text = ChildNodeName;
                selectedNode.Nodes.Add(subNode);                
                selectedNode.Expand();
            }
        }

        public void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

    }
}
