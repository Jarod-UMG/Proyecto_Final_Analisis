using Microsoft.AspNetCore.Mvc;
using System.Linq;
using APICLIENTES.Models;

namespace APICLIENTES.Controllers
{
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private Conexion dbConexion;
        public ClientesController()
        {
            dbConexion = Conectar.Create();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dbConexion.Clientes.ToArray());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id){
            var Clientes = dbConexion.Clientes.SingleOrDefault(a => a.id_cliente == id);
            if(Clientes != null){
                return Ok(Clientes);
            }else{                
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Clientes Clientes){
             if (ModelState.IsValid){
                dbConexion.Clientes.Add(Clientes);
                dbConexion.SaveChanges();
                return Ok(Clientes);
             }else{
                return NotFound();
             }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Clientes Clientes){
             var v_Clientes = dbConexion.Clientes.SingleOrDefault(a => a.id_cliente == Clientes.id_cliente);
            if (v_Clientes != null && ModelState.IsValid) {
            dbConexion.Entry(v_Clientes).CurrentValues.SetValues(Clientes);
            dbConexion.SaveChanges();
                return Ok();
            } else {
                return NotFound();
            }
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            var Clientes = dbConexion.Clientes.SingleOrDefault(a => a.id_cliente == id);
            if(Clientes != null){
                dbConexion.Clientes.Remove(Clientes);
                dbConexion.SaveChanges();
                return Ok();
            }else {
                return NotFound();
            }
        }
    }
}