

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