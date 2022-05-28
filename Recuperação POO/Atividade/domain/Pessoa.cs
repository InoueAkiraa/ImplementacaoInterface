namespace Atividade.domain;

public abstract class Pessoa : IIdentificacao
{
    //ATRIBUTOS
    protected long codigo;
    protected DateTime dataDeNascimento;
    protected string email;
    protected Endereco endereco;
    protected string nome;
    protected string senha;
    protected string telefone;
    protected string usuario;

    //PROPRIEDADES
    public long Codigo {get => codigo; set => codigo = value;}
    public DateTime DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
    public string Email { get => email; set => email = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Senha { get => senha; set => senha = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public string Usuario { get => usuario; set => usuario = value; }
    // PROPRIEDADE DO RELACIONAMENTO
    public Endereco Endereco { get => endereco; set => endereco = value; }
   
    //CONSTRUTOR
    protected Pessoa(long codigo, DateTime dataDeNascimento, string email, Endereco endereco, string nome,
    string senha, string telefone, string usuario)
    {
        this.codigo = codigo;
        this.dataDeNascimento = dataDeNascimento;
        this.email = email;
        this.endereco = endereco;
        this.nome = nome;
        this.senha = senha;
        this.telefone = telefone;
        this.usuario = usuario;
    }
}
