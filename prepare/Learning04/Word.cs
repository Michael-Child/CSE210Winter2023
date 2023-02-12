using System;

public class Word{

    private bool _hidden = false;
    private string _word;
    public Word(string _word){
        this._word = _word;
    }

//Hides the word
    public void SetToHidden(){
        _hidden = true;
    }

//Checks if word is hidden
    public bool GetIfHidden(){
        if(_hidden == true){
            return _hidden;
        }
        else{
            return _hidden;
        }
    }

}
