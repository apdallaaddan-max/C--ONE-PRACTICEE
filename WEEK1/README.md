bewjcjew# Discourse chapter 1
# Week 1 - C# String Concatenation Practice

# Overview

This exercise walks through how to:

- Declare string variables
- Join two string values together
- Save the joined value into a separate variable
- Show the result using a Label control

---

## 1. Declaring Variables

Here, three string variables are set up to hold the user's name details:

- `FirstName` - holds the first name
- `SecondName` - holds the second name
- `FullName` - holds the finished name once the first and second names are merged

The screenshot below shows how these variables are declared in C#.

![CreatingVariables](Creating Variable.png)

```csharp
string FirstName, SecondName, FullName;
```

---

## 2. Joining the First Name and Second Name

At this stage, the first and second names are merged using the `+` operator.

A space `" "` is placed between the two values so the final output reads correctly.

The merged result is saved into the `FullName` variable.

The screenshot below illustrates this concatenation step.

![concatination](concate.png)
---

## 3. Showing the Full Name

Once the first and second names have been merged, the value held in `FullName` is displayed inside a Label control.

The label's `.Text` property is used to render the result on the Windows Form.

The screenshot below shows the full name being displayed.

![lblDisplay](DisplayOutput.png)