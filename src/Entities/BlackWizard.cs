namespace MeuJogoRPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard (string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;            
        }

        public override string Attack()
        {
            return this.Name + " lançou uma magia sombria!" ;
        }

        public string SpecialAttack (int Bonus)
        {
            if (Bonus > 6)
             {
                return this.Name + " lançou magia sombria super efetiva com bônus de " + Bonus + "!";
             } else{
                return this.Name + " lançou magia sombria pouco efetiva com bônus de " + Bonus + "!";
             }
        }
    }
}