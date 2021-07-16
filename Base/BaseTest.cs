using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Store.Test.Rest;
using Store.Test.Dtos.PostAndPut;

namespace Store.Test.Base
{
    public class BaseTest
    {
        public ServiceProvider ServiceProvider { get; }

        public BaseTest()
        {
            var services = new ServiceCollection().AddTransient<IConfiguration>(sp => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build());

            ServiceProvider = services.BuildServiceProvider();
            var config = ServiceProvider.GetService<IConfiguration>();

            Endpoints.BaseURI = config["Settings:BaseURI"];
            Endpoints.Acompanhamentocompra = config["Settings:Acompanhamento"];
            Endpoints.Caracteristica = config["Settings:Caracteristica"];
            Endpoints.Categories = config["Settings:Categoria"];
            Endpoints.Cliente = config["Settings:Cliente"];
            Endpoints.Compra = config["Settings:Compra"];
            Endpoints.Condicaopagamento = config["Settings:Condicaopagamento"];
            Endpoints.Departamento = config["Settings:Departamento"];
            Endpoints.Fabricante = config["Settings:Fabricante"];
            Endpoints.Grupo = config["Settings:Grupo"];
            Endpoints.Itemcompra = config["Settings:ItemCompra"];
            Endpoints.Prazopagamento = config["Settings:Prazo"];
            Endpoints.Products = config["Settings:Produtos"];
            Endpoints.Produtocaracteristica = config["Settings:ProdutoCaracteristica"];
            Endpoints.Promocao = config["Settings:Promocao"];
            Endpoints.Promocaoproduto = config["Settings:Promocaoproduto"];
            Endpoints.Situacao = config["Settings:Situacao"];
        }


        protected static async Task<T> Get<T>(string baseUri, string endpoint)
        {   
            var request = new DataRequest<T>(baseUri);
            var result = await request.Get(endpoint);

            return result;
        }

        protected static async Task<T> Patch<T>(string baseUri, string endpoint, object command, string token = "")
        {
            var request = new DataRequest<T>(baseUri);
            var result = await request.Patch(endpoint, command);

            return result;
        }

        protected static async Task<T> Put<T>(string baseUri, string endpoint, object command, string token = "")
        {
            var request = new DataRequest<T>(baseUri);
            var result = await request.Put(endpoint, command, token);

            return result;
        }

        protected static async Task<T> Post<T>(string baseUri, string endpoint, object command, string token = "")
        {
            var request = new DataRequest<T>(baseUri);
            var result = await request.Post(endpoint, command, token);

            return result;
        }

        protected static async Task<T> Delete<T>(string baseUri, string endpoint, string token = "")
        {
            var request = new DataRequest<T>(baseUri);
            var result = await request.Delete(endpoint, token);

            return result;
        }

        public static ClientesPostReturn ClientesPostReturn(string nome, string enderecoCliente, string cpfCliente, string cepCliente, string bairroCliente, string telefone, string celular)
        {
            ClientesPostReturn clientesPostReturn = new ClientesPostReturn
            {
                NomeCliente = nome,
                EnderecoCliente = enderecoCliente,
                CpfCLiente = cpfCliente,
                CepCliente = cepCliente,
                BairroCliente = bairroCliente,
                TelefoneFixCliente = telefone,
                CelularCliente = celular
            };
            return clientesPostReturn;
        }

    }
}
