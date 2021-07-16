using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Test.Feature
{
   public class CaracteristicaFeature
    {
        Fact]
        public async Task TesteCaracteristica()
        {
            var response = await Get<List<RetornoCaracteristica>>(Endpoints.BaseURI, Endpoints.Caracteristica);
            Assert.NotNull(response[0]);
        }
    }
}
