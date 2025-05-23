    class Word
    {
        private string _text;
        private bool _isWordHidden;

        public Word(string text)
        {
            _text = text;
            _isWordHidden = false;
        }

        public string GetWord()
        {
            return _text;
        }

        public bool IsHidden()
        {
            return _isWordHidden;
        }

        public void Hide()
        {
            _isWordHidden = true;
        }

          
        
    }


