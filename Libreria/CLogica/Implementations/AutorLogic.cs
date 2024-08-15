using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _AutorRepository;

        public AutorLogic(IAutorRepository AutorRepository)
        {
            _AutorRepository = AutorRepository;
        }
        public async Task<List<Autor>> GetAll()
        {
            return await _AutorRepository.GetAll();
        }
        public void AltaAutor(Autor autorNuevo)
        {
            Autor autor = new Autor();
            autor.Biografia = autorNuevo.Biografia;  
            if (string.IsNullOrEmpty(autorNuevo.Biografia))
            {
                throw new ArgumentException("No válido");
            }            
            _AutorRepository.Create(autor);
            _AutorRepository.Save();
        }
        public void ActualizarAutor(string documento, Autor autorActualizar)
        {
            if (string.IsNullOrEmpty(autorActualizar.Biografia))
            {
                throw new ArgumentException("La biografía no es válida");
            }
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
            {
                throw new ArgumentException("El documento ingresado es invalido.");
            }
            Autor? autor = _AutorRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento.");
            }
            autor.Biografia = autorActualizar.Biografia;

            _AutorRepository.Update(autor);
            _AutorRepository.Save();
        }
        public void EliminarAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido");

            Autor? autor = _AutorRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento.");
            }
            _AutorRepository.Delete(autor);
            _AutorRepository.Save();
        }
        public bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }

    }
}
