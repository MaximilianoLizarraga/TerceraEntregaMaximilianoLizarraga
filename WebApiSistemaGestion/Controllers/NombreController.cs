using Microsoft.AspNetCore.Mvc;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // ingreso la ruta. si pongo [Controller] toma el nombre de la clase sin el controller ejemplo : NombreController ahora sera api/Nombre
    public class NombreController : Controller
    {
        List<string> list;

        public NombreController() {
            this.list=new List<string>() {"Pepe","Alejandro", "Marcos" }; //instancia de lista en el constructor
        }

        [HttpGet("obtenerNombre")] //Especifico el tipo de solicitudo para el metodo en este caso GET y en el string si quiero ponerlo la direccion adicional en este caso sera /api/federico/obtenerNombre sin o pongo nada sera solo /api/federico esta sera el nuevo endpoint
        public string ObtenerNombre() // el metodo puede ser cualquiera
        {
            return "Federico Garea";
        }

        [HttpGet("listadoNombres")]
        public List<string> ListadoDeNombres()
        {
            return this.list;
        }

        [HttpGet("listaNombresSegundaForma")]

        public List<string> ListadoDeNombresSegundaForma()
        {
            //se instancia y se envia dentro del metodo
            List<string>lista2 = new List<string>() { "Fede", "Maxi", "Carlos" };
            return lista2;
        }

        [HttpGet("ObtenerNombreporId/{id}")] // al poner las lalves {} le pasamos el parametro en este caso el id
        //Ejemplo https://localhost:7153/api/Nombre/listadoNombres/1 me devuelve a Alejandro 

        public ActionResult<string> ObtenerNombreporId(int id)
        {
            if(id<0 || id >= list.Count)
            {
                return BadRequest(new { mensaje=$"el numero ID no puede ser negativo o mayor que {this.list.Count} ", Status= "400" });
            }
            return this.list[id];

        }
    }
}
