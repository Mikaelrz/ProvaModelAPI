namespace PatrimonioSenaiTaguatinga.Entities;

public class Nivel{
    public Nivel(string nome, int id)
    {
        Nome = nome;
        Id = id;
    }

    public string Nome {get; set; }
    public int Id {get; set; }

public ICollection<Usuario> Usuarios { get; set; } = null!;
}

