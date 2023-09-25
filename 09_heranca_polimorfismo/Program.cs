// classe pai que sera herdada pelo filho - superClasse

class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom(){
        Console.WriteLine("Animal emite som");
    }
} 
// classe filha que sera herdada da classe Animal
// recebera todos os atributos e metodos da superClasse

class Cachorro : Animal{
    public string tipoPelo { get; set;}
    public void latir (){
        Console.WriteLine($"O cachorro {cor} esta latindo");
    }
}

class Gato : Animal{

        public override void EmitirSom(){
        Console.WriteLine("O gato esta miando");
    }

}

class Program {
    public static void Main() {
        var animalGenerico = new Animal ();
        animalGenerico.EmitirSom();


        Cachorro meuCachorro = new Cachorro ();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom ();
        meuCachorro.latir();

        Gato meuGato = new Gato ();
        meuGato.EmitirSom();
    }
}