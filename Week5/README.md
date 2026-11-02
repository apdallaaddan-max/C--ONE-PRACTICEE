//
Chapter5 Files = Files..
//

# File Handling in C#: Writing and Reading Text Files

## Overview

These examples use the System.IO namespace (add using System.IO; at the top of the form). StreamWriter writes text to a file, and StreamReader reads text from a file.

## Writing a File

**Steps:** open the file, write to it, close it.

    StreamWriter outputFile;

    outputFile = File.CreateText("index.txt");

    outputFile.WriteLine("Welcome to c#");
    outputFile.Write("Welcome to Apdulaahi");
    outputFile.WriteLine("Age is 24");

    MessageBox.Show("File Was Created..");

    outputFile.Close();

WriteLine adds the text and moves to a new line. Write adds the text and stays on the same line.

## Writing with a Save Dialog

The user chooses where to save the file.

    StreamWriter write;

    DialogResult result = SaveAs.ShowDialog();

    if (result == DialogResult.OK)
    {
        // Creating a new file and writing to it
        write = File.CreateText(SaveAs.FileName);
        write.WriteLine("Apdulaahi");
        write.Close();
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("You Have Canceled The File");
    }

## Reading with an Open Dialog

The user chooses which file to open.

    StreamReader reader;

    DialogResult result = OpenAs.ShowDialog();

    if (result == DialogResult.OK)
    {
        // Open the file using the selected path
        reader = File.OpenText(OpenAs.FileName);
        string readLines;
        readLines = reader.ReadLine();
        listBox1.Items.Add(readLines);
        reader.Close();
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("You Have Canceled The File");
    }

ReadLine reads one line per call, so this example loads only the first line of the file.

## Reading All Lines with Error Handling

A while loop reads until the end of the file. The try / catch block shows an error message if the file is missing or cannot be opened.

    try
    {
        StreamReader reader;
        reader = File.OpenText("courses.txt");

        while (reader.EndOfStream == false)
        {
            string line;
            line = reader.ReadLine();
            listBox1.Items.Add(line);
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
//


# Appending to a Text File in C#

## Overview

File.AppendText adds new text to the end of an existing file and keeps the old content. If the file does not exist, it is created.

## Example

    StreamWriter outputFile;

    outputFile = File.AppendText("index.txt");

    outputFile.WriteLine("Welcome Back to c#");
    outputFile.WriteLine("Age is 24");

    outputFile.Close();
.//