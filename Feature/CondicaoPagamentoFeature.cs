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
            var postResponse = await Post<RetornoCondicaoPag>(Endpoints.BaseURI, Endpoints.Condicaopagamento, CondicaoPagamentoPostReturn("Teste", 1));
            Assert.True(postResponse.DescricaoCondPag != null);

            var getResponse = await Get<RetornoCondicaoPag>(Endpoints.BaseURI, Path.Combine(Endpoints.Condicaopagamento, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.DescricaoCondPag);

            var putResponse = await Put<RetornoCondicaoPag>(Endpoints.BaseURI, Endpoints.Condicaopagamento, CondicaoPagamentoPostReturn("TesteTeste", 8));
            Assert.NotNull(putResponse.DescricaoCondPag);

            var deleteResponse = await Delete<RetornoCondicaoPag>(Endpoints.BaseURI, Path.Combine(Endpoints.Condicaopagamento, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.DescricaoCondPag);
        }
    }
}
