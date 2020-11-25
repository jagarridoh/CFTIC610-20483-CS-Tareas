using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ProjectQ093
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var miDic = new Dictionary<string, object>();
            miDic.Add("Elemento1", "Valor1");
            miDic.Add("Elemento2", "Valor2");
            var serializer = new JavaScriptSerializer();
            var serializado = serializer.Serialize(miDic);
            Dictionary<string, object> resultado;
            bool correcto = ValidateJson(serializado, out resultado);
            Console.WriteLine(resultado);
            Console.WriteLine("Fin Project093");
        }

        public bool ValidateJson(string json, out Dictionary<string, object> result)
        {
            // LINEA 3 INSERTAR CODIGO AQUÍ
            //A.DataContractSerializer serializer = new DataContractSerializer();  //Respuesta A
            DataContractSerializer serializer = new DataContractSerializer();  //Respuesta A
            //B.var serializer = new DataContractSerializer();                 //Respuesta B
            //C.XmlSerializer serializer = new XmlSerializer();           //Respuesta C   
            //D.var serializer = new JavaScriptSerializer();          //Respuesta D
            //var serializer = new JavaScriptSerializer();          //Respuesta D
            try
            {
                result = serializer.Deserialize<Dictionary<string, object>>(json);
                //Console.WriteLine(result);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }
    }
}