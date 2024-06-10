public class PokemonPlus : Pokemon{
    
    public PokemonPlus():base(){
        this.Poder = 0;
    }

    public PokemonPlus(String nome, String descricao, int poder):base(nome, descricao){
        this.Poder = poder;
    }

    public int Poder { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine(", Poder: " + this.Poder);
    }

}