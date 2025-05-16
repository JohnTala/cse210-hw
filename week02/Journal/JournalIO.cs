public static class JournalIO
    {
        public static void SaveToFile(string filename, List<Entry> entries)
        {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("==ENTRY==");
            }
        }
            

            Console.WriteLine("Journal saved.");
        }

        public static List<Entry> LoadFromFile(string filename)
        {
            List<Entry> loadedEntries = new List<Entry>();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return loadedEntries;
            }

            string[] lines = File.ReadAllLines(filename);
            Entry entry = new Entry();
            int lineCounter = 0;

            foreach (string line in lines)
            {
                if (line == "==ENTRY==")
                {
                    loadedEntries.Add(entry);
                    entry = new Entry();
                    lineCounter = 0;
                }
                else
                {
                    switch (lineCounter)
                    {
                        case 0: entry._date = DateTime.Parse(line); break;
                        case 1: entry._promptText = line; break;
                        case 2: entry._entryText = line; break;
                    }
                    lineCounter++;
                }
            }

            Console.WriteLine("Journal loaded.");
            return loadedEntries;
        }
    }

