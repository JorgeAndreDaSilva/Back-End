using TipoPantera.Model;
// using Microsoft.EntityFrameworkCore;

class Program 
{
    public static void Main()
    {
        
        var pantera1 = new Pantera();

        pantera1.Correr();
        pantera1.Cacar();
        pantera1.reprodu();

        pantera1.cor = "rosa";
        pantera1.tamanho = "2 Metros";
        pantera1.especie = "rosa";
        pantera1.peso = "70KG";

        pantera1.ApresentarEspecie();

    }
}

