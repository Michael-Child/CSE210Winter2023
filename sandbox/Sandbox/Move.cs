using System;

class Move{
    private string _name;
    private int _dmg;
    private string _offType;
    public Move(
    string name,
    string offType,
    int dmg
    ){
        this._name = name;
        this._dmg = dmg;
        this._offType = offType;
    }

    public virtual void SetName(string word){
        _name = word;
    }public virtual string GetName(){
        return _name;
    }public virtual void SetDamage(int word){
        _dmg = word;
    }public virtual int GetDamage(){
        return _dmg;
    }public virtual void SetOffType(string word){
        _offType = word;
    }public virtual string GetOffType(){
        return _offType;
    }
}
