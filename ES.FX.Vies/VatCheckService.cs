using System.Threading.Tasks;
using ES.FX.Vies.Connected_Services.ViesEuropa;

namespace ES.FX.Vies
{
    public class VatCheckService
    {
        public async Task<VatCheckResult> CheckAsync(VatCheckRequest request)
        {
            var client = new checkVatPortTypeClient();
            try
            {
                var checkResult = await client.checkVatAsync(
                    new checkVatRequest(
                        request.CountryCode,
                        request.VatNumber));

                return new VatCheckResult
                {
                    Valid = checkResult.valid,
                    VatNumber = checkResult.vatNumber,
                    Name = checkResult.name,
                    Address = checkResult.address,
                    CountryCode = checkResult.countryCode,
                    RequestDate = checkResult.requestDate
                };
            }
            finally
            {
                await client.CloseAsync();
            }
        }
    }
}
