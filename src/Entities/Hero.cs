namespace MeuJogoRPG.src.Entities
{
    public abstract class Hero
    {         
        public string Name;
        public int Level;
        public string HeroType;

        public int HP;

        public int MP;

        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }   

        public Hero()
        {
            
        }

        public override string ToString()
        {
            return "The hero " + this.Name + " has acheived the level " + this.Level + " and is a " + this.HeroType + "!" + "\nThe hero " + this.Name + " has now " + this.HP + " of HP and " + this.MP + " of MP!";
             
        } 

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada!";
        }
    }
}