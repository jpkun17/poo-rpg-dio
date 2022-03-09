using System;

namespace ProjetoRPG{
    class Character{
        string name;
        string @class;
        int level;
        int hp;
        int mp;
        int attack;
        int magic;
        int agility;
        public Character(string name, string @class, int level, int hp, int mp, int attack, int magic, int agility){
            this.name = name;
            this.@class = @class;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
            this.attack = attack;
            this.magic = magic;
            this.agility = agility;
        }

        public void showStatus(){
            Console.WriteLine($"{name} {@class}  LV: {level}\nHP: {hp} MP: {mp}\nAttack: {attack} Magic: {magic} Agility: {agility}");
        }
    }
}