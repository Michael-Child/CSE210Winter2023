using System;

public class Scripture{

    private string _author = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int _endVerse = 0;
    private List<string> _list = new List<string>();
    private List<Word> _words = new List<Word>();
    private Random randomGenerator = new Random();
    private int num = 0;
    public Scripture(string _author, int _chapter, int _startVerse, int _endVerse, string _words){
        this._author = _author;
        this._chapter = _chapter;
        this._startVerse = _startVerse;
        this._endVerse = _endVerse;

        string[] subs = _words.Split(' ');
        foreach(var i in subs){
            Word _word = new Word(i);
            this._words.Add(_word);
        }        
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

// public List<string> GetWords(){
//     List<string> WordList = new List<string>();
//     foreach(Word word in _words){
//         WordList.Add(word.GetWord());
//     }
//     return WordList;
// }

    public string GetWords(){
        string verse = "";
        for(int i = 0; i < _words.Count(); i++){
            verse += _words[i].GetWord() + " ";
        }
        return verse;
    }

// //Words Verse Functions:
//     public List<Word> GetWords(){
//         return this._words;
//     }

    public void SetWords(List<Word> words){
        _words = words;
    }

//Replaces a word inside words with "_____"
    public List<Word> ReplacedWords(){
        for(int i = 0; i < _words.Count(); i++){
            if(_words[i].GetHidden() == true){
                string replacement = new string('_', _words[i].GetWord().Count());
                _words[i].SetWord(replacement);
            }
        }
        return this._words;
    }

    public string DisplayReplacedWords(){
        string verse = "";
        for(int i = 0; i < _words.Count(); i++){
            if(_words[i].GetHidden() == true){
                string replacement = new string('_', _words[i].GetWord().Count());
                _words[i].SetWord(replacement);
            }
            verse += _words[i].GetWord() + " ";
        }
        return verse;
    }

//Randomizes the words to be later blank ("____")
    public void randomized(){
        for(int i = 0; i < 3; i++){
            num = randomGenerator.Next(0, _words.Count());
            _words[num].SetHidden(true);
            // All GetWords() are replaced with _words
        }

    }
}
