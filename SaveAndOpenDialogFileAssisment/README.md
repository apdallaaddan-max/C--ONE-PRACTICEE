# Save and Open Dialog File Assignment

A C# Windows Forms application that shows how to **create, append, read and clear** text files using SaveFileDialog and OpenFileDialog.

## Features

- **Create a new file**: choose a file name with a Save dialog and write a first line to it.
- **Append to a file**: type a name in the textbox and add it to the end of an existing file without deleting the old data.
- **Read a file**: choose a file with an Open dialog and show every line in the listbox.
- **Clear the listbox**: empties the screen only. The file is not changed.

// 

//

## How It Works

### Create a file
1.Save.ShowDialog() shows the Save window.
2. If the user clicks Save, File.CreateText(Save.FileName)`creates the file.
3. WriteLine("Apdulaahi") writes the first line, then Close() closes the file.
4. If the user cancels, a message is shown.

### Read a file
1. OpenFile.ShowDialog() shows the Open window.
2. File.OpenText(OpenFile.FileName) opens the file for reading.
3. A while (reads.EndOfStream == false) loop reads each line with ReadLine() and adds it to listBox1.

### Append to a file
1. The program checks that txtName is not empty.
2. Save.ShowDialog() lets the user choose the file.
3. File.AppendText(Save.FileName) opens the file in append mode, so old data stays.
4. WriteLine(txtName.Text) adds the new name at the end, then the textbox is cleared.

### Clear
* ListBox1.Items.Clear() removes the lines from the screen only. The saved file keeps all its data.

## Error Handling

Each file operation is wrapped in try / catch, so a problem (for example a locked file) shows a message box instead of crashing the program.

## How to Run

1. Open the project in **Visual Studio**.
2. Press **F5** (Start).
3. Test in this order:
   1. Click the create button and name the file data.txt.
   2. Type a name in the textbox, click **Append**, and choose the same data.txt.
   3. Click **Clear**. The listbox is empty but the file is safe.
   4. Click the read button and choose data.txt. All lines appear again.