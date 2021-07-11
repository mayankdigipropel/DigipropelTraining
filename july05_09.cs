using System;
using System.IO;
 
class ConsoleApplication
{
    const string fileName = "AppSettings.dat"; // defining constant string
 
    static void Main()
    {
        WriteDefaultValues(); 
        DisplayValues();
    }
 
    public static void WriteDefaultValues()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
           
            writer.Write("current date and time : " + DateTime.Now.ToString());
           
        }
    }
 
    public static void DisplayValues()
    {
       
 
        if (File.Exists(fileName))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine(reader.ReadString());
                
            }
 
           
        }
    }
}
/*output : current date and time : 7/11/2021 12:16:17 PM