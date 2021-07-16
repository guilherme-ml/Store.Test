using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using Xunit;

namespace Store.Test
{
    public class UnitTest1 : BaseTest
    {
        [Fact]
        public async Task TesteAcompanhamento()
        {
            var response = await Get<List<RetornoAcompanhementoCompra>>(Endpoints.BaseURI, Endpoints.Acompanhamentocompra);
            Assert.NotNull(response[0]);
        }

        [Fact]
        public async Task TesteCompra()
        {
            var response = await Get<List<RetornoCompra>>(Endpoints.BaseURI, Endpoints.Compra);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteCaracteristica()
        {
            var response = await Get<List<RetornoCaracteristica>>(Endpoints.BaseURI, Endpoints.Caracteristica);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteCliente()
        {
            var response = await Get<List<RetornoCliente>>(Endpoints.BaseURI, Endpoints.Cliente);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteCondicaoPag()
        {
            var response = await Get<List<RetornoCondicaoPag>>(Endpoints.BaseURI, Endpoints.Condicaopagamento);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteDepartamento()
        {
            var response = await Get<List<RetornoDepartamento>>(Endpoints.BaseURI, Endpoints.Departamento);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteFabricante()
        {
            var response = await Get<List<RetornoFabricante>>(Endpoints.BaseURI, Endpoints.Fabricante);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteGrupo()
        {
            var response = await Get<List<RetornoGrupo>>(Endpoints.BaseURI, Endpoints.Grupo);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteItemCompra()
        {
            var response = await Get<List<RetornoItemCompra>>(Endpoints.BaseURI, Endpoints.Itemcompra);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteProdutoCaracteristica()
        {
            var response = await Get<List<RetornoProdutoCaracteristicas>>(Endpoints.BaseURI, Endpoints.Produtocaracteristica);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TesteProduto()
        {
            var response = await Get<List<RetornoProdutos>>(Endpoints.BaseURI, Endpoints.Products);
            Assert.NotNull(response[0]);
        }
        [Fact]
        public async Task TestePromocao()
        {
            var response = await Get<List<RetornoPromocao>>(Endpoints.BaseURI, Endpoints.Promocao);
            Assert.NotNull(response[0]);
        }
    }
}