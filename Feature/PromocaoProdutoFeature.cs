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
    public class PromocaoProdutoFeature : BaseTest
    {
        [Fact]
        public async Task TestPromocaoProdutos()
        {
            await Post<RetornoPromocaoProduto>(Endpoints.BaseURI, Endpoints.Promocaoproduto, PromocaoProdutoPostReturn(5, 1, 2, 6));

            await Get<RetornoPromocaoProduto>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocaoproduto, postResponse.Id.ToString()));

            await Put<RetornoPromocaoProduto>(Endpoints.BaseURI, Endpoints.Promocaoproduto, PromocaoProdutoPostReturn(10, 2, 4, 12));

            await Delete<RetornoPromocaoProduto>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocaoproduto, postResponse.Id.ToString()));
        }
    }
}
