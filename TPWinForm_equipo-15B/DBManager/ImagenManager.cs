using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace DBManager
{
    public class ImagenManager
    {
        public List<Imagen> buscarImagenesXArticulo(int idArt)
        {
            List<Imagen> imagenes = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl from IMAGENES WHERE IdArticulo=" + idArt +"");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux= new Imagen();
                    aux.id = (int) datos.Lector["Id"];
                    aux.idArticulo= (int) datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    imagenes.Add(aux);

                }

                return imagenes;
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
