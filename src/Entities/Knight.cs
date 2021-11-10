namespace MeuJogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

         public string SpecialAttack (int Bonus)
        {
            if (Bonus > 6)
             {
                return this.Name + " deu um golpe especial forte com bônus de " + Bonus + "!";
             } else{
                return this.Name + " deu um golpe especial fraco com bônus de " + Bonus + "!";
             }
        }

    }
}