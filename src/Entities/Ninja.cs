namespace MeuJogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " lançou várias shurikens!";
        }

        public string SpecialAttack(int Bonus)
        {
            if (Bonus > 6)
             {
                return this.Name + " lançou shurikens com um forte veneno com bônus de " + Bonus + "!";
             } else{
                return this.Name + " lançou shurikens com um fraco veneno com bônus de " + Bonus + "!";
             }
        }


        //special attack
    }
}