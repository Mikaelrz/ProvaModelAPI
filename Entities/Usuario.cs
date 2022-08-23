namespace PatrimonioSenaiTaguatinga.Entities;

public class Usuario{
    public Usuario(int id, string nome, string sobrenome, string login, string senha, int idNivel)
    {
        Id = id;
        Nome = nome;
        Sobrenome = sobrenome;
        Login = login;
        Senha = senha;
        IdNivel = idNivel;
    }

    public int Id { get; set; }
public string Nome { get; set; }
public string Sobrenome {get; set; }
public string Login { get; set; }
public string Senha { get; set; }
public int IdNivel { get; set; }
public Nivel Nivel { get; set; }= null!;
}
