using GraphQL.Data;
using GraphQL.Entities;
using GraphQL.Root;

namespace GraphQL.GraphQL;

[ExtendObjectType(typeof(RootQueryQL))]
public class PessoaQueryQL()
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IEnumerable<Pessoa> GetPessoas([Service] Context context) => context.Pessoas;
}
