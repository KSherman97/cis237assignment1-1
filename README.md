# Assignment 1 - Review of C# Basic Concepts and Introduction to Git

## Due 01-25-2017

## Author
Kyle Sherman


## Description

Create a C# console program to work with a .CSV wine list. The program should continually run until the user decides to exit (entering a certain character on the keyboard). The program should allow the following functionality:

1. Allow the user to load the wine list from the provided CSV file. They should only be able to load the list once.
2. Allow the user to print the entire list of items.
3. Allow the user to search for an item by the item id, and print out the item if found. Error message if not. (Linear search is fine)
4. Allow the user to add a new wine item to the list.

Create a basic class called WineItem. This class should have the following variables, properties, constructors, methods, etc.
* Variables: id, description, pack
* Constructors: default, 3 parameter constructor
* Public Methods: ToString (Override)
* Private Methods: Your choice

Create a basic class called WineItemCollection. This class should have the following variables, properties, constructors, methods, etc.
The purpose of this class is to act as a 'wrapper' class for the array. This means that it should contain an array to hold WineItems, and provide public methods to interact with the array. EX: Add, Search, GetPrintString. If you have questions about this class, ask.
* Variables: wineItems (Array of type WineItem. It must be an array. No List)
* Constructors: Your choice
* Public Methods: Add, Search, GetPrintString
* Private Methods: Your choice

Create a basic class called User Interface. This class should be implemented however you see fit. It should handle all of the Screen input and output for the program. (With the exception of 'exception messages caused by a catch in a try/catch')

Create a basic class called CSVProcessor. This class should be in charge of reading in a CSV file and creating the item list. It may also want to handle ensuring the CSV can only be read in once.

Documentation should include the following for this, and all future assignments:
* Comments at the top of each source code file with:
  * Your Name
  * Class
  * Date
* A comment at the top of each method describing what it does.
* Comments in the rest of the code where it isn't obvious what is going on.

Solution Requirements:

* 5 classes (Program, WineItem, WineItemCollection, CSVProcessor, UserInterface)
* A loop
* An control structure (if/then statement, switch statement)
* An array [contents will be type WineItem]
* At least one method/function. (The main method is not included in this count)

### Notes
Even though you are free to write this however you would like within the constraints layed out above in the requirements, try to follow the single responsibility principle. I would suggest that you should attempt to make the User Interface handle the UI, the WineItem and WineItemCollection handle representing the data, CSVProcessor handle obtaining the data, and the Program/Main handle orchestrating all of it.

Try to send any dependencies into a class via either a constructor, or a method rather than creating a new one in the class. This is less of a concern for the classes that are obviously related. It is fine for WineItemCollection to create a new WineItem since they are clearly related. The goal is to future proof the program. Think of what if cases such as the following:
* What if we wanted to change out the User Interface with a different one? How much work would need to be done to fix it?
* What if instead of reading from a CSV file we wanted to start reading from a database? How much work would need to be done to fix it?

Suggestion/Hints:

* Displaying a menu to the screen might be helpful. (Also, redisplaying the menu after various actions might be helpful).
* How the user enters the information is your choice (i.e., one at a time, all at once, etc.).
* You might need multiple loops, methods, control structures – just depends on your design. However, you must have a least one of each.
* Remember to handle the case when the user has entered no information. You can print a simple message (i.e., “No data entered” or something else). It just needs to be obvious to the user that something has happened.
* Remember to handle (gracefully) cases where the user enters something incorrectly.

## Grading
| Feature             | Points |
|---------------------|--------|
| Load CSV            | 10     |
| Load CSV Only Once  | 5      |
| Print List          | 10     |
| Search              | 10     |
| Add New Item        | 10     |
| ToString Override   | 10     |
| CSV Processor Class | 5      |
| UserInterface       | 5      |
| WineItem            | 5      |
| WineItemCollection  | 5      |
| A Loop              | 5      |
| Control Structure   | 5      |
| WineItem Array      | 5      |
| A Method            | 5      |
| Documentation       | 5      |
| **Total**           | **100**|

## Outside Resources Used
None

## Known Problems, Issues, And/Or Errors in the Program
No known errors
