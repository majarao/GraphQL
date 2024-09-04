using GraphQL.Data;
using GraphQL.Entities;
using GraphQL.Root;

namespace GraphQL.GraphQL;

[ExtendObjectType(typeof(RootMutationQL))]
public class PessoaMutationQL
{
    public Pessoa Pessoa(
        Guid? id,
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
        string? corCabelo,
        [Service] Context context)
    {
        Pessoa pessoa;
        Guid idPessoa;

        if (id == null)
        {
            idPessoa = Guid.NewGuid();
        }
        else
        {
            idPessoa = id.Value;
        }

        pessoa = new(
            idPessoa,
            primeiroNome,
            segundoNome,
            sobrenome,
            dataNascimento,
            nacionalidade,
            naturalidade,
            altura,
            peso,
            corOlhos,
            corPele,
            corCabelo);

        context.Add(pessoa);

        context.SaveChanges();

        return pessoa;
    }
}
