namespace Controle
{
    public class ControleProduto : ControleBase
    {
         public virtual void Criar(Registro o)
        {
    
        }

        public virtual void Atualizar(Resgistro o)
        {

        }

        public virtual void Apagar(Registro o)
        {

        }

        public virtual void Ler(Registro o)
        {
            return id;
        }
    }
}