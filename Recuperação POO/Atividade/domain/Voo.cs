namespace Atividade.domain;

public class Voo :IIdentificacao
{
    //ATRIBUTOS DA CLASSE VOO
    private Aviao aviaoVoo;
    private string codificacao;
    private long codigo;
    private List<Passageiro> passageiros;
    private List<Funcionario> tripulantes;

    //ATRIBUTOS DA RELAÇÃO COM AEROPORTO
    private Aeroporto destinoDoVoo;
    private Aeroporto origemDoVoo;

    //PROPRIEDADE DO RELACIONAMENTO
    public Aviao AviaoVoo { get => aviaoVoo; set => aviaoVoo = value; }
    //PROPRIEDADES
    public string Codificacao { get => codificacao; set => codificacao = value; }
    public long Codigo { get => codigo; set => codigo = value; }
    public List<Passageiro> Passageiros { get => passageiros; set => passageiros = value; }
    public List<Funcionario> Tripulantes { get => tripulantes; set => tripulantes = value; }
    public Aeroporto DestinoDoVoo { get => destinoDoVoo; set => destinoDoVoo = value; }
    public Aeroporto OrigemDoVoo { get => origemDoVoo; set => origemDoVoo = value; }
    //CONSTRUTOR
    public Voo(Aviao aviaoVoo, string codificacao, long codigo, Aeroporto destinoDoVoo, Aeroporto origemDoVoo)
    {
        this.aviaoVoo = aviaoVoo;
        this.codificacao = codificacao;
        this.codigo = codigo;
        this.passageiros = new List<Passageiro>();
        this.tripulantes = new List<Funcionario>();
        this.destinoDoVoo = destinoDoVoo;
        this.origemDoVoo = origemDoVoo;
    }
}
