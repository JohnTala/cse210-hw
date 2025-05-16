
using System;
using System.Collections.Generic;
using System.IO;
public class Journal

{
    // public List<Entry> _entries;
    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();

    public void WriteNewEntry()
    {
        string promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {promptText}");
        Console.Write("Your response: ");
        string entryText = Console.ReadLine();

        Entry entry = new Entry
        {
            _promptText = promptText,
            _entryText = entryText,
            _date = DateTime.Now
        };

        entries.Add(entry);
        Console.WriteLine("Entry saved.");
    }

    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void SetEntries(List<Entry> newEntries)
    {
        entries = newEntries;
    }

}