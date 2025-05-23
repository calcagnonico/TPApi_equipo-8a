using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using negocio;
using dominio;
using api_producto.Models;

namespace api_producto.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.listar();
        }

        // GET: api/Articulo/5
        public Articulo Get(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.obtenerPorId(id);
        }

        // POST: api/Articulo
        public void Post([FromBody] ArticuloDto articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Codigo = articulo.Codigo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.Marca = new Marca { Id = articulo.idMarca };
            nuevo.Categoria = new Categoria { Id = articulo.IdCategoria };
            nuevo.Imagen = articulo.Imagen;
            nuevo.Precio = articulo.Precio;
            negocio.agregar(nuevo);
        }

        [HttpPost]
        [Route("api/Articulo/AgregarImagenes")]
        public IHttpActionResult Post([FromBody] ImagenesDto imagenes)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                string imagenResultado = negocio.agregarImagenes(imagenes.Id, imagenes.Imagenes);
                return Ok(imagenResultado);
            }
            catch (Exception ex)
            {
                return BadRequest("Error al cargar imágenes: " + ex.Message);
            }
        }

        public void Put(int id, [FromBody] ArticuloDto articulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Id = id;
            nuevo.Codigo = articulo.Codigo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.Descripcion = articulo.Descripcion;
            nuevo.Marca = new Marca { Id = articulo.idMarca };
            nuevo.Categoria = new Categoria { Id = articulo.IdCategoria };
            nuevo.Imagen = articulo.Imagen;
            nuevo.Precio = articulo.Precio;
            negocio.modificar(nuevo);
        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
