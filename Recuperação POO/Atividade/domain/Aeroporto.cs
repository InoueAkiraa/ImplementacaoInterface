namespace Atividade.domain;

public class Aeroporto : IIdentificacao
{
    //ATRIBUTOS
    private long codigo;
    private Endereco endereco;
    private string nome;
    private string sigla;

    //PROPRIEDADES
    public long Codigo { get => codigo; set => codigo = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Sigla { get => sigla; set => sigla = value; }
    //PROPRIEDADE DO RELACIONAMENTO
    public Endereco Endereco { get => endereco; set => endereco = value; }

    //CONSTRUTOR
    public Aeroporto(long codigo, Endereco endereco, string nome, string sigla)
    {
        this.codigo = codigo;
        this.endereco = endereco;
        this.nome = nome;
        this.sigla = sigla;
    }    
}
