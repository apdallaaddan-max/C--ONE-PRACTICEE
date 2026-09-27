# Simple Number Adder (C# WinForms)

A basic Windows Forms Code that takes two numbers as input, adds them, and displays the result — with error handling .

## Features
- Accepts two numbers via text boxes
- Adds the values and displays the sum
- Catches invalid (non-numeric) input and shows a friendly error message

## How It Works
The Code follows a simple 3-stage process inside a `try/catch` :

1. **Create variables** — `int x, y, z;`
2. **Parse input** — reads and converts text box values to integers
3. **Process** — adds `x + y` and stores the result in `z`
4. **Output** — displays `z` in the result label

```csharp
try
{
    int x, y, z;

    x = int.Parse(txt1stnum.Text);
    y = int.Parse(txt2ndnum.Text);

    z = x + y;

    lbloutput.Text = z.ToString();
}
catch (Exception ex)
{
    MessageBox.Show("Please enter valid numbers. Error: " + ex.Message);
}


## Error Handling
If either input isn't a valid integer, `int.Parse()` throws an exception, which is caught and shown to the user via a `MessageBox`, instead of crashing the app.


## Usage
1. Enter a number in each text box
2. Click the "showNum" button
3. View the sum in the output label

as it shows The botoom photo 

[!lbloutput](tryandcatch.png)
