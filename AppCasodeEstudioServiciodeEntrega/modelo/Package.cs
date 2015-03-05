using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCasodeEstudioServiciodeEntrega
{
    public class Package
    {
        #region"atributos"
        private string nombre;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string codigoremitente;
        private string destinatario;
        private string pesokg;
        private string costoporgramo;
#endregion
        public string Nombre
        {
            get { return nombre;}
            set {nombre = value;}
        }
     
         public string Direccion
        { 
         get {return direccion; }
        set {direccion = value;}
}
         public string Ciudad
{
        get {return ciudad; }
        set {ciudad= value;}

}
         public string Departamento
{
      get { return departamento;}
      set {departamento = value;}
    }

    public string Codigoremitente
    {

      get { return codigoremitente;}
      set {codigoremitente = value;}
}
            public string Destinatario
{
    get { return destinatario; }
      set {destinatario = value;}

}
            public string Pesokg
{

  get { return pesokg;}
   set { pesokg = value;}
}
            public string Costoporgramo
            {

        get { return costoporgramo;}
        set {costoporgramo = value;}


}
        
    }