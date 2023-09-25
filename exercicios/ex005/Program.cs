class program
{
    public static void Main ()
    {
        ListaDoChurrasco();
        listaDoSonho();
    }
    public static void ListaDoChurrasco(){
       string[] lista = new string[6];
       
       for (int i = 0; i < 6; i++)
       {
        Console.WriteLine("Digite o produto que vamos comprar");
        string produto = Console.ReadLine();
        lista[i] = produto;
       }
       Array.Sort(lista);

        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
       
    }
     public static void listaDoSonho(){
       string[] sonhos = new string[3];
       decimal[] valores = new int[3];
       decimal total = 0;
       for (int i = 0;i < 3; i++)
       {
       Console.WriteLine($"informe o seu {i} sonho");
       string sonho = Console.ReadLine();
       Console.WriteLine($"informe o valor do {i} sonho");
       decimal valor = decimal.Parse(Console.ReadLine());
       sonhos[i] = sonho;
       valores[i] = valor;
       }
      foreach(decimal val in valores){
        total = total + val;
      }
      Console.WriteLine($"Seus sonhos custaram aprox. R${total}");
    }


}