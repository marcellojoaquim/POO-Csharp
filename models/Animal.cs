namespace orientacaoObjeto.models
{
    public class Animal
    {
        public string Raca {get; set;}
        public string nomeAnimal {get; set;}
        public int idadeAnimal {get; set;}

        public void ApresentarPET()
        {
            Console.WriteLine($"Meu pet é {Raca} que se chama {nomeAnimal} e tem {idadeAnimal} anos.");
        }
    }
}