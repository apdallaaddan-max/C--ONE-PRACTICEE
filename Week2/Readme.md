# Topics
* 3.1 Reading Input with TextBox Controls
* 3.2 A First Look at Variables
* 3.3 Numeric Data Type and Variables
* 3.4 Performing Calculations
* 3.5 Inputting and Outputting Numeric Values
* 3.6 Formatting Numbers with the ToString Method
* 3.7 Simple Exception Handling
* 3.8 Using Named Constants
* 3.9 Declaring Variables as Fields
* 3.10 Using the Math Class
* 3.11 More G U I Details
* 3.12 Using the Debugger to Locate Logic Errors

||

# 3.1 Reading Input with TextBox Controls:
-A TextBox control’s Text property stores the user inputs
* The default Textbox Name is TextBoxn
Where N Can be= 1,2,3,4,5... 
* TextBox1,TextBox2,TextBox3,....
-Text property accepts only string values, e.g.
    -textBox1.Text = "Hello";
-To clear the content of a TextBox control You can use These ways:
    -textBox1.Text = "";
    -textBox1.Text = string.Empty;
    -textBox1.Clear();

||

# 3.2 A First Look at Variables:
-A variable is the storage location in the memory And the variable Name represents in the Memory Location.
-In C# you must declare A variable in a program Before using it to store data.
- The syntax to declare variable is:
    _ DataType VariableName;
-String Variables: Is the combination of Characteristics such as names And phone numbers.
- To display string variable you use:
    -MessageBox.Show();
-String Concatenation: Is the appending of one string to the end of another string.
    -To use string Concatenation:
        - in the C# The + operator is used for concatenation.
-Local variable: belongs to the method
    -Only statements inside that methods can access the variable.
-You Can't Declare two variables with the same name in the scope.
-Only strings are compatible with the string data type.

||

# 3.3 Numeric Data Type and Variables:
-If you need to store number in variable and use the number in mathemathical operation, The variable must be a numeric data type Like:
    Int:;
    Double;
    Decimal;

Explicit Conversion with Cast Operators:
-C# allows you to explicity convert among types which is known us TYPE CASTING.
-You can use the castOperator Like:
    *Int __> Int:
    *Double___> Int, Double:
    *Decimal___> Int, Decimal;
    *String__> String;

||

# 3.4 Performing Calculations:

| Operator | Name           | Description                              |
|----------|----------------|------------------------------------------|
| +        | Addition       | Adds two numbers                         |
| -        | Subtraction    | Subtracts one number from another        |
| *        | Multiplication | Multiplies one number by another         |
| /        | Division       | Divides one number by another            |
| %        | Modulus        | Divides one number by another(reminder)  |
||

# 3.6 Formatting Numbers with the ToString Method:

-IF you Divide Two Num and You get Alot Of Numbers like 1.777774   And you Wanna take only 2 or 3 Digit you can use:`ToString("F2")` to control decimal places. Like:
F2: 3.33
F3: 3.333
* Set the number you Wanna .


||

# 3.7 Simple Exception Handling:
-An exception is an unexpected error at runtime (e.g., entering text where a number is expected). Use try/catch so the program doesn't crash. Use:

try
{
    int age = int.Parse(textBox1.Text);
}
catch (Exception ex)
{
    MessageBox.Show("Enter a valid number.");
}

## Instructor / Coordinator:
**Yahye Ali Isse**
Department of Computer Application
Faculty of Computer & Information Technology
Jamhuriya University of Science & Technology..

    

