public class Pokedex{
    private List<PokemonPlus> pokemons;
    public List<PokemonPlus> Pokemons
    {
        get { return pokemons; }
    }

    public Pokedex(){
        this.InicializarLista();
    }   

    private void InicializarLista(){
        this.pokemons = new List<PokemonPlus>();
        int poder = 10;
        PokemonPlus p = new PokemonPlus("Bulbassaur", "Bulbassaur is a grass-type pokemon", poder);
        this.pokemons.Add(p);
        p = new PokemonPlus("Squirtle", "Squirtle is a water-type pokemon", poder);
        this.pokemons.Add(p);

    } 

    public void ListarPokemons(){
        Console.WriteLine("Id| Nome  | Descrição| Poder");
        for(int i= 0; i < this.Pokemons.Count; i++){
            Console.Write(i + ". ");
            this.Pokemons[i].ExibirDados();
        }
    }


}