using System;

public class Scripture{

    private string _author = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int _endVerse = 0;
    private List<Word> _words = new List<Word>();
    private Random randomGenerator = new Random();
    private int num = 0;
    public Scripture(string _author, int _chapter, int _startVerse, int _endVerse, string _words){
        this._author = _author;
        this._chapter = _chapter;
        this._startVerse = _startVerse;
        this._endVerse = _endVerse;
        _words.Split();
    }

//Author Functions:
    public string GetAuthor(){
        return this._author;
    }
    public void SetAuthor(string author){
        _author = author;
    }
//Start Chapter Functions:
    public int GetChapter(){
        return this._chapter;
    }
    public void SetChapter(int chapter){
        _chapter = chapter;
    }

//Start Verse Functions:
    public int GetStartVerse(){
        return this._startVerse;
    }
    public void SetStartVerse(int startVerse){
        _startVerse = startVerse;
    }

//End Verse Functions:
    public int GetEndVerse(){
        return this._endVerse;
    }
    public void SetEndVerse(int endVerse){
        _endVerse = endVerse;
    }

//Words Verse Functions:
    public List<Word> GetWords(){
        if(_words.GetIfHidden() == true){
            _words = string('_', _words.Count());
        }
        return _words;
    }
    public void SetWords(List<Word> words){
        _words = words;
    }

//Randomizes the words to be later blank ("____")
    public void randomized(){
        for(int i = 0; i < 3; i++){
            Console.Write(GetWords().Count());
            num = randomGenerator.Next(0, GetWords().Count());
            GetWords()[num].SetToHidden();
        }
    }

}
