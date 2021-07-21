using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Store.Test.Rest;
using Store.Test.Dtos.PostAndPut;
using System;

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

        public static AcompanhamentoPostReturn AcompanhamentoPostReturn(DateTime dtEHrSituacao, int situacaoId, int numeroItemCompraId)
        {
            AcompanhamentoPostReturn acompanhamentoPostReturn = new AcompanhamentoPostReturn
            {
                DtEHrSituacao = dtEHrSituacao,
                SituacaoCompraId = situacaoId,
                NumeroItemCompraId = numeroItemCompraId
            };
            return acompanhamentoPostReturn;
        }

        public static CaracteristicaPostReturn CaracteristicaPostReturn(string nome, int idf)
        {
            CaracteristicaPostReturn caracteristicaPostReturn = new CaracteristicaPostReturn 
            {
                nomeCaracteristica = nome,
                idfAtivo = idf
            };
            return caracteristicaPostReturn;
        }

        public static CategoriaPostReturn CategoriaPostReturn(string nome, int posicao, int idfativo, int departamento)
        {
            CategoriaPostReturn categoriaPostReturn = new CategoriaPostReturn
            {
                nomeCategoria = nome,
                posCategoria = posicao,
                idfAtivo = idfativo,
                departamentoId = departamento
            };
            return categoriaPostReturn;
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
        public static CompraPostReturn CompraPostReturn(string data, int cliente, int condicao)
        {
            CompraPostReturn compraPostReturn = new CompraPostReturn
            {
                dtEHrCompra = data,
                clienteId = cliente,
                condPagamento = condicao
            };
            return compraPostReturn;
        }
        public static CondicaoPagamentoPostReturn CondicaoPagamentoPostReturn(string descricao, int idfAtivo)
        {
            CondicaoPagamentoPostReturn condicaoPagamentoPostReturn = new CondicaoPagamentoPostReturn
            {
                descricaoCondPag = descricao,
                idfAtivo = idfAtivo
            };
            return condicaoPagamentoPostReturn;
        }
        public static DepartamentoPostReturn DepartamentoPostReturn(string nome, int idfAtivo, int grupo)
        {
            DepartamentoPostReturn departamentoPostReturn = new DepartamentoPostReturn
            {
                nomeDepartamento = nome,
                idfAtivo = idfAtivo,
                grupoId = grupo
            };
            return departamentoPostReturn;
        }
        public static FabricantePostReturn FabricantePostReturn(string nome, string site, int idfAtivo)
        {
            FabricantePostReturn fabricantePostReturn = new FabricantePostReturn
            {
                nomeFabricante = nome,
                siteFabricante = site,
                idfAtivo = idfAtivo
            };
            return fabricantePostReturn;
        }
        public static GrupoPostReturn GrupoPostReturn(string nome, int idfAtivo)
        {
            GrupoPostReturn grupoPostReturn = new GrupoPostReturn
            {
                nomeGrupo = nome,
                idfAtivo = idfAtivo
            };
            return grupoPostReturn;
        }
        public static ItemCompraPostReturn ItemCompraPostReturn(int preco, int quantidade, int produdo, int compra)
        {
            ItemCompraPostReturn itemCompraPostReturn = new ItemCompraPostReturn
            {
                precoProduto = preco,
                quantidadeProduto = quantidade,
                produtoId = produdo,
                numCompra = compra
            };
            return itemCompraPostReturn;
        }
        public static PrazoPostReturn PrazoPostReturn(int parcelas, int pagamento)
        {
            PrazoPostReturn prazoPostReturn = new PrazoPostReturn
            {
                numeroParcelas = parcelas,
                condPagamentoId = pagamento
            };
            return prazoPostReturn;
        }
        public static ProdutoCaracteristicaPostReturn ProdutoCaracteristicaPostReturn(string valor, int produto, int caracteristica)
        {
            ProdutoCaracteristicaPostReturn produtoCaracteristicaPostReturn = new ProdutoCaracteristicaPostReturn
            {
                valorCaracteristica = valor,
                produtoId = produto,
                caracteristicaId = caracteristica
            };
            return produtoCaracteristicaPostReturn;
        }
        public static PromocaoPostReturn PromocaoPostReturn(string nome, DateTime inicio, DateTime fim)
        {
            PromocaoPostReturn promocaoPostReturn = new PromocaoPostReturn
            {
                nomePromo = nome,
                dtInicioPromo = inicio,
                dtFimPromo = fim
            };
            return promocaoPostReturn;
        }
        public static PromocaoProdutoPostReturn PromocaoProdutoPostReturn(int preco, int condicao, int promocao, int produto)
        {
            PromocaoProdutoPostReturn promocaoProdutoPostReturn = new PromocaoProdutoPostReturn
            {
                precoProduto = preco,
                condicaoPagamentoID = condicao,
                promocao = promocao,
                produtoId = produto
            };
            return promocaoProdutoPostReturn;
        }
        public static SituacaoPostReturn SituacaoPostReturn(string descricao, int idfAtivo)
        {
            SituacaoPostReturn situacaoPostReturn = new SituacaoPostReturn
            {
                descSituacaoCompra = descricao,
                idfAtivo = idfAtivo
            };
            return situacaoPostReturn;
        }
    }
}
