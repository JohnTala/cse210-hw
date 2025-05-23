using System;

class ScriptureMemorizer
{
    static void Main(string[] args)
    {
        ScriptureMemorizer memorizer = new ScriptureMemorizer();
        memorizer.Scripture();
    }
    public void Scripture()
    {
        string reference = "Proverbs 3:5-6";
        string scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";


        List<Word> words = new List<Word>();
        string[] splitWords = scripture.Split(' ');//create an array to put the chunks of the all sentence(scripture)

        foreach (string w in splitWords)
        {
            Word word1 = new Word(w);  // create the Word object
            words.Add(word1);          // add it to the list
        }


        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference);

            foreach (Word w in words)
            {
                if (w.IsHidden())
                {
                    Console.Write(new string('_', w.GetWord().Length) + " ");
                }
                else
                {
                    Console.Write(w.GetWord() + " ");
                }
            }

            bool allHidden = true;
            foreach (Word w in words)
            {
                if (!w.IsHidden())
                {
                    allHidden = false;
                    break;
                }
            }

            if (allHidden)
            {
                Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;
            List<int> visibleIndexes = new List<int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (!words[i].IsHidden())
                {
                    visibleIndexes.Add(i);
                }
            }

            if (visibleIndexes.Count > 0)
            {
                int index = random.Next(visibleIndexes.Count);
                int wordIndex = visibleIndexes[index];
                words[wordIndex].Hide(); 
            }
        }
    }
}