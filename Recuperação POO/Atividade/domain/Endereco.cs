namespace Atividade.domain;

public class Endereco : IIdentificacao
{
    //ATRIBUTOS
    private long codigo;
    private string bairro;
    private string cidade;
    private string complemento;
    private string estado;
    private int numero;
    private string pais;
    private string rua;

    //PROPRIEDADES
    public string Bairro { get => bairro; set => bairro = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public string Estado { get => estado; set => estado = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Pais { get => pais; set => pais = value; }
    public string Rua { get => rua; set => rua = value; }
    public long Codigo { get => codigo; set => codigo = value; }

    //CONSTRUTOR
    public Endereco(long codigo, string bairro, string cidade, string complemento, string estado, int numero, 
    string pais, string rua)
    {
        this.codigo = codigo;
        this.bairro = bairro;
        this.cidade = cidade;
        this.complemento = complemento;
        this.estado = estado;
        this.numero = numero;
        this.pais = pais;
        this.rua = rua;
    }
}
