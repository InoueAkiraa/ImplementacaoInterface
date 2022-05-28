namespace Atividade.domain;

public class Passageiro : Pessoa, IIdentificacao
{
    //ATRIBUTOS
    private string documento;
    private string numeroCartao;
    //PROPRIEDADES
    public string Documento { get => documento; set => documento = value; }
    public string NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
    //CONSTRUTOR
    public Passageiro(long codigo, DateTime dataDeNascimento, string email, Endereco endereco, string nome, 
    string senha, string telefone, string usuario, string documento, string numeroCartao) : 
    base(codigo, dataDeNascimento, email, endereco, nome, senha, telefone, usuario)
    {
        this.documento = documento;
        this.numeroCartao = numeroCartao;
    }
}
