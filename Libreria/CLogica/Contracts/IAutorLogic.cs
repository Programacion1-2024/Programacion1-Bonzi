using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        void AltaAutor(Autor autor); 
        void ActualizarAutor(string documento, Autor autorActualizar);
        void EliminarAutor(string documento);
    }
}
