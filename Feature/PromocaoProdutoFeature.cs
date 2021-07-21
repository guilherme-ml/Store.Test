using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class PromocaoProdutoFeature : BaseTest
    {
        [Fact]
        public async Task TestPromocaoProdutos()
        {
           var postPromocaoProduto = await Post<RetornoPromocaoProduto>(Endpoints.BaseURI, Endpoints.Promocaoproduto, PromocaoProdutoPostReturn(5, 1, 2, 6));

            await Get<RetornoPromocaoProduto>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocaoproduto, postPromocaoProduto.Id.ToString()));

            await Put<RetornoPromocaoProduto>(Endpoints.BaseURI, Endpoints.Promocaoproduto, PromocaoProdutoPostReturn(10, 2, 4, 12));

            await Delete<RetornoPromocaoProduto>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocaoproduto, postPromocaoProduto.Id.ToString()));
        }
    }
}
