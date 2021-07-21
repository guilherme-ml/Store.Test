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
    public class ItemCompraFeature : BaseTest
    {
        [Fact]
        public async Task TestItemCompra()
        {
           await Post<RetornoItemCompra>(Endpoints.BaseURI, Endpoints.Itemcompra, ItemCompraPostReturn(5, 2, 4, 6));

           await Get<RetornoItemCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Itemcompra, postResponse.Id.ToString()));

           await Put<RetornoItemCompra>(Endpoints.BaseURI, Endpoints.Itemcompra, ItemCompraPostReturn(12, 1, 9, 2));

           await Delete<RetornoItemCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Itemcompra, postResponse.Id.ToString()));
        }
    }
}
