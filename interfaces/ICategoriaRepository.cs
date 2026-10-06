using Sazon.Models;
//Interfaz categoria: Encargado de implementar lo que debe contener cada categoria. NO lo hace, sino dice 'esto debe cumplirse'.
namespace Sazon.interfaces
{
    public interface ICategoriaRepository
    {
        List<Categoria> ObtenerTodas();

        Categoria ObtenerPorId(int id);

        void Agregar(Categoria categoria);

        void Actualizar(Categoria categoria);

        void Eliminar(int id);


    }
}
