class Math:Assignments
{
    private string _textBookSection = "";
    private string _problem = "";

    //lets use constructor with no argument
    public Math():base(){
    }

    //lets use constructor with no argument
    public Math(string studentName,string topic,string textBookSection, string problem) : base(studentName,topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }
    public string GetTextBookSection() {
        return _textBookSection;
    }
    public string GetProblem() {
        return _problem;
    }

    public void SetTextBookSection(string textBookSection) { 
          _textBookSection= textBookSection;
    }

    public void SetProblem(string problem) { 
        _problem= problem;
    }

    public string GetHomeworkList()
    {
        //return $"{_problem} {_textBookSection} {_topic} {_studentName}";
        return $"Section {_problem} Problems {_textBookSection} {GetTopic()} {GetStudentName()}";
    }

}
