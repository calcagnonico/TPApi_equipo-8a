using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_producto.Models
{
    public class ImagenesDto
    {
        public int Id { get; set; }
        public List<string> Imagenes { get; set; }
    }
}