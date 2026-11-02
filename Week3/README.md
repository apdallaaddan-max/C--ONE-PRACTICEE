# Student Grade Calculator

A C# Windows Forms app that takes three scores, calculates the average, and shows the grade.

## Grading Scale

| Average | Grade |
|---------|-----------|
| 90+ | Excellent |
| 80 – 89.9 | Very Good |
| 70 – 79.9 | Good |
| 60 – 69.9 | Pass |
| Below 60 | Fail |

## How It Works

1. Enter three scores in the text boxes.
2. Click the button to calculate the average.
3. The average and grade appear in the output label.
4. Invalid input shows an error message instead of crashing.

//
# ListBox Add and Remove

Three ways to work with items in a C# Windows Forms ListBox.

## 1. Add an item

    else
    {
        listBox1.Items.Add(average.ToString("0.0") + " Fail");
    }

Adds a new line at the end of listBox1, for example 48.3 Fail.

## 2. Remove an item by text

    listBox1.Items.Remove(average.ToString("0.0") + " Fail");

Removes the first item with exactly the same text. If nothing matches, nothing happens.

## 3. Remove the selected item

    else
{
        listBox1.Items.Remove(listBox1.SelectedItem);
    }

Removes the line the user clicked. If no item is selected, SelectedItem is null and this throws an error, so check first:

    if (listBox1.SelectedItem != null)
    {
        listBox1.Items.Remove(listBox1.SelectedItem);
    }
    else
    {
        MessageBox.Show("Please select an item to remove.");
    }

## Summary

| Code | Action |
|------|--------|
| Items.Add(x) | Adds x to the end of the list |
| Items.Remove(x) | Removes the first item equal to x |
| Items.Remove(listBox1.SelectedItem) | Removes the item the user selected |

//
# Input Validation: Age and Ticket Quantity

## Overview

Before any calculation, the application checks that the age and ticket values are within their allowed ranges. If a value is invalid, an error message is shown and the event handler exits.

## Validation Rules

| Field | Valid Range | Error Message |
|-------|-------------|---------------|
| Age (Personage) | 1 to 100 | Age must be between 1 and 100. |
| Tickets (ticket) | 1 to 5 | Tickets must be between 1 and 5. |

## Implementation

    if (Personage < 1 || Personage > 100)
    {
        MessageBox.Show("Age must be between 1 and 100.");
        return;
    }

    if (ticket < 1 || ticket > 5)
    {
        MessageBox.Show("Tickets must be between 1 and 5.");
        return;
    }
..