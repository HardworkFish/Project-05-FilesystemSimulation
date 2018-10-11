
namespace FileSystemSimulation
{
    public class FileNode
    {
        /// <summary>
        /// name 文件名
        /// type 文件类型
        /// attribute 文件属性
        /// block 文件起始块
        /// length 文件长度
        /// path 文件路径
        /// </summary>
        private string name;
        private string type;
        private string attribute;
        private byte block;
        private byte length;
        private string path;

        /// <summary>
        /// 无参构造方法
        /// </summary>
        public FileNode()
        {

        }

        /// <summary>
        /// FileNode 构造函数
        /// </summary>
        /// <param name="_name">文件名</param>
        /// <param name="_type">文件类型</param>
        /// <param name="_attribute">文件属性</param>
        /// <param name="_block">文件磁盘块</param>
        public FileNode(ref string _name, ref string _type, ref string _attribute,
            ref byte _block)
        {
            name = _name;
            type = _type;
            attribute = _attribute;
            block = _block;
        }


        /// <summary>
        /// 文件名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        /// <summary>
        /// 文件属性
        /// </summary>
        public string Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
            }
        }

        /// <summary>
        /// Block 文件起始块
        /// </summary>
        public byte Block
        {
            get
            {
                return block;
            }
            set
            {
                block = value;
            }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        /// <summary>
        /// Length 文件大小
        /// </summary>
        public byte Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
    }
}
