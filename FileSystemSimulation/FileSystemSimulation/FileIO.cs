using System.IO;
namespace FileSystemSimulation
{
    class FileIO
    {
        public static string filePath = "disk";

        public static void FileWritor(int offset, ref byte[] buffer)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filePath));
            bw.BaseStream.Seek(offset, SeekOrigin.Begin);
            bw.Write(buffer);
            bw.Flush();
            bw.Close();
        }

        public static void FileReader(int offset, ref byte[] buffer, int numOfByte)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(filePath));
            br.BaseStream.Seek(offset, SeekOrigin.Begin);
            buffer = br.ReadBytes(numOfByte);
            br.Close();
        }
        

    }
}
