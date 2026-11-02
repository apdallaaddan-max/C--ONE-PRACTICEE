# Loops in C#: for, while, and do...while

## Overview

Loops repeat a block of code. Choose the loop based on how the repetition should be controlled.

## for Loop

Use when the number of repetitions is known.
for (int i = 1; i <= 5; i++)
{
    listBox1.Items.Add("Ticket " + i);
}
## while Loop

Use when repeating until a condition becomes false. The condition is checked before each run, so the body may not run at all.

int i = 1;
while (i <= 5)
{
    listBox1.Items.Add("Number " + i);
    i++;
}

## do...while Loop

Use when the code must run at least once. The condition is checked after the body.

int i = 1;
do
{
    listBox1.Items.Add("Number " + i);
    i++;
} while (i <= 5);

