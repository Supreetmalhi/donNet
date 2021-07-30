using System;
using System.IO;
namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.WriteAndReadFile();
            Console.ReadLine();
        }
    
    
        public void WriteAndReadFile()
        {

            Console.WriteLine("Please enter number");
            int Number = Convert.ToInt32(Console.ReadLine());
            FileStream fileStream = new FileStream("New.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
         
            fileStream.WriteByte((byte)Number);
            fileStream.Position=0;
            Console.WriteLine("Your Number is " + fileStream.ReadByte());
            fileStream.Close();
        }
    }
}
