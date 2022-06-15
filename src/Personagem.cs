namespace ex3.src
{
    public class Personagem
    {
        public static int instancias;
        protected string Nome { get; set; }

        protected int Vida { get; set; }
        
        protected int Mana { get; set; }
        
        protected float Xp { get; set; }
        
        protected int Inteligencia { get; set; }
        
        protected int Forca { get; set; }
        
        protected int Level { get; set; }      
        

        public Personagem(string Nome)
        {
            this.Nome = Nome;
            this.Vida = 100;
            this.Mana = 100;
            this.Xp = 0;
            this.Level = 1;
            instancias ++;
        }

        public virtual void lvlUp(){}

    }
}