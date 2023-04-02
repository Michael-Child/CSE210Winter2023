using System;

class Pokemon
{
    private string _name; //Name
    private int _hp; //Hit points
    private int _speed; //Speed (Higher attacks first)
    private int _defense; //Reduce damage taken
    private int _attackPower;//Increase damage taken
    private string _defType;//Pokemon type
    private List<Move> _moves = new List<Move>{};//Pokemon moves

    public Pokemon(
     string name,
     string defType,
     int hp,
     int attackPower,
     int defense,
     int speed,
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
    }public virtual List<Move> GetMoves(){
        return this._moves;
    }public virtual void SetMoves(List<Move> moves){
        _moves = moves;
    }public virtual Move GetMove(int move){
        return this._moves[move];
    }public virtual void TookDamage(double dmg){
        if(GetDefense() > 100){
            SetHP(GetHP() - ((int)(dmg - (dmg/(GetDefense()-100)))));
        }else{
            SetHP(GetHP() - ((int)(dmg + (dmg/(100-GetDefense())))));
        }
    }public virtual int GetTookDamage(double dmg){
        if(GetDefense() > 100){
            return ((int)(dmg - (dmg/(GetDefense()-100))));
        }else{
            return ((int)(dmg + (dmg/(100-GetDefense()))));
        }
    }public virtual void DoThe4thMove(){}
}
