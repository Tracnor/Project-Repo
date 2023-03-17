namespace rer
{
    abstract class Character
    {
        public string Name { get; set; }
        public string CharacterType { get; set; }
        public string Specialty { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public string Stance { get; set; }

        public bool CanHack {get; set;}
        public bool CanFix {get; set;}
        public bool CanAnalyse {get; set;}
        
        public abstract void TakeDamage();  
        public abstract void Attack();
        public abstract void Move();
      
        public abstract void Hack();
        public abstract void Fix();
        public abstract void Analyse();
        public abstract void Heal();
        
    }
}

