using System;
using System.Collections.Generic;
using System.Linq;
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
                datos.setearConsulta("SELECT Codigo, Nombre, Descripcion, Precio from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux= new Articulo();
                    aux.Codigo = (string) datos.Lector["Codigo"];
                    aux.Nombre = (string) datos.Lector["Nombre"];
                    aux.Descripcion = (string) datos.Lector["Descripcion"];
                    aux.Precio = (decimal) datos.Lector["Precio"];
                    catalogo.Add(aux);
                }
                return catalogo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
    
    }
}
