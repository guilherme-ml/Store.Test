using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class CondicaoPagamentoFeature : BaseTest
    {
       [Fact]
       public async Task TestCondPagamento()
        {
            var postCondicao = await Post<RetornoCondicaoPag>(Endpoints.BaseURI, Endpoints.Condicaopagamento, CondicaoPagamentoPostReturn("Teste", 1));
            Assert.True(postCondicao.DescricaoCondPag != null);

            var getCondicao = await Get<RetornoCondicaoPag>(Endpoints.BaseURI, Path.Combine(Endpoints.Condicaopagamento, postCondicao.Id.ToString()));
            Assert.NotNull(getCondicao.DescricaoCondPag);

            var putCondicao = await Put<RetornoCondicaoPag>(Endpoints.BaseURI, Endpoints.Condicaopagamento, CondicaoPagamentoPostReturn("TesteTeste", 8));
            Assert.NotNull(putCondicao.DescricaoCondPag);

            var deleteCondicao = await Delete<RetornoCondicaoPag>(Endpoints.BaseURI, Path.Combine(Endpoints.Condicaopagamento, postCondicao.Id.ToString()));
            Assert.NotNull(deleteCondicao.DescricaoCondPag);
        }
    }
}
