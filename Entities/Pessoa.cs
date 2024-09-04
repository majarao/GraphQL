namespace GraphQL.Entities;

public class Pessoa
{
    protected Pessoa() { }

    public Pessoa(
        Guid id,
        string primeiroNome,
        string? segundoNome,
        string sobrenome,
        DateTime dataNascimento,
        string? nacionalidade,
        string? naturalidade,
        decimal altura,
        decimal peso,
        string? corOlhos,
        string? corPele,
        string? corCabelo)
    {
        Id = id;
        PrimeiroNome = primeiroNome;
        SegundoNome = segundoNome;
        Sobrenome = sobrenome;
        DataNascimento = dataNascimento;
        Nacionalidade = nacionalidade;
        Naturalidade = naturalidade;
        Altura = altura;
        Peso = peso;
        CorOlhos = corOlhos;
        CorPele = corPele;
        CorCabelo = corCabelo;
    }

    public Guid Id { get; }
    public string PrimeiroNome { get; private set; } = string.Empty;
    public string? SegundoNome { get; private set; }
    public string Sobrenome { get; private set; } = string.Empty;
    public DateTime DataNascimento { get; private set; }
    public string? Nacionalidade { get; private set; }
    public string? Naturalidade { get; private set; }
    public decimal Altura { get; private set; }
    public decimal Peso { get; private set; }
    public string? CorOlhos { get; private set; }
    public string? CorPele { get; private set; }
    public string? CorCabelo { get; private set; }
}
