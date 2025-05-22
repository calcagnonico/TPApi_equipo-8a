using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace api_producto.Models
{
    public class ArticuloDto
    {


       
                public string Codigo { get; set; }
                public string Nombre { get; set; }

                public string Descripcion { get; set; }
                public int idMarca { get; set;  }
                public int IdCategoria { get; set;  }
                public List<string> Imagen { get; set; }
                public decimal Precio { get; set; }
        }
}