// public class Entry
// {
//     // public string _date;
//     // public string _promptText;
//     // public string _entryText;

//     // public void Display()
//     // {

//     //     Console.WriteLine($"Date:{_date} -Prompt:{_promptText} ");
//     //     _entryText = Console.ReadLine();

//     // }
    
//     public DateTime Date { get; set; }
//     public string Content { get; set; }

//     public override string ToString()
//     {
//         return $"{Date:G}\n{Content}\n";
//     }
// }

public class Entry
    {
        public string _promptText { get; set; }
        public string _entryText { get; set; }
        public DateTime  _date { get; set; }

        public override string ToString()
        {
            return $"{_date.ToShortDateString()} - Prompt: {_promptText}\nResponse: {_entryText}\n";
        }
    }