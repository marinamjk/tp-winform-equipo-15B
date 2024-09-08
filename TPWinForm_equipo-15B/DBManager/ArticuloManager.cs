using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace DBManager
{
    public class ArticuloManager
    {
        public List<Articulo> listar()
        {
            List<Articulo> catalogo= new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
    
            try
            {
                datos.setearConsulta("SELECT A.Id as ArticuloId, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio FROM ARTICULOS A JOIN MARCAS M ON M.Id = A.IdMarca JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux= new Articulo();
                    aux.Id = (int) datos.Lector["ArticuloId"];
                    aux.Codigo = (string) datos.Lector["Codigo"];
                    aux.Nombre = (string) datos.Lector["Nombre"];
                    aux.Descripcion = (string) datos.Lector["Descripcion"];
                    aux.Marca= new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria= new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal) datos.Lector["Precio"];
                    ImagenManager im = new ImagenManager();
                    aux.Imagenes= im.buscarImagenesXArticulo(aux.Id);
                    catalogo.Add(aux);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally 
            {
                datos.cerrarConexion();
            }
            return catalogo;
        }
    
    }
}
