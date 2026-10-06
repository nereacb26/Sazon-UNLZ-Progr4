using Sazon.Data;
using Sazon.interfaces;
using Sazon.Models;

namespace Sazon.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository

    {
        private readonly SazonContext _context;

        //Constructor: recibe el SazonConext por inyeccion de dependencias 
        public CategoriaRepository(SazonContext context) 
        {
            _context = context;

        }


        //CRUD
        public List<Categoria> ObtenerTodas() 
        {

            return _context.Categorias.ToList();

        }

        public Categoria ObtenerPorId(int id) 
        {

            return _context.Categorias.Find(id);

        }

        public void Agregar(Categoria categoria) 
        { 

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

        }

        public void Actualizar(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
        }

        public void Eliminar(int id) 
        {

            Categoria categoria = _context.Categorias.Find(id);

            if (categoria != null) 
            {
                //Borrado logico, cuando eliminamos se desactiva de la BD no se borra definitivamente 
                categoria.Activa = false;
                _context.SaveChanges(); //SaveChanges permite cambios en la BD

            
            }

        }



    }
}
