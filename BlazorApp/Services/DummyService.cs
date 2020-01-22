using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using SharedModelLibrary.ViewModel;
using SharedModelLibrary.BindModel;

namespace BlazorApp
{
    public class DummyService
    {
        private readonly HttpClient _httpClient;

        public DummyService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Task<List<DrawerBindItem>> GetMenuListAsync()
        {
            return GetApiDataAsync<List<DrawerBindItem>>($"api/dummy/getmenulist");
        }

        public Task<List<ListBindItem<string>>> GetSelectListStringAsync()
        {
            return GetApiDataAsync<List<ListBindItem<string>>>($"api/dummy/getselectliststring");
        }

        public Task<List<ListBindItem<int?>>> GetSelectListIntAsync()
        {
            return GetApiDataAsync<List<ListBindItem<int?>>>($"api/dummy/getselectlistint");
        }

        public Task<DummyView> GetDummyAsync(string textField, string textArea, string select, string radio)
        {
            return GetApiDataAsync<DummyView>($"api/dummy/getdummy/{textField}/{textArea}/{select}/{radio}");
        }

        protected async Task<T> GetApiDataAsync<T>(string relativeUri)
        {
            HttpResponseMessage response = await this._httpClient.GetAsync(relativeUri);
            T data = default(T);

            response.EnsureSuccessStatusCode();

            //using (Stream responseStream = await response.Content.ReadAsStreamAsync())
            //{
            //    data = await JsonSerializer.DeserializeAsync<T>(responseStream);
            //}
            string json = await response.Content.ReadAsStringAsync();
            data = JsonSerializer.Deserialize<T>(json);

            return data;
        }
    }
}
