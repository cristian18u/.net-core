
using Microsoft.AspNetCore.Mvc;
using proyect_api.Models;

namespace proyect_api.Controllers


{
    [ApiController]
    [Route("client")]
    public class ClienteController : ControllerBase
    {
        // [ApiController]
        [HttpGet]
        [Route("listar")]

        public dynamic listartCliente(string name)  //este es por query params listar?name=cristian
        {
            // ya esto es dentro del get
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "4",
                    nombre = "cris",
                    edad = "7",
                    email = "cristian18u@gmail.com"
                },
                new Cliente
                {
                    id = "7",
                    nombre = "raul",
                    edad = "25",
                    email = "raulvanegas711@gmail.com"
                },
                new Cliente
                {
                    id = "20",
                    nombre = name,
                    edad = "25",
                    email = "raulvanegas711@gmail.com"
                }
            };
            return clientes;
        }

        [HttpPost]
        [Route("guardar")]

        public dynamic guardarCliente(Cliente user)
        {
            List<Cliente> client = new List<Cliente>
            {
                new Cliente
                {
                    id = user.id,
                    nombre = user.nombre,
                    email = user.email,
                    edad = user.edad
                }
            };
            return client;
        }
        [HttpPost]
        [Route("eliminar")]

        public dynamic eliminarCliente(Cliente user)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;  // para desencriptar endpoints
            if (token == "marco123")
            {
                ;
                // else 
                List<Cliente> client = new List<Cliente>
            {
                new Cliente
                {
                    id = user.id,
                    nombre = user.nombre,
                    email = user.email,
                    edad = user.edad
                }
            };
                return client;
            }
            else return "cristian";
        }
    }
}