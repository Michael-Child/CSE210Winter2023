using System;

public class Move{
    private string _name;
    private int _dmg;
    private string _offType;
    public Move(string name,
    int dmg,
    string offType){
        this._name = name;
        this._dmg = dmg;
        this._offType = offType;
    }

    public void SetName(string word){
        _name = word;
    }public string GetWName(){
        return _name;
    }public void SetDamage(int word){
        _dmg = word;
    }public int GetDamage(){
        return _dmg;
    }public void SetOffType(string word){
        _offType = word;
    }public string GetOffType(){
        return _offType;
    }
}
