namespace ex3.src
{
    public class Guerreiro : Personagem
    {
        private List<string> Habilidade { get; set; }
        public Guerreiro(string Nome) : base(Nome)
        {
            this.Inteligencia = 5;
            this.Forca = 10;
            this.Habilidade = new List<string> {"Ataque com espada", "Defesa com escudo"};
        }

        public override void lvlUp()
        {
            this.Level += 1;
            this.Inteligencia = this.Inteligencia + 1;
            this.Forca = this.Forca + 2;
            System.Console.WriteLine("Você aumentou de nível. Parabéns!");
            System.Console.WriteLine($"Level: {this.Level} | "+$"Força: {this.Forca} | "+$"Inteligencia: {this.Inteligencia}");
        }
        public void attack()
        {
            Random numAleatorio = new Random();
            int numRandom = numAleatorio.Next(0, 301);
            double dano = (this.Forca * this.Level) + numRandom;
            System.Console.WriteLine($"Você causou {dano} de dano físico.");
        }
            public void aprenderHabilidade(string habilidade)
        {
            this.Habilidade.Add(habilidade);
            System.Console.WriteLine("Habilidade adicionada. Suas habilidades são: " + String.Join(", ", this.Habilidade.ToArray()));
        }
    }
}