using ex3.src;


Mago mago1 = new Mago("Cleber");
Mago mago2 = new Mago("João");
Guerreiro guerreiro1 = new Guerreiro("Galvão");
Guerreiro guerreiro2 = new Guerreiro("André");

mago1.aprenderMagia("Escudo negro");
System.Console.WriteLine("");

mago1.attack();
System.Console.WriteLine("");

guerreiro2.attack();
System.Console.WriteLine("");

System.Console.WriteLine("");
System.Console.WriteLine($"Quantidade de personagens criados: {Personagem.instancias}");