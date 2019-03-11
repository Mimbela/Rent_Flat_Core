using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rent_Flat_Core.Data;
using Rent_Flat_Core.Models;

namespace Rent_Flat_Core.Repositories
{
    public class Repository : IRepository
    {
        IRentContext context;

        public Repository(IRentContext context)
        {
            this.context = context;
        }
        #region

        //public Clientes BuscarClientes(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Costas BuscarCosta(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Usuarios BuscarEmpleado(string login)
        //{
        //    throw new NotImplementedException();
        //}

        //public Tipos_Vivienda BuscarTipoVivienda(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Usuarios BuscarUsuario(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Viviendas BuscarViviendas(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Dictionary<int, string> ComboRolUsuario()
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarClientes(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarCosta(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarTipoViviendas(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarUsuario(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarViviendas(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Usuarios ExisteEmpleado(string login, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Clientes> GetClientes()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Usuarios> GetEmpleadosSubordinaros(int director)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Costas> GetNombreCostas()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Tipos_Vivienda> GetTiposViviendas()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Usuarios> GetUsuarios()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Viviendas> GetViviendas()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<VIVIENDASPORFILTRO_Result> GetViviendasByFilter(int TipoVivienda, int Costa, int Banios, int Habitaciones, int Cod_Casa, int Cod_Cliente)
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertarClientes(Clientes modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertarCosta(Costas modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public int InsertarImagen(Galeria_Fotos model)
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertarTipoViviendas(Tipos_Vivienda modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertarUsuarios(Usuarios modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public int InsertarViviendas(Viviendas modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ModificarClientes(Clientes modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ModificarCosta(Costas modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ModificarTipoVivienda(Tipos_Vivienda modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ModificarUsuario(Usuarios modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ModificarVivienda(Viviendas modelo)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<VISTATODOSCLIENTES> PaginarClientes(int indice, ref int totalregistros)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

        public Costas BuscarCosta(int id)
        {
            var consulta = from datos in context.Costas
                           where datos.Cod_Provincia == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Usuarios BuscarEmpleado(string login)
        {
            var consulta = from datos in context.Usuarios
                           where datos.Login == login
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Tipos_Vivienda BuscarTipoVivienda(int id)
        {
            var consulta = from datos in context.Tipos_Vivienda
                           where datos.Cod_tipo_vivienda == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Usuarios BuscarUsuario(int id)
        {
            var consulta = from datos in context.Usuarios
                           where datos.Cod_usuario == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Viviendas BuscarViviendas(int id)
        {
            var consulta = from datos in context.Viviendas
                           where datos.Cod_casa == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public Dictionary<int, string> ComboRolUsuario()
        {
            Dictionary<int, string> listaPerfiles = new Dictionary<int, string>();//el primer valor que es la key es única
            listaPerfiles.Add(15, "Director");
            listaPerfiles.Add(30, "Comercial");



            return listaPerfiles;
        }

        public void EliminarCosta(int id)
        {
            Costas costas = this.BuscarCosta(id);
            this.context.Costas.Remove(costas);
            this.context.SaveChanges();
        }

        public void EliminarTipoViviendas(int id)
        {

            Tipos_Vivienda tipos = this.BuscarTipoVivienda(id);
            this.context.Tipos_Vivienda.Remove(tipos);
            this.context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {

            Usuarios usuarios = this.BuscarUsuario(id);
            this.context.Usuarios.Remove(usuarios);
            this.context.SaveChanges();
        }

        public void EliminarViviendas(int id)
        {

            Viviendas viviendas = this.BuscarViviendas(id);
            this.context.Viviendas.Remove(viviendas);
            this.context.SaveChanges();
        }

        public Usuarios ExisteEmpleado(string login, string password)
        {
            var consulta = from datos in context.Usuarios
                           where datos.Login == login
                           && datos.Password == password
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Usuarios> GetEmpleadosSubordinaros(int director)
        {
            var consulta = from datos in context.Usuarios
                           where datos.DIR == director
                           select datos;

            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }

        }

        public List<Costas> GetNombreCostas()
        {
            return this.context.Costas.ToList();
        }



        public List<Tipos_Vivienda> GetTiposViviendas()
        {
            return this.context.Tipos_Vivienda.ToList();
        }

        public List<Usuarios> GetUsuarios()
        {
            return this.context.Usuarios.ToList();
        }

        public List<Viviendas> GetViviendas()
        {


            return this.context.Viviendas.ToList();
        }





        public void InsertarCosta(Costas modelo)
        {
            Costas cost = new Costas();
            cost.Cod_Provincia = modelo.Cod_Provincia;
            cost.Foto = modelo.Foto;
            cost.NombreProvincia = modelo.NombreProvincia;
            this.context.Costas.Add(cost);
            this.context.SaveChanges();
        }

        public void InsertarTipoViviendas(Tipos_Vivienda modelo)
        {
            Tipos_Vivienda tipo = new Tipos_Vivienda();
            tipo.Cod_tipo_vivienda = modelo.Cod_tipo_vivienda;
            tipo.Descripcion = modelo.Descripcion;
            this.context.Tipos_Vivienda.Add(tipo);
            this.context.SaveChanges();
        }

        public void InsertarUsuarios(Usuarios modelo)
        {
            Usuarios usu = new Usuarios();
            usu.Apellido = modelo.Apellido;
            usu.DIR = modelo.DIR;

            usu.Email = modelo.Email;
            usu.Login = modelo.Login;
            usu.Mostrar_info_contacto = modelo.Mostrar_info_contacto;
            usu.Nombre = modelo.Nombre;
            usu.Password = modelo.Password;
            usu.Perfil = modelo.Perfil;
            usu.Telefono = modelo.Telefono;

            this.context.Usuarios.Add(usu);
            this.context.SaveChanges();


        }

        public int InsertarViviendas(Viviendas modelo)
        {
            Viviendas v = new Viviendas();
            v.Ciudad = modelo.Ciudad;
            v.Codigo_Posta = modelo.Codigo_Posta;
            //v.Cod_casa = modelo.Cod_casa;
            v.Cod_Provincia = modelo.Cod_Provincia;
            v.Descripcion = modelo.Descripcion;
            v.Garaje = modelo.Garaje;
            v.IdCliente = modelo.IdCliente;
            v.Num_banios = modelo.Num_banios;
            v.Num_habitaciones = modelo.Num_habitaciones;
            v.Tamanio_vivienda = modelo.Tamanio_vivienda;
            v.Ubicacion = modelo.Ubicacion;
            v.Cod_TipoVivienda = modelo.Cod_TipoVivienda;


            this.context.Viviendas.Add(v);

            this.context.SaveChanges();

            return v.Cod_casa;

        }

        public int InsertarImagen(Galeria_Fotos model)
        {
            Galeria_Fotos galeria = new Galeria_Fotos();
            galeria.Cod_casa = model.Cod_casa;
            galeria.Foto = model.Foto;
            galeria.Orden = model.Orden;

            this.context.Galeria_Fotos.Add(galeria);

            this.context.SaveChanges();

            return galeria.Cod_imagen;
        }


        public void ModificarCosta(Costas modelo)
        {
            //Costas costa = (from x in entidad.Costas
            //               where x.Cod_Provincia == c.Cod_Provincia
            //               select x).FirstOrDefault();

            //Costas cost = this.entidad.Costas.Where(z => z.Cod_Provincia == c.Cod_Provincia).FirstOrDefault();

            Costas cost = this.context.Costas.Single(z => z.Cod_Provincia == modelo.Cod_Provincia);
            cost.NombreProvincia = modelo.NombreProvincia;
            cost.Foto = modelo.Foto;

            this.context.SaveChanges();

        }

        public void ModificarTipoVivienda(Tipos_Vivienda modelo)
        {
            Tipos_Vivienda tipo = this.context.Tipos_Vivienda.Single(z => z.Cod_tipo_vivienda == modelo.Cod_tipo_vivienda);
            tipo.Descripcion = modelo.Descripcion;


            this.context.SaveChanges();
        }

        public void ModificarUsuario(Usuarios modelo)
        {
            Usuarios tipo = this.context.Usuarios.Single(z => z.Cod_usuario == modelo.Cod_usuario);
            tipo.Apellido = modelo.Apellido;
            tipo.DIR = modelo.DIR;
            tipo.Email = modelo.Email;
            tipo.Login = modelo.Login;
            tipo.Mostrar_info_contacto = modelo.Mostrar_info_contacto;
            tipo.Nombre = modelo.Nombre;
            tipo.Password = modelo.Password;
            tipo.Telefono = modelo.Telefono;
            tipo.Perfil = modelo.Perfil;

            this.context.SaveChanges();

        }

        public void ModificarVivienda(Viviendas modelo)
        {
            Viviendas tipo = this.context.Viviendas.Single(z => z.Cod_casa == modelo.Cod_casa);
            tipo.Ciudad = modelo.Ciudad;
            tipo.Codigo_Posta = modelo.Codigo_Posta;
            tipo.Cod_Provincia = modelo.Cod_Provincia;
            tipo.Descripcion = modelo.Descripcion;
            tipo.Garaje = modelo.Garaje;
            tipo.IdCliente = modelo.IdCliente;
            tipo.Num_banios = modelo.Num_banios;
            tipo.Num_habitaciones = modelo.Num_banios;
            tipo.Tamanio_vivienda = modelo.Tamanio_vivienda;
            tipo.Ubicacion = modelo.Ubicacion;
            tipo.Cod_TipoVivienda = modelo.Cod_TipoVivienda;

            this.context.SaveChanges();
        }

        //public List<VISTATODOSCLIENTES> PaginarClientes(int indice, ref int totalregistros)
        //{
        //    totalregistros = context.VISTATODOSCLIENTES.Count();
        //    var consulta = (from datos in context.VISTATODOSCLIENTES
        //                    orderby datos.ApellidoCliente ascending
        //                    select datos).Skip(indice).Take(5).ToList();
        //    //totalregistros = consulta.Count();

        //    return consulta;
        //}

        public List<Clientes> GetClientes()
        {
            return this.context.Clientes.ToList();
        }

        public Clientes BuscarClientes(int id)
        {
            var consulta = from datos in context.Clientes
                           where datos.IdCliente == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void ModificarClientes(Clientes modelo)
        {
            Clientes tipo = this.context.Clientes.Single(z => z.IdCliente == modelo.IdCliente);
            tipo.Dni = modelo.Dni;
            tipo.ApellidoCliente = modelo.ApellidoCliente;
            tipo.Ciudad = modelo.Ciudad;
            tipo.Direccion = modelo.Direccion;
            tipo.EmailCliente = modelo.EmailCliente;
            tipo.IdCliente = modelo.IdCliente;
            tipo.NombreCliente = modelo.NombreCliente;
            tipo.Telefono = modelo.Telefono;

            this.context.SaveChanges();
        }

        public void InsertarClientes(Clientes modelo)
        {
            Clientes tipo = new Clientes();
            tipo.Dni = modelo.Dni;
            tipo.ApellidoCliente = modelo.ApellidoCliente;
            tipo.Ciudad = modelo.Ciudad;
            tipo.Direccion = modelo.Direccion;
            tipo.EmailCliente = modelo.EmailCliente;
            tipo.IdCliente = modelo.IdCliente;
            tipo.NombreCliente = modelo.NombreCliente;
            tipo.Telefono = modelo.Telefono;

            this.context.Clientes.Add(tipo);
            this.context.SaveChanges();


        }
        public void EliminarClientes(int id)
        {
            Clientes cl = this.BuscarClientes(id);
            this.context.Clientes.Remove(cl);
            context.SaveChanges();




        }

        public List<VIVIENDASPORFILTRO> GetViviendasByFilter(int TipoVivienda, int Costa, int Banios, int Habitaciones, int Cod_Casa, int Cod_Cliente)
        {
            return (this.context.GetViviendasByFilter(TipoVivienda, Costa, Banios, Habitaciones, Cod_Casa, Cod_Cliente).ToList());
        }
    }
}

//public List<VIVIENDASPORFILTRO_Result> GetViviendasByFilter(int TipoVivienda, int Costa, int Banios, int Habitaciones, int Cod_Casa, int Cod_Cliente)
//{
//    return (this.context.VIVIENDASPORFILTRO(TipoVivienda, Costa, Banios, Habitaciones, Cod_Casa, Cod_Cliente).ToList());
//}



//public List<VIVIENDASPORFILTRO_Result> GetViviendasByFilter(int TipoVivienda, int Costa, int Banios, int Habitaciones)
//{
//    return (this.entidad.VIVIENDASPORFILTRO( TipoVivienda,  Costa,  Banios,  Habitaciones).ToList());
//}

//public List<Viviendas> GetViviendasByFilter(int TipoVivienda, int Costa, int Banios, int Habitaciones)
//{

//    List<Viviendas> listaViviendas = this.entidad.Viviendas.Where(x => 
//        (TipoVivienda == 0 || x.Cod_TipoVivienda == TipoVivienda) 
//        && (Costa == 0 || x.Cod_Provincia == Costa) 
//        && (Banios == 0 || x.Num_banios >= Banios) 
//        && (Habitaciones == 0 || x.Num_habitaciones >= Habitaciones)).ToList();


//    return listaViviendas;
//}