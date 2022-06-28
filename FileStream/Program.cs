using System.Text;
using System.IO;
namespace Prn.StreamFileDemo;
public class Program
{
    public static void Main()
    {
        string msgData = "ABCDEF";
        // chuyển msgDAta -> stream( mảng 1 chiều của các bytes)
        // 
        byte[] data = Encoding.Default.GetBytes(msgData);
        // lưu data (bytes) vào file (mydata.dat)
        using FileStream fileStream = File.Open("mydata.dat", FileMode.Create);

        fileStream.Write(data, 0, data.Length);
        fileStream.Position = 0;
    }
}