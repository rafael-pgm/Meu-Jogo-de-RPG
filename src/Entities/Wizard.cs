namespace MeuJogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
        {
            return this.Name + " lançou uma magia!";
        } 

        public string SpecialAttack(int Bonus)
        {
            if (Bonus > 6)
             {
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus + "!";
             } else{
                return this.Name + " lançou magia pouco efetiva com bônus de " + Bonus + "!";
             }



        
        }
    }
}