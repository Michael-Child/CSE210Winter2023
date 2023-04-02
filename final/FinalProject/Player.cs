using System;

class Player{
    private List<Pokemon> _pokeballs = new List<Pokemon>{};
    public Player(List<Pokemon> pokeballs){
        this._pokeballs = pokeballs;
    }public virtual void SetPokemons(List<Pokemon> list){
        foreach(var i in list){
            _pokeballs.Add(i);
    }}public virtual List<Pokemon> GetPokemons(){
        return _pokeballs;
    }public virtual Pokemon GetPokemon(int num){
        return _pokeballs[num];
    }public virtual void ReleasePokemon(Pokemon pokemon){
        foreach(var i in _pokeballs){
            if(i.GetName() == pokemon.GetName()){
                _pokeballs.Remove(i);
    }}}}