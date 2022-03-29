namespace MeuJogoRPG.src.Entities
{
    public abstract class Hero
    {         
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;
        public int XP;
        public Hero(string Name, int Level, string HeroType, int HP, int MP, int XP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.XP = XP;
        }   

        public Hero()
        {
            
        }

        public override string ToString()
        {
            return $"O herói {this.Name} alcançou o level {this.Level} e é um {this.HeroType}! \nO herói {this.Name} agora tem {this.HP} de HP, {this.MP} de MP e {this.XP} de XP!";
             
        } 
        public virtual string Attack()
        {
            this.XP += 13;
            return $"{this.Name} atacou com a sua espada!\n{this.Name} agora tem {this.XP} de XP!";
        }
    }
}