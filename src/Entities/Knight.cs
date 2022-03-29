using System;

namespace MeuJogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP, int XP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.XP = XP;
        }
        
         public string SpecialAttack ()
        {
            this.HP -= 12;
            this.XP += 13;
            var random = new Random();
            int Bonus = random.Next(1, 9);
            


            if (Bonus > 6)
             {
                return $"{this.Name} deu um golpe especial forte com bônus de {Bonus}!\n{this.Name} agora tem {this.HP} de HP e {this.XP} de XP!";
             } else{
                return $"{this.Name} deu um golpe especial fraco com bônus de {Bonus}!\n{this.Name} agora tem {this.HP} de HP e {this.XP} de XP!";
             }
        }

    }
}