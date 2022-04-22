using Microsoft.AspNetCore.Mvc;
using CoreMVCEntityFramework.Datos;
using Microsoft.EntityFrameworkCore;
using CoreMVCEntityFramework.Models;

namespace CoreMVCEntityFramework.Controllers
{
    public class UsuariosController : Controller
    {


        #region BASE DE DATOS

        //TRAEMOS EL APPLICATION DB CONTEXT
        private readonly ApplicationDBContext BD;

        //CONEXION A LA BASE DE DATOS
        public UsuariosController(ApplicationDBContext contexto)
        {
            BD = contexto;
        }
        #endregion

        #region LISTAR_USUARIOS
        //METODO TIPO GET PARA OBTENER DATOS
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //RETORNAMOS UNA LISTA
            return View(await BD.Usuario.ToListAsync());
        }

        #endregion

        #region CREAR_USUARIO
        //ACCION CREAR
        [HttpGet]
        public IActionResult Crear()
        {
            //RETORNAMOS UNA LISTA
            return View("Crear");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(UsuarioCLS oUsuarioCLS)
        {
            if (ModelState.IsValid)
            {


                //AGREGAMOS EL CAMBIO
                BD.Usuario.Add(oUsuarioCLS);

                //GUARDAMOS LOS CAMBIOS
                await BD.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(oUsuarioCLS);
         
        }

        #endregion

        #region EDITAR_USUARIO

        //OBTENER LOS CAMPOS POR EL ID
        [HttpGet]
        public IActionResult Editar(int? ID)
        {
            var usuario = BD.Usuario.Find(ID);

            if(ID == null)
            {
                return NotFound("No se encontro el usuario");
            }

            if(usuario == null)
            {
                return NotFound("No se encontro el usuario");
            }

            return View(usuario);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(UsuarioCLS oUsuarioCLS)
        {
            if (ModelState.IsValid)
            {
                //AGREGAMOS EL CAMBIO
                BD.Usuario.Update(oUsuarioCLS);

                //GUARDAMOS LOS CAMBIOS
                await BD.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(oUsuarioCLS);

        }

        #endregion

        #region DETALLE DEL USUARIO

        //OBTENER LOS CAMPOS POR EL ID
        [HttpGet]
        public IActionResult Detalle(int? ID)
        {
            var usuario = BD.Usuario.Find(ID);

            if (ID == null)
            {
                return NotFound("No se encontro el usuario");
            }

            if (usuario == null)
            {
                return NotFound("No se encontro el usuario");
            }

            return View(usuario);
        }
        #endregion

        #region ELIMINAR_USUARIO
        [HttpGet]
        
        public IActionResult Borrar(int? ID)
        {
            var usuario = BD.Usuario.Find(ID);

            if (ID == null)
            {
                return NotFound("No se encontro el usuario");
            }

            if (usuario == null)
            {
                return NotFound("No se encontro el usuario");
            }

            return View(usuario);
        }

        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarUsuario(int? ID)
        {
            var usuario = await BD.Usuario.FindAsync(ID);

            //SI EL USUARIO ES NULO
            if(usuario == null)
            {
                //
                return View();
            }

            //ELIMINE DE LA BASE DE DATOS EL USUARIO
            BD.Usuario.Remove(usuario);

            //GUARDE LOS CAMBIOS
            await BD.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

        #endregion
    } 
}
