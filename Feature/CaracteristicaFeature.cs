using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
   public class CaracteristicaFeature : BaseTest
    {
        [Fact]
        public async Task TesteCaracteristica()
        {
            var response = await Get<List<RetornoCaracteristica>>(Endpoints.BaseURI, Endpoints.Caracteristica);
            Assert.NotNull(response[0]);
        }
    }
}
