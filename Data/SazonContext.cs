using Microsoft.EntityFrameworkCore;
using Sazon.Models;

//Clase que trabaja como un puente entre la base de datos y C#. Le va a decir a Enity como trabaja la base de datos y que tablas va a manejar.

namespace Sazon.Data
{
    public class SazonContext : DbContext //DbContext es herencia 
    {

        public SazonContext(DbContextOptions<SazonContext> options) //Constructor del contexto
            : base(options) //le pasamos las opciones a la clase 'DbContext' , de la que heredamos

        { 
        }

        public DbSet<Categoria> Categorias { get; set; } //Esta linea le "dice" a Enity que 
        //quiere un conjunto de objetos Categoria que va a representar la informacion de categorias que va a manejar en la BD

    }
}
