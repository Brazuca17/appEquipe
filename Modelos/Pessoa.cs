namespace Modelos
{

public class Pessoa
{
    string nome;
    int id;
    string sobrenome;
    string CPF;
    string telefone;

    public void SetNome(string nome)
     {
        this.nome = nome; 
     }

    public string Getnome()
     {
        return nome;
     }

    public void Setid(int id)
     {
        this.id = id;
     }

    public int Getid()
     {
        return id;
     }

    public void Setsobrenome(string sobrenome)
     {
        this.sobrenome = sobrenome;
     }

    public string Getsobrenome()
     {
        return sobrenome;
     }

    public void SetCPF(string CPF)
     {
        this.CPF = CPF;
     }

    public string GetCPF()
     {
        return CPF;
     }

    public void Settelefone(string telefone)
     {
        this.telefone = telefone;
     }
    
    public string Gettelefone()
     {
        return telefone;
     }

}
}