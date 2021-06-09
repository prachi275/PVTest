using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PVTest2021
{
    //public class Program
    //{
    //	static void Main(string[] args)
    //       {
    //           byte[] File = ReturnallTextformFile(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName.ToString(), "data\\testfile.txt").GetAwaiter().GetResult();

    //       }

    //       public static async Task<byte[]> ReturnallTextformFile(string filePath, string fileName)
    //	{
    //		byte[] _File = new byte[999999];
    //		//string result = string.Empty;
    //		try
    //		{
    //			FileStream fs = File.OpenRead(filePath + fileName);
    //			_File = new byte[fs.Length];
    //			UTF8Encoding temp = new UTF8Encoding(true);
    //			while(fs.Read(_File,0,_File.Length)>0)
    //               {
    //				Console.WriteLine(temp.GetString(_File));
    //               }
    //			//fs.Read(_File, 0, (int)fs.Length - 1);
    //		}
    //		catch (Exception ex)
    //		{
    //			Console.WriteLine(ex.ToString());

    //		}
    //		return _File;
    //	}
    //	//public static async Task<byte[]> ReturnallTextformFile(string p, string f)
    //	//{
    //	//	byte[] _File = new byte[999999];
    //	//	//string result = string.Empty;
    //	//	try
    //	//	{
    //	//		FileStream fs = File.OpenRead(p + f);
    //	//		fs.Read(_File, 0, (int)fs.Length - 1);
    //	//	}
    //	//	catch (Exception ex)
    //	//	{
    //	//		Console.WriteLine(ex.ToString());
    //	//		throw new Exception(ex.Message);
    //	//		return null;
    //	//	} return _File;
    //	//}
    //}



    public class ReturnAllTextFormFile
    {
        static void Main(string[] args)
        {
            ReturnAllTextFormFile r = new ReturnAllTextFormFile();
            ReturnallTextformFile(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName.ToString(), "\\data\\testfile.txt");

        }

        public static byte[] ReturnallTextformFile(string filePath, string fileName)
        {
            byte[] _File = new byte[999999];
            //string result = string.Empty;
            try
            {
                FileStream fs = File.OpenRead(filePath + fileName);
                _File = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(_File, 0, _File.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(_File));
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Exception Occured");

            }
            return _File;
        }

    }
}