## Creating File:
* Try: Starts code that might run into an error.
* StreamWriter Files; Creates a variable that will write text to a file.
* File.CreateText("Index.txt"): Creates Index.txt. If that file - Already exists, its old contents are replaced.
* Each Files.WriteLine(...): Writes text followed by a new line.
* Files.Close(): Closes the file and finishes writing.
* Catch (Exception ex): Runs if an error occurs, such as a *- --problem creating or writing the file.
* MessageBox.Show(ex.Message): Displays the error.
//


## Reading The File:
* lstResult.Items.Clear(): Removes any items already shown.
* File.ReadAllLines("Index.txt"): Puts every line from the file into a string array named Read.
* Foreach: Goes through the array one line at a time. The --current line is stored in Line.
* lstResult.Items.Add(Line): Allows You to See Your Text in the File  in to the ListBox.
//


## Deleting Selected Item:
* This Code is: checks whether an item is selected.
* If You Are Not Selected Item It Shows You ("You Have To Selected An  Item.") Instead Of Crashing..
* if You Select An Item It Will Remove From Your ListBox.
* Note: It Will Not Remove You File ..
//

## Deleting File..
* File.Exists("Index.txt") checks whether the file exists.
* If it exists, File.Delete("Index.txt") deletes it.
* lstResult.Items.Clear() clears The items displayed in the ListBox.
* MessageBox.Show(...) displays a success message.
* If the file doesn’t exist, the else block displays “File Not Found.”
* catch displays an error message if an operation fails.

