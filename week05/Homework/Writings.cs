    class Writings:Assignments
    {
        private string _title = "";


        //lets import base constructor and use it with no argument
        public Writings() : base()
        {
        }

        //lets import base constructor and use it with multiple arguments
        public Writings(string title, string topic,string studentName): base(topic,studentName)
        {
            _title = title;
        }

        public string GetTitle() {
            return _title;
        }
        public void SetTitle(string title) {
            _title = title;
        
        } 
        public string GetWritingInfo()
        {
            return $"{_title} by {GetStudentName()}";
        }
    }
