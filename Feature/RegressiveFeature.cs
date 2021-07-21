using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using Store.Test.Dtos.Returns;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class RegressiveFeature : BaseTest
    {
        [Fact]
        public async Task TestRegressive()
        {
            var postResponse = await Post<RetornoFabricante>(Endpoints.BaseURI, Endpoints.Fabricante, FabricantePostReturn("Teste", "Teste.com", 1));
            Assert.True(postResponse.NomeFabricante != null);

            var getResponse = await Get<RetornoFabricante>(Endpoints.BaseURI, Path.Combine(Endpoints.Fabricante, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeFabricante);





            var postCaracteristica = await Post<RetornoCaracteristica>(Endpoints.BaseURI, Endpoints.Caracteristica, CaracteristicaPostReturn("Nome aleatorio", 1));
            Assert.True(postCaracteristica.NomeCaracteristica != null);

            var getCaracteristica = await Get<RetornoCaracteristica>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postCaracteristica.Id.ToString()));
            Assert.NotNull(getCaracteristica.NomeCaracteristica);


            var postProdutoCaracteristica = await Post<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Endpoints.Caracteristica, ProdutoCaracteristicaPostReturn("12", 1, 2));
            Assert.True(postProdutoCaracteristica.ValorCaracteristica != null);

            var getProdutoCaracteristica = await Get<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postProdutoCaracteristica.Id.ToString()));
            Assert.NotNull(getProdutoCaracteristica.ValorCaracteristica);


            var postGrupo = await Post<RetornoGrupo>(Endpoints.BaseURI, Endpoints.Grupo, GrupoPostReturn("Nome aleatorio", 1));
            Assert.True(postGrupo.NomeGrupo != null);

            var getGrupo = await Get<RetornoGrupo>(Endpoints.BaseURI, Path.Combine(Endpoints.Grupo, postGrupo.Id.ToString()));
            Assert.NotNull(getGrupo.NomeGrupo);


            var postDepartamento = await Post<RetornoDepartamento>(Endpoints.BaseURI, Endpoints.Departamento, DepartamentoPostReturn("Teste", 1, 5));
            Assert.True(postDepartamento.NomeDepartamento != null);

            var getDepartamento = await Get<RetornoDepartamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Departamento, postDepartamento.Id.ToString()));
            Assert.NotNull(getDepartamento.NomeDepartamento);


            var postCategoria = await Post<RetornoCategoria>(Endpoints.BaseURI, Endpoints.Categories, CategoriaPostReturn("Nome categoria1", 1, 8, 5));
            Assert.True(postCategoria.NomeCategoria != null);

            var getCategoria = await Get<RetornoCategoria>(Endpoints.BaseURI, Path.Combine(Endpoints.Categories, postCategoria.Id.ToString()));
            Assert.NotNull(getCategoria.NomeCategoria);


            var postPromocao = await Post<RetornoPromocao>(Endpoints.BaseURI, Endpoints.Promocao, PromocaoPostReturn("Nome aleatorio", DateTime.Now, DateTime.Now));
            Assert.True(postPromocao.NomePromo != null);

            var getPromocao = await Get<RetornoPromocao>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocao, postPromocao.Id.ToString()));
            Assert.NotNull(getPromocao.NomePromo);


            var postPromocaoProduto = await Post<RetornoPromocaoProduto>(Endpoints.BaseURI, Endpoints.Promocaoproduto, PromocaoProdutoPostReturn(5, 1, 2, 6));

            await Get<RetornoPromocaoProduto>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocaoproduto, postPromocaoProduto.Id.ToString()));


            var postCondicao = await Post<RetornoCondicaoPag>(Endpoints.BaseURI, Endpoints.Condicaopagamento, CondicaoPagamentoPostReturn("Teste", 1));
            Assert.True(postCondicao.DescricaoCondPag != null);

            var getCondicao = await Get<RetornoCondicaoPag>(Endpoints.BaseURI, Path.Combine(Endpoints.Condicaopagamento, postCondicao.Id.ToString()));
            Assert.NotNull(getCondicao.DescricaoCondPag);


            var postPrazo = await Post<RetornoPrazoPagamento>(Endpoints.BaseURI, Endpoints.Prazopagamento, PrazoPostReturn(12, 1));

            await Get<RetornoPrazoPagamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Prazopagamento, postPrazo.Id.ToString()));


            var postCliente = await Post<RetornoCliente>(Endpoints.BaseURI, Endpoints.Cliente, ClientesPostReturn("Nome aleatorio", "Rua 1", "0918", "8055", "Jarda", "154156", "15165"));
            Assert.True(postCliente.NomeCliente != null);

            var getCliente = await Get<RetornoCliente>(Endpoints.BaseURI, Path.Combine(Endpoints.Cliente, postCliente.Id.ToString()));
            Assert.NotNull(getCliente.NomeCliente);


            var postCompra = await Post<RetornoCompra>(Endpoints.BaseURI, Endpoints.Compra, CompraPostReturn("20.07.2021", 3, 1));
            Assert.True(postCompra.DtEHrCompra != null);

            var getCompra = await Get<RetornoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Compra, postCompra.Id.ToString()));
            Assert.NotNull(getCompra.DtEHrCompra);


            var postSituacao = await Post<RetornoSituacao>(Endpoints.BaseURI, Endpoints.Situacao, SituacaoPostReturn("Teste 123", 1));
            Assert.True(postSituacao.DescSituacaoCompra != null);

            var getSituacao = await Get<RetornoSituacao>(Endpoints.BaseURI, Path.Combine(Endpoints.Situacao, postSituacao.Id.ToString()));
            Assert.NotNull(getSituacao.DescSituacaoCompra);


            var postItemCompra = await Post<RetornoItemCompra>(Endpoints.BaseURI, Endpoints.Itemcompra, ItemCompraPostReturn(5, 2, 4, 6));

            await Get<RetornoItemCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Itemcompra, postItemCompra.Id.ToString()));


            var postAcompanhamento = await Post<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Endpoints.Acompanhamentocompra, AcompanhamentoPostReturn(DateTime.Now, 5, 3));

            await Get<RetornoAcompanhementoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Acompanhamentocompra, postAcompanhamento.Id.ToString()));
        }


        

    }
}