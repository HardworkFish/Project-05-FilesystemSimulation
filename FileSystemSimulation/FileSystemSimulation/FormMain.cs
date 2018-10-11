using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemSimulation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeCurrentDir();
        }

        public static List<FileNode> CurrentDirNodeList = new List<FileNode>();
        public static List<FileNode> OpenFileList = new List<FileNode>();

        // 初始化目录结构
        private void InitializeCurrentDir()
        {
            FileNode rootNode = new FileNode
            {
                Name = "/",
                Block = (byte)0x02
            };
            CurrentDirNodeList.Add(rootNode);
            currentDirlabel.Text = "当前路径: " + rootNode.Name;

        }


        /// <summary>
        /// 著作权说明 CopyRight 窗口点击事件
        /// </summary>
        private void CopyRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCopyRight box = new FormCopyRight();
            box.ShowDialog();
        }


        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
