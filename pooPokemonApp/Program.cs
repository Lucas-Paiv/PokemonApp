using System.Data.Common;
Pokedex d = new Pokedex();
int resp = 2;
while( resp != 0){
    resp = Menu();
    if(resp == 1){
        d.ListarPokemons();
    }
    else if(resp == 2){
        d.ListarPokemons();
        Console.Write("Digite o ID do pokémon: ");
        int id = Convert.ToInt32(Console.ReadLine());
        PokemonPlus pPlayer = d.Pokemons[id];
        Random r = new Random();
        id = r.Next(0, d.Pokemons.Count);
        PokemonPlus pPC = d.Pokemons[id];
        if(pPlayer.Poder > pPC.Poder)
        {
            Console.WriteLine("Player wins!");    
        }
        else if(pPlayer.Poder < pPC.Poder){
            Console.WriteLine("You Lose!");
        }
        else{
            Console.WriteLine("Draw");
        }
    }
    Console.ReadKey();
    Console.Clear();
}

static int Menu(){
    Console.WriteLine("Bem vindo ao espaço de batalha pokémon!!!!");
    Console.WriteLine("0 - Sair do menu.");
    Console.WriteLine("1 - Listar todos os pokémons");
    Console.WriteLine("2 - Ir para a Arena.");
    Console.Write("O que deseja fazer?");
    int resp = Convert.ToInt32(Console.ReadLine());
    return resp; 

}
