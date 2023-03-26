using System;

class Pokemon
{
    private string _name; //Name
    private int _hp; //Hit points
    private int _speed; //Speed (Higher attacks first)
    private int _defense; //Reduce damage taken
    private int _attackPower;//Increase damage taken
    private string _defType;//Pokemon type
    private List<Move> _moves = new List<Move>{Move num1, Move num2, Move num3, Move num4};//Pokemon moves

    public Pokemon(
     string name,
     int hp,
     int speed,
     int defense,
     int attackPower,
     string defType,
     List<Move> moves){
        this._name=name;
        this._hp=hp;
        this._speed=speed;
        this._defense=defense;
        this._attackPower=attackPower;
        this._defType=defType;
        this._moves=moves;
    }public virtual string GetName(){
        return this._name;
    }public virtual void SetName(string word){
        _name = word;
    }public virtual int GetHP(){
        return this._hp;
    }public virtual void SetHP(int num){
        _hp = num;
    }public virtual int GetSpeed(){
        return this._speed;
    }public virtual void SetSpeed(int num){
        _speed = num;
    }public virtual int GetDefense(){
        return this._defense;
    }public virtual void SetDefense(int num){
        _defense = num;
    }public virtual int GetAttackPower(){
        return this._attackPower;
    }public virtual void SetAttackPower(int num){
        _attackPower = num;
    }public virtual string GetDefType(){
        return this._defType;
    }public virtual void SetDefType(string word){
        _defType = word;
    }public virtual string GetMoves(){
        return this._defType;
    }public virtual void SetMoves(Move num1, Move num2, Move num3, Move num4){
        _defType = word;
    }
}