using System;
using System.IO;

namespace OopsProject
{

    class Program
    {

        static void Main(string[] args)
        {
           

            // File likhna (Write)
            string filePath = @".\files\data.txt";

            // 1. File mein likhna
            File.WriteAllText(filePath, "Hello World!\nThis is second line.");

            // 2. File se padhna (Read)
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 3. File mein append karna (existing content ke end mein add karna)
            File.AppendAllText(filePath, "\nThis is appended text.");

            // 4. Check karna file exists hai ya nahi
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists!");
            }

            content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 5. File delete karna
            // File.Delete(filePath);
        }
    }
}