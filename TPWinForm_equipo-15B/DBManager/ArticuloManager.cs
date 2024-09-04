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
                return catalogo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    
    }
}
