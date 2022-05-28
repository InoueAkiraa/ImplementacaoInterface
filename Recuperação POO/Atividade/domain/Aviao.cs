namespace Atividade.domain;

public class Aviao : IIdentificacao
{
    private double carga;
    private string codificacao;
    private long codigo;
    private int qtdeClasseEconomica;
    private int qtdeClasseExecutiva;
    private int qtdePrimeiraClasse;
    private int qtdeTripulacao;



    public double Carga { get => carga; set => carga = value; }
    public string Codificacao { get => codificacao; set => codificacao = value; }
    public long Codigo { get => codigo; set => codigo = value; }
    public int QtdeClasseEconomica { get => qtdeClasseEconomica; set => qtdeClasseEconomica = value; }
    public int QtdeClasseExecutiva { get => qtdeClasseExecutiva; set => qtdeClasseExecutiva = value; }
    public int QtdePrimeiraClasse { get => qtdePrimeiraClasse; set => qtdePrimeiraClasse = value; }
    public int QtdeTripulacao { get => qtdeTripulacao; set => qtdeTripulacao = value; }

    public Aviao(double carga, string codificacao, long codigo, int qtdeClasseEconomica, int qtdeClasseExecutiva, int qtdePrimeiraClasse, int qtdeTripulacao)
    {
        this.carga = carga;
        this.codificacao = codificacao;
        this.codigo = codigo;
        this.qtdeClasseEconomica = qtdeClasseEconomica;
        this.qtdeClasseExecutiva = qtdeClasseExecutiva;
        this.qtdePrimeiraClasse = qtdePrimeiraClasse;
        this.qtdeTripulacao = qtdeTripulacao;
    }
}
