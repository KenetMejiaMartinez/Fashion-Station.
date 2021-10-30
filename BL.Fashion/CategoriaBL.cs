using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class CategoriasBL
    {
        contexto _contexto;

        public BindingList<Categoria> ListaCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new contexto();
            ListaCategorias = new BindingList<Categoria>();
        }

        public BindingList<Categoria> ObtenerCategorias()
        {
            _contexto.Categorias.Load();
            ListaCategorias = _contexto.Categorias.Local.ToBindingList();

            return ListaCategorias;
        }
    }

        public class Categoria
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }
}