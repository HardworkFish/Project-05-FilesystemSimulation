using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemSimulation
{
    /// <summary>
    /// 文件操作
    /// </summary>
    class FileOption
    {   
        /// <summary>
        /// 新建目录
        /// </summary>
        public static void NewDir(ref string name)
        {
            
            byte[] buffer = new byte[64];//缓冲区
            char[] bufferToChar = new char[64];
            string bufferToString;//将缓冲区的内容转换为字符串
            FileNode currentDirNode = FormMain.CurrentDirNodeList[FormMain.CurrentDirNodeList.Count - 1];   //获取列表的最后一个元素的节点信息
            FileIO.FileReader(( currentDirNode.Block * 64), ref buffer, 64);//读取节点内容
            bufferToChar = ASCIIEncoding.ASCII.GetChars(buffer);//转换bytes[]为char[]
            //判断是否重名
            for (int i = 0; i < 8; i++)
            {
                bufferToString = new string(bufferToChar);  
                //读入名称
                string temp = bufferToString.Substring(i * 8, 3);
                //删除'\0'符号
                for (int j = 0; j < 3; j++)
                {
                    if (temp[j] == '\0')
                    {
                        //当发现了第一个'\0'就把该位置后的所有'\0'都删去
                        temp = temp.Remove(j);
                        break;
                    }
                }
                //
                if (name == temp && buffer[i * 8 + 5] == 8)
                {
                    MessageBox.Show("错误：与现有目录重名", "新建目录错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //判断block内是否有可以存放node的空间并写入
            for (int i = 0; i < 8; i++)
            {
                bufferToString = new string(bufferToChar);
                //判断当前节点是否为空
                if (bufferToString.Substring(i * 8 + 5, 1) == "\0")
                {
                    //若当前节点为空则录入node的信息到节点去
                    //录入节点信息
                    string s = null;//构造一个string用于存放节点信息，每个字符对应节点每个字节
                    s = s + name;//名字
                    if (name.Length < 3)
                    {
                        for (int j = name.Length; j < 3; j++)
                        {
                            s = s + '\0';
                        }
                    }
                    s = s + '\0' + '\0';//类型
                    s = s + (char)8;//属性
                    //获得空的盘块并写入起始盘块号
                    byte[] fatBytes = new byte[128];
                    FileIO.FileReader( 0,ref fatBytes, 128);
                    for (int j = 0; j < 128; j++)
                    {
                        if (fatBytes[j] == 0)
                        {
                            //找到空余盘块
                            s = s + (char)j;//起始盘块号
                            s = s + '\0';//文件大小
                            //修改FAT表
                            byte[] FATValue = new byte[1] { 0xff };
                            FileIO.FileWritor(j, ref FATValue);
                            //将节点写入块
                            byte[] byteinfo = new byte[8];
                            byteinfo = Encoding.ASCII.GetBytes(s);//将构造的string转换为byte数组，用于写入磁盘文件
                            FileIO.FileWritor((currentDirNode.Block* 64) + (i * 8), ref byteinfo);
                            //结束
                            return ;
                        }
                    }
                    continue;
                }
            }
        }

        /// <summary>
        /// 删除目录或文件
        /// </summary>
        /// <param name="name">目录或文件名</param>
        public static void DelFile()
        {

        }

        /// <summary>
        /// 新建文件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="attribute"></param>
        public static void NewFile(ref string name, ref string type, ref string attribute)
        {
           
            byte[] buffer = new byte[64];
            FileNode currentDirNode = FormMain.CurrentDirNodeList[FormMain.CurrentDirNodeList.Count - 1];
            
        }

        /// <summary>
        /// 显示文件内容
        /// </summary>
        public static void ShowFileContent()
        {

        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <returns></returns>
        public static void WriteFile()
        {
            
        }

    }
}
