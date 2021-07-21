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
    public class PrazoFeature : BaseTest
    {
        [Fact]
        public async Task TestPrazo()
        {
           await Post<RetornoPrazoPagamento>(Endpoints.BaseURI, Endpoints.Prazopagamento, PrazoPostReturn(12, 1));

           await Get<RetornoPrazoPagamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Prazopagamento, postResponse.Id.ToString()));

           await Put<RetornoPrazoPagamento>(Endpoints.BaseURI, Endpoints.Prazopagamento, PrazoPostReturn(5, 2));

           await Delete<RetornoPrazoPagamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Prazopagamento, postResponse.Id.ToString()));
        }
    }
}
