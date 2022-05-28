namespace Atividade.domain;

public class Funcionario : Pessoa, IIdentificacao
{
    //ATRIBUTOS
    private string contaCorrente;
    private string matricula;
    //PROPRIEDADES
    public string ContaCorrente { get => contaCorrente; set => contaCorrente = value; }
    public string Matricula { get => matricula; set => matricula = value; }
    //CONSTRUTOR
    public Funcionario(long codigo, DateTime dataDeNascimento, string email, Endereco endereco, string nome, 
    string senha, string telefone, string usuario, string contaCorrente, string matricula) : 
    base(codigo, dataDeNascimento, email, endereco, nome, senha, telefone, usuario)
    {
        this.contaCorrente = contaCorrente;
        this.matricula = matricula;
    }
}
