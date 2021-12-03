using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace EmpresaProveedor
{
    /// <summary>
    /// Descripción breve de WSCategorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCategorias : System.Web.Services.WebService
    { 
            private string connectionString; public WSCategorias()
            {
            //Eliminar la marca de comentario de la línea siguiente si utiliza los 
            // componentes diseñados //InitializeComponent(); 
            connectionString = "Data Source=DESKTOP-PL8A8HV;Initial Catalog=DATAMART;Integrated Security=True";
            }
            [WebMethod]
            public DataSet GetCategorias()
            {
                string selectSQL = "SELECT NOMBRE_PRODUCTO, DESCRIPCION_PRODUCTO FROM producto";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                //SqlDataReader reader; 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dsCategorias = new DataSet();
                // Fill the same table. 
                adapter.Fill(dsCategorias, "producto");
                return dsCategorias;
            }
        }
}


