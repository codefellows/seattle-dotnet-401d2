using System;
using System.IO;
using System.Text;

namespace Class3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Final.txt";
            Console.WriteLine("Hello World!");

            CreateAFile(path);
            ReadAFile(path);
            UpdateFile(path);
            PracticeWithSplit();
            DeleteFile(path);


            //StreamReader - Text input from a file
            //StreamWriter - Text output to a file
            //FileStream - used alone for bytes with either StreamWriter or StreamReader for text. used foreither input or output to a file. 


        }

        static void CreateAFile(string path)
        {       

            //StreamWriter

            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    sw.Write("This is my file!!!");

                }
                catch (Exception e)
                {

                    throw;
                }
                finally
                {
                    sw.Close();
                }


            }

            using (FileStream fs = File.Create("Day3Text.txt"))
            {
                Byte[] worrdds = new UTF8Encoding(true).GetBytes("This is Day 3 of dotnet");
                fs.Write(worrdds, 0, worrdds.Length);
            }


        }


        static void UpdateFile(string path)
        {
            
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("I love cats");
            }
        }

        static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        static void ReadAFile(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    try
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Your file doesn't exist");
                    }
                    finally
                    {
                        Console.WriteLine("Write Process Complete ");

                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Process Complete");
            }

            string[] myWords = File.ReadAllLines(path);





            Console.WriteLine("Hello World");

        }

        static void PracticeWithSplit()
        {
            char[] delimiterChars = { ' ', ',', '.' , ':','\t'};

            string text = "one\ttwo three:four,five six.seven";

            string[] words = text.Split(delimiterChars);

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }

    }
}