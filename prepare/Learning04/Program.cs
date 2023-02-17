using System;

class Program{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Michael Child", "Math");
        Console.WriteLine(a1.GetSummary());
        MathAssignment a2 = new MathAssignment("Jimmy Nutron", "Nucluer Math", "7.3", "1-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        WritingAssignment a3 = new WritingAssignment("One Punch", "The Secret to Ultimate Power", "100 Push Ups & Sit Ups");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}

class Assignment{
    protected string _student;
    protected string _topic;

    public Assignment(string student, string topic){
        _student = student;
        _topic = topic;
    }

    public string GetSummary(){
        return $"{_student} - {_topic}";
    }
}

class MathAssignment: Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string student, string topic, string textbookSection, string problems):  base(student, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"{_textbookSection} Problems:  {_problems}";
    }
}

class WritingAssignment: Assignment{
    private string _title;

    public WritingAssignment(string student, string topic, string title): base(student, topic){
        _title = title;
    }

    public string GetWritingInformation(){
        return $"{_title}";
    }
}