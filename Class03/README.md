# ![cf](http://i.imgur.com/7v5ASc8.png) Class 03

## Learning Objectives
1. The Student will be able to successfully Create, Read, and Update a text file using the System.IO library
1. The students will implement concurrency into their programs to show performance improvement.
1. Students will know and understand the purpose of the using statements when connecting to an external location.

## Lecture Outline

### System.IO

1. Let's talk about file manipulation...
   1. What is File Manipulation
   1. How would we access an external file?
      1. What is System.IO
      1. Set the path in a string: 
         ```csharp 
            string path = @"Full\Path\to\File.txt";
         ```

1. **System I.O Library**
- The `File` class is a built in class library inside C#. You can get all types of information about the file from this object.
- Directory is similiar. 

#### Stream
- A stream is a sort of pipeline or channel of bytes flowing through your program.
- A stream is an object, and like all objects streams have data and methods. the methods allow you to performa actions such as opening, closing, and flushing (clearing) the stream. 

1. *StreamReader* - Text input from a file
2. *StreamWriter* - text output to a file
3. *FileStream* -  used alone for bytes with either StreamReader and StreamWriter for text. used for either input or output to a file. 
 
   1. Create an external text file
      1. Declare where your file will be created
         ```csharp 
            string path = @"Full\Path\to\File.txt";
         ```
      1. if the file doesn't exists...let's create it:
         ```csharp
           using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("List of Words in File");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
         ```

   1. Scenario #2: File Already exists, not i jsut need to find and read it in! 
      1. Read the file in
       ```csharp
        using (StreamReader sr = File.OpenText(path))
        {
           string s = "";
           while ((s = sr.ReadLine()) != null)
           {
             Console.WriteLine(s);
            }
        }
         ```
      -OR-
    ```csharp
     string[] worrds = File.ReadAllLines(path);
    ```

      1. Write to the end of a file:
           ```csharp
                    using (StreamWriter sw = File.AppendText(path))
                    {
                      sw.WriteLine(word);
                    }
         ```    
      1. Delete a file:
         ```csharp
            File.Delete(completePath);
            ```
      1. Copy a file from one location to another
         ```csharp
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath =  @"C:\Users\Public\TestFolder\SubDir";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            
           // Will not overwrite if the destination file already exists.
            File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));

           ```
   
1. **Arrays & Reading File Contents**
   1. Why do we need to use arrays?
   1. `Split()` your file
       1. Read by lihe vs splitting by a deliminator
          1. ``char[] delimiterChars = { ' ', ',', '.', ':', '\t' };``
          
                ```csharp
                string text = "one\ttwo three:four,five six seven";
                string[] words = text.Split(delimiterChars);
                ```


## Readings
1. [File and Stream I/O](https://docs.microsoft.com/en-us/dotnet/standard/io/index)
1. [Write to a file](https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file)
1. [Read to a file](https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-read-and-write-to-a-newly-created-data-file)


## Code Challenge 03
Josie Cat has 2 types of plants she would like to plant; cat nip, and mint.
She would like to alternate each of these plants within 5 columns and 5 rows. <br /><br />

`x x x x x
y y y y y
x x x x x
y y y y y 
x x x x x`

`x y x y x
y x y x y
x y x y x
y x y x y
x y x y x`