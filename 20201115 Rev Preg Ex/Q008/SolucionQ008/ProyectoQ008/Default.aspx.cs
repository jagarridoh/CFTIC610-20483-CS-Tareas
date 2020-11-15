using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace ProyectoQ008
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // PONER AQUI BREAKPOINT
            string jsonEntrada = "{ \"FirstName\" : \"David\", \"LastName\" : \"Jones\", \"Values\" : [0, 1, 2] }";
            var aName = Name.ConvertToName(jsonEntrada);
            var bFirstName = aName.FirstName;
            var cLastName = aName.LastName;
            var dValues = aName.Values;
            var eFirstValue = dValues[0];
            var fSecondValue = dValues[1];
            var gThirdValue = dValues[2];
        }
    }

    public class Name
    {
        public int[] Values { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Name ConvertToName(string json)
        {
            var ser = new JavaScriptSerializer();
            //-> LINEA 10 A RELLENAR<-
            //A. return ser.ConvertToType<Name>(json);    //A. Error runtime: System.InvalidOperationException: 'No se puede convertir el objeto de tipo 'System.String' en el tipo 'ProyectoQ008.Name''
            //B. return ser.DeserializeObject(json);      //B. Error en build: Error CS0266  Cannot implicitly convert type 'object' to 'ProyectoQ008.Name'.An explicit conversion exists (are you missing a cast?) ProyectoQ008 
            //C. return ser.Deserialize<Name> (json);     //C.  FUNCIONA y se confirma la respuesta del PDF
            //D. return(Name)ser.Serialize(json);         //D. Error en build: Error CS0030  Cannot convert type 'string' to 'ProyectoQ008.Name' ProyectoQ008 
            return ser.Deserialize<Name>(json);
        }
    }
}