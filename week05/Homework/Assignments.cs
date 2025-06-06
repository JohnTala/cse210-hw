 class Assignments
 {
     private string _studentName = "";
     private string _topic = "";

     // constructor with no argument
     public Assignments() {
         _studentName = "Anonymous";
         _topic = "Topic";
     }

     //constructor with arguments
     public Assignments(string studentName,string topic)
     {
         _studentName = studentName;
         _topic =topic;
     }

     //lets use get and set methods

     public string GetStudentName()
     {
         return _studentName;
     }
     public void SetStudentName(string studentName) {
         _studentName = studentName;
     }
     public string GetTopic() { 
         return _topic;
     }
     public void SetTopic(string topic) { 
       _topic = topic;
     }

     public string GetSummary()
     {
         return $"{_studentName} - {_topic}";
     }

 }
