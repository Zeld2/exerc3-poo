namespace ex3.src
{
    public class Mago : Personagem
    {
        private List<string> Magia { get; set; }
        
        
        public Mago(string Nome) : base(Nome)
        {
            this.Inteligencia = 10;
            this.Forca = 5;
            this.Magia = new List<string> {"Bola de fogo", "Bola de Gelo"};
        }

        public override void lvlUp()
        {
            this.Level += 1;
            this.Inteligencia = this.Inteligencia + 2;
            this.Forca = this.Forca + 1;
            System.Console.WriteLine("Você aumentou de nível. Parabéns!");
            System.Console.WriteLine("---------------------------------");
            System.Console.WriteLine($"Level: {this.Level}\n"+$"Força:{this.Forca}\n"+$"Inteligencia{this.Inteligencia}");
        }
        public void attack()
        {   
            Random numAleatorio = new Random();
            int numRandom = numAleatorio.Next(0,301);
            double dano = (this.Inteligencia*this.Level) + numRandom;
            System.Console.WriteLine($"Você causou {dano} de dano mágico.");
        }
        public void aprenderMagia(string magia)
        {
            this.Magia.Add(magia);
            System.Console.WriteLine("Magia adicionada. Suas magias são: " + String.Join(", ", this.Magia.ToArray()));
        }
    }
}