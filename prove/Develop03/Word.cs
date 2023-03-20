using System;

public class Word{

    private bool _hidden = false;
    private string _word;
    // public Word(string _word){
    //     this._word = _word;
    // }

    public void SetWord(string word){
        _word = word;
    }

    public string GetWord(){
        return _word;
    }

//Hides the word
    public void SetHidden(bool response){
        _hidden = response;
    }

//Checks if word is hidden
    public bool GetHidden(){
        return _hidden;
    }

}
