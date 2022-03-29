using System;

namespace MeuJogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP, int XP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.XP = XP;
        }

        public override string Attack()
        {
            this.MP -= 7;
            this.XP =+ 13;
            return $"{this.Name} lançou várias shurikens!\n{this.Name} agora tem {this.MP} de MP e {this.XP} de XP!";
        }

        public string SpecialAttack()
        {
            this.MP -= 18;
            this.XP += 27;
            var random = new Random();
            int Bonus = random.Next(1, 9);
            if (Bonus > 6)
             {
                return $"{this.Name} lançou shurikens com um forte veneno com bônus de {Bonus}!\n{this.Name} agora tem {this.MP} de MP e {this.XP} de XP!";
             } else{
                return $"{this.Name} lançou shurikens com um fraco veneno com bônus de {Bonus}!\n{this.Name} agora tem {this.MP} de MP e {this.XP} de XP!";
             }
        }
    }
}