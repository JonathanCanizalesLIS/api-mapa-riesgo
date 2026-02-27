using MantenimientoAPI.Classes;
using MantenimientoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Mantenimiento.API.BusinessLogic
{
    public class UsuarioBusiness : IUsuario
    {

        //private MantenimientoContext MantenimientoContext;
        //public UsuarioBusiness(MantenimientoContext mantenimientoContext)
        //{
        //    MantenimientoContext = mantenimientoContext;
        //}


        //public IEnumerable<UsuarioConsulta> ConsultarUsuario()
        //{
        //    return MantenimientoContext.Usuarios                
        //        .Include(u => u.IdEmpresaNavigation)
        //        .Include(u => u.IdEmpresaNavigation.IdSistemaNavigation)
        //        .Where(FiltroEmpresa)
        //        .Where(u => u.Estatus == "A")
        //        .Select(usuario => new UsuarioConsulta
        //        {
        //            IdUsuario = usuario.IdUsuario,
        //            IdUsuarioExterno = usuario.IdUsuarioExterno,
        //            IdEmpresaExterno = usuario?.IdEmpresaNavigation.IdEmpresaExterno.Value ?? usuario.IdEmpresaNavigation.IdEmpresa,
        //            IdSistema = usuario.IdEmpresaNavigation.IdSistema,
        //            Sistema = usuario.IdEmpresaNavigation.IdSistemaNavigation.Nombre,
        //            Nombre  = usuario.Nombre,
        //            ApellidoPaterno  = usuario.ApellidoPaterno,
        //            ApellidoMaterno  = usuario.ApellidoMaterno,
        //            Email  = usuario.Email,
        //            Puesto = usuario.Puesto,
        //            Estatus  = usuario.Estatus
        //        }).ToArray();
        //}

        //public string AgregarUsuario(UsuarioInsertar usuario)
        //{
        //    var nuevo = new Usuario()
        //    {
        //        IdUsuario = usuario.IdUsuario,
        //        IdUsuarioExterno = usuario.IdUsuarioExterno,
        //        //IdEmpresaExterno = usuario.IdEmpresaExterno,
        //        //IdSistema = usuario.IdSistema,
        //        IdEmpresa = usuario.IdEmpresa,
        //        Nombre = usuario.Nombre,
        //        ApellidoPaterno = usuario.ApellidoPaterno,
        //        ApellidoMaterno = usuario.ApellidoMaterno,
        //        Email = usuario.Email,
        //        Contrasena = usuario.Contrasena,
        //        Puesto = usuario.Puesto,
        //        Estatus = "A"
        //    };

        //    MantenimientoContext.Usuarios.Add(nuevo);
        //    MantenimientoContext.SaveChanges();

        //    return nuevo.IdUsuario.ToString();
        //}

        //public string ActualizarUsuario(UsuarioInsertar usuario)
        //{
        //    var actualizado = MantenimientoContext.Usuarios.Where(u => u.IdUsuario == usuario.IdUsuario).First();

        //    actualizado.IdUsuario = usuario.IdUsuario;
        //    actualizado.IdUsuarioExterno = usuario.IdUsuarioExterno;
        //    //actualizado.IdEmpresaExterno = usuario.IdEmpresaExterno;
        //    //actualizado.IdSistema = usuario.IdSistema;
        //    actualizado.Nombre = usuario.Nombre;
        //    actualizado.ApellidoPaterno = usuario.ApellidoPaterno;
        //    actualizado.ApellidoMaterno = usuario.ApellidoMaterno;
        //    actualizado.Email = usuario.Email;
        //    actualizado.Contrasena = actualizado.Contrasena;
        //    actualizado.Puesto = usuario.Puesto;
        //    actualizado.Estatus = actualizado.Estatus;

        //    MantenimientoContext.Usuarios.Update(actualizado);
        //    MantenimientoContext.SaveChanges();

        //    return actualizado.IdUsuario.ToString();
        //}

        //public string EliminarUsuario(int idUsuario)
        //{
        //    var baja = MantenimientoContext.Usuarios.Where(u => u.IdUsuario == idUsuario).First();
        //    baja.Estatus = "B";
        //    MantenimientoContext.Usuarios.Update(baja);
        //    MantenimientoContext.SaveChanges();

        //    return baja.IdUsuario.ToString();
        //}

        //public string RestablecerContraseña(int idUsuario, string contraseñaNueva, string repetirContraseña)
        //{
        //    var usuario = MantenimientoContext.Usuarios.Where(u => u.IdUsuario == idUsuario).First();

        //    if (contraseñaNueva == repetirContraseña)
        //        usuario.Contrasena = contraseñaNueva;
        //    else
        //        throw new Exception("Las contraseñas no coiniciden");

        //    MantenimientoContext.Usuarios.Update(usuario);
        //    MantenimientoContext.SaveChanges();
        //    return usuario.IdUsuario.ToString();
        //}



        ////Func<Insumo, bool> FiltroEmpresa = (i) => i.IdEmpresa == 3042;
        //Func<Usuario, bool> FiltroEmpresa = (i) => true;

    }
}
