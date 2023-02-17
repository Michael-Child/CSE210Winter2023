using System;

public class Word{

    private bool _hidden = false;
    private string _word;
    public Word(string _word){
        this._word = _word;
    }

    public void SetWord(string word){
        _word = word;
    }

    public string GetWord(){
        return _word;
    }

//Hides the word
    public void SetToHidden(){
        _hidden = true;
    }

//Checks if word is hidden
    public bool GetIfHidden(){
        return _hidden;
    }

}
