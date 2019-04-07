using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;//agrego
using System.Net.Http.Headers;
using Rent_Flat_Core.Models;
using Newtonsoft.Json;

namespace Rent_Flat_Core.Repositories
{
    public class RepositoryApiRent
    {
        private string uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;

        public RepositoryApiRent()
        {
           // this.uriapi = "https://apirentflatmvc.azurewebsites.net/";
            this.uriapi = "http://localhost:5179/";
            this.headerjson = new MediaTypeWithQualityHeaderValue("application/json");

        }
        //----------------------------------------------------------------------------------------------------------

        public async Task<Clientes> BuscarClientesAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/BuscarClientes/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Clientes clientes =
                    await response.Content.ReadAsAsync<Clientes>();
                    return clientes;
                }
                else
                {
                    return null;
                }

            }
        }
        public async Task<Costas> BuscarCostaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/BuscarCosta/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Costas costa =
                    await response.Content.ReadAsAsync<Costas>();
                    return costa;
                }
                else
                {
                    return null;
                }

            }
        }
        public async Task<Tipos_Vivienda> BuscarTipoViviendaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/BuscarTipoVivienda/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Tipos_Vivienda t =
                    await response.Content.ReadAsAsync<Tipos_Vivienda>();
                    return t;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<Viviendas> BuscarViviendaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/BuscarVivienda/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Viviendas t =
                    await response.Content.ReadAsAsync<Viviendas>();
                    return t;
                }
                else
                {
                    return null;
                }

            }
        }
        public async Task<Usuarios> BuscarUsuarioAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/BuscarUsuario/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Usuarios t =
                    await response.Content.ReadAsAsync<Usuarios>();
                    return t;
                }
                else
                {
                    return null;
                }

            }
        }

        //-------------------------------------------------------------------------------------------------
        public async Task EliminarClienteAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarCliente/" + id;
                
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }

        public async Task EliminarCostaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarCosta/" + id;

                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }

        public async Task EliminarTipoViviendaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarTipoVivienda/" + id;

                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }

        public async Task EliminarViviendaAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarVivienda/" + id;

                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }


        public async Task EliminarUsuarioAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarUsuario/" + id;

                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }


        //-------------------------------------------------------------------------------------------
        public async Task<List<Clientes>> GetClientesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetClientes";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Clientes> clientes =
                    await response.Content.ReadAsAsync<List<Clientes>>();
                    return clientes;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<List<Costas>> GetNombreCostasAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetNombreCostas";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Costas> costas =
                    await response.Content.ReadAsAsync<List<Costas>>();
                    return costas;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<List<Tipos_Vivienda>> GetTiposViviendasAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetTiposViviendas";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Tipos_Vivienda> tipos =
                    await response.Content.ReadAsAsync<List<Tipos_Vivienda>>();
                    return tipos;
                }
                else
                {
                    return null;
                }

            }


        }
        public async Task<List<Viviendas>> GetViviendasAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetViviendas";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Viviendas> viviendas =
                    await response.Content.ReadAsAsync<List<Viviendas>>();
                    return viviendas;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<List<Usuarios>> GetUsuariosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetNombreUsuario";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Usuarios> usuarios =
                    await response.Content.ReadAsAsync<List<Usuarios>>();
                    return usuarios;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<List<VIVIENDASPORFILTRO>> GetViviendasByFilterAsync(BusquedaModel busqueda)
        {
            using (HttpClient client = new HttpClient())
            {
                string peticion = "api/GetViviendasByFilter";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                BusquedaModel responseParameter = new BusquedaModel();
                responseParameter.TiposViviendaSelectedValue = busqueda.TiposViviendaSelectedValue;
                responseParameter.CostasSelectedValue = busqueda.CostasSelectedValue;
                responseParameter.NumeroBaniosSelectedValue = busqueda.NumeroBaniosSelectedValue;
                responseParameter.NumeroHabitacionesSelectedValue = busqueda.NumeroHabitacionesSelectedValue;
                responseParameter.Cod_Casa = busqueda.Cod_Casa;
                responseParameter.Cod_Cliente = busqueda.Cod_Cliente;

                string json = JsonConvert.SerializeObject(responseParameter);

                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await
                    client.PostAsync(peticion,content);
                if (response.IsSuccessStatusCode)
                {
                    List<VIVIENDASPORFILTRO> viviendas =
                    await response.Content.ReadAsAsync<List<VIVIENDASPORFILTRO>>();
                    return viviendas;
                }
                else
                {
                    return null;
                }

            }
        }
        
        //--------------------------------------
        
            //-----------------------

        public async Task InsertarClienteAsync(Clientes cl)
        {
            using (HttpClient client=new HttpClient())
            {
                String peticion = "api/InsertarCliente";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Clientes dept = new Clientes();
                dept.ApellidoCliente = cl.ApellidoCliente;
                dept.Ciudad = cl.Ciudad;
                dept.Direccion = cl.Direccion;
                dept.Dni = cl.Dni;
                dept.EmailCliente = cl.EmailCliente;
                dept.IdCliente = cl.IdCliente;
                dept.NombreCliente = cl.NombreCliente;
                dept.Telefono = cl.Telefono;
                

                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }

        public async Task InsertarCostaAsync(Costas cl)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/InsertarCosta";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Costas dept = new Costas();
                dept.Cod_Provincia = cl.Cod_Provincia;
                dept.Foto = cl.Foto;
                dept.NombreProvincia = cl.NombreProvincia;
                


                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }

        public async Task InsertarTipoViviendaAsync(Tipos_Vivienda cl)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/InsertarTipoVivienda";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Tipos_Vivienda dept = new Tipos_Vivienda();
                dept.Cod_tipo_vivienda = cl.Cod_tipo_vivienda;
                dept.Descripcion = cl.Descripcion;
               
                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }
        public async Task<int> InsertarViviendaAsync(Viviendas cl)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/InsertarVivienda";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Viviendas dept = new Viviendas();
                dept.Cod_casa = cl.Cod_casa;
                dept.Ciudad = cl.Ciudad;
                dept.Codigo_Posta = cl.Codigo_Posta;
                dept.Cod_Provincia = cl.Cod_Provincia;
                dept.Cod_TipoVivienda = cl.Cod_TipoVivienda;
                dept.Descripcion = cl.Descripcion;
                dept.Garaje = cl.Garaje;
                dept.IdCliente = cl.IdCliente;
                dept.Num_banios = cl.Num_banios;
                dept.Num_habitaciones= cl.Num_habitaciones;
                dept.Tamanio_vivienda = cl.Tamanio_vivienda;
                dept.Ubicacion = cl.Ubicacion;

                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {
                    int viviendainsertada =
                   await response.Content.ReadAsAsync<int>();
                    return viviendainsertada;
                }
                return 0;
            }
        }

        public async Task InsertarUsuarioAsync(Usuarios cl)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/InsertarUsuario";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Usuarios dept = new Usuarios();
                dept.Apellido = cl.Apellido;
                dept.Cod_usuario = cl.Cod_usuario;
                dept.DIR = cl.DIR;
                dept.Email = cl.Email;
                dept.Login = cl.Login;
                dept.Mostrar_info_contacto = cl.Mostrar_info_contacto;
                dept.Nombre = cl.Nombre;
                dept.Password = cl.Password;
                dept.Perfil = cl.Perfil;
                dept.Telefono = cl.Telefono;
                

                String json = JsonConvert.SerializeObject(dept);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }

        //--------------------------------------------

        public async Task ModificarClienteAsync(Clientes cl, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ModificarCliente/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Clientes dept = new Clientes();
                dept.ApellidoCliente = cl.ApellidoCliente;
                
                dept.Ciudad = cl.Ciudad;
                dept.Direccion = cl.Direccion;
                dept.Dni = cl.Dni;
                dept.EmailCliente = cl.EmailCliente;
                dept.IdCliente = cl.IdCliente;
                dept.NombreCliente = cl.NombreCliente;
                dept.Telefono = cl.Telefono;
                

                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }

        public async Task ModificarCostaAsync(Costas cl, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ModificarCosta/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Costas dept = new Costas();
                dept.Cod_Provincia = cl.Cod_Provincia;
                dept.Foto = cl.Foto;
                dept.NombreProvincia = cl.NombreProvincia;
                


                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }

        public async Task ModificarTipoViviendaAsync(Tipos_Vivienda cl, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ModificarTipoVivienda/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Tipos_Vivienda dept = new Tipos_Vivienda();
                dept.Cod_tipo_vivienda = cl.Cod_tipo_vivienda;
                dept.Descripcion = cl.Descripcion;
                



                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }


        public async Task ModificarViviendaAsync(Viviendas cl, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ModificarVivienda/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Viviendas dept = new Viviendas();
                dept.Ciudad = cl.Ciudad;
                dept.Codigo_Posta = cl.Codigo_Posta;
                dept.Cod_casa = cl.Cod_casa;
                dept.Cod_Provincia = cl.Cod_Provincia;
                dept.Cod_TipoVivienda = cl.Cod_TipoVivienda;
                dept.Descripcion = cl.Descripcion;
                dept.Garaje = cl.Garaje;
                dept.IdCliente = cl.IdCliente;
                dept.Num_banios = cl.Num_banios;
                dept.Num_habitaciones = cl.Num_habitaciones;
                dept.Tamanio_vivienda = cl.Tamanio_vivienda;
                dept.Ubicacion = cl.Ubicacion;
                



                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }

        public async Task ModificarUsuarioAsync(Usuarios cl, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ModificarUsuario/" + id;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Usuarios dept = new Usuarios();
                dept.Apellido = cl.Apellido;
                dept.Cod_usuario = cl.Cod_usuario;
                dept.DIR = cl.DIR;
                dept.Email = cl.Email;
                dept.Login = cl.Login;
                dept.Mostrar_info_contacto = cl.Mostrar_info_contacto;
                dept.Nombre = cl.Nombre;
                dept.Password = cl.Password;
                dept.Perfil = cl.Perfil;
                dept.Telefono = cl.Telefono;
                




                String json = JsonConvert.SerializeObject(dept);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }
    }
}
