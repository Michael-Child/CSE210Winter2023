using System;

public class WrittenResponse
{
    public string question;
    public string write;
    public string date;
    public WrittenResponse(string question, string write, string date){
        this.question = question;
        this.write = write;
        this.date = date;
    } 
}