using System;

class Program
{
    static void Main(string[] args)
    {
        // Person person = new Person();
        // person._givenName = "Joseph";
        // person._familyName = "Smith";
        // person.ShowWesternName();
        // person.ShowEasternName();

        // Person person1 = new Person();
        // person1._givenName = "Emma";
        // person1._familyName = "Smith";
        // person1.ShowWesternName();

        // Person person2 = new Person();
        // person2._givenName = "Joseph";
        // person2._familyName = "Smith";
        // person2.ShowWesternName();

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer Manager";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Job job3 = new Job();
        job3._company = "Tiktok";
        job3._jobTitle = "Software Engineer Senior Manager";
        job3._startYear = 2020;
        job3._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "John Cina";
        resume._jobs = new List<Job>{job1, job2, job3};

        resume.ShowName();
        resume.ShowJobs();
    }
}
public class Person
{
    public string _givenName = "";
    public string _familyName = "";
    public Person(){}
    public void ShowEasternName(){
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
    public void ShowWesternName(){
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public Job(){}

    public void ShowCompany(){
        Console.WriteLine($"{_company}");
    }
    public void ShowJobTitle(){
        Console.WriteLine($"{_jobTitle}");
    }
    public void ShowStartYear(){
        Console.WriteLine($"{_startYear}");
    }
    public void ShowEndYear(){
        Console.WriteLine($"{_endYear}");
    }

    public void ShowJob(){
        Console.WriteLine($"Job: {_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    public Resume(){}
    public void ShowName(){
        Console.WriteLine($"Name: {_name}");
    }
    public void ShowJobs(){
        foreach(Job jobs in _jobs){
            jobs.ShowJob();
        }
    }
}