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
    
        public int agregar(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                //("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion,@IdMarca, @IdCategoria, @Precio)");
              

                // Insertar el artículo y devolver el ID insertado
                accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                           "OUTPUT INSERTED.Id " +  // Esta línea devuelve el ID del artículo recién creado
                                           "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                accesoDatos.setearParametros("@Codigo", articulo.Codigo);
                accesoDatos.setearParametros("@Nombre", articulo.Nombre);
                accesoDatos.setearParametros("@Descripcion", articulo.Descripcion);
                accesoDatos.setearParametros("@IdMarca", articulo.Marca.id);
                accesoDatos.setearParametros("@IdCategoria", articulo.Categoria.id);
                accesoDatos.setearParametros("@Precio", articulo.Precio);

                // Ejecutar la consulta y devolver el ID
                int idArticuloNuevo = (int)accesoDatos.ejecutarEscalar();
                return idArticuloNuevo;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar_articulo)
        {

        }
    
    }
}
