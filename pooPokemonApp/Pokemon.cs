public class Pokemon{

    public Pokemon(){
        this.Nome = "";
        this.Descricao = "";
    }
    public Pokemon(String nome, String descricao){
        this.Nome = nome;
        this.Descricao = descricao;
    }
    private String nome;
    public String Nome
    {
        get { return nome; }
        set { 
            String texto = value.ToUpper();
            nome = texto;
            }
    }

    private String descricao;
    public String Descricao
    {
        get { return this.descricao; }
        set { this.descricao = value.ToUpper(); }
    }

    public virtual void ExibirDados(){
        Console.Write("Nome do Pokemon: " + this.Nome + ", ");
        Console.Write("Descrição: " + this.Descricao);
    }
    
    
}