using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T:class;
         void Update<T>(T entity) where T:class;
         void Delete<T>(T entity) where T:class;

         Task<bool> SaveChangeAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
         Task<Evento[]> GetEventosAsyncById(int EventosId, bool includePalestrantes);

         //PALESTRANTES
         Task<Evento[]> GetAllPalestrantesAsyncByName(bool includePalestrantes);
         Task<Evento[]> GetPalestranteAsync(int PalestranteId, bool includePalestrantes);

    }
}