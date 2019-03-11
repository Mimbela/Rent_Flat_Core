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

        public async Task<List<Costas>> GetCostasAsync()
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


    }
}
