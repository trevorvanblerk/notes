using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> notes = new List<string>();

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("1. Add note");
            Console.WriteLine("2. View notes");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddNote();
                    break;
                case 2:
                    ViewNotes();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (choice != 3);
    }

    static void AddNote()
    {
    	Console.WriteLine();
        Console.WriteLine("Enter your note: ");
        string note = Console.ReadLine();
        notes.Add(note);
        Console.WriteLine();
        Console.WriteLine("Note added successfully.");
        Console.WriteLine();
    }

    static void ViewNotes()
    {
        if (notes.Count == 0)
        {
        	Console.WriteLine();
            Console.WriteLine("No notes to display.");
            Console.WriteLine();
        }
        else
        {
        	Console.WriteLine();
            for (int i = 0; i < notes.Count; i++)
            {   
                Console.WriteLine(notes[i]);
            }
            Console.WriteLine();
        }
    }
}
