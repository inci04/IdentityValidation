using IdentityValidateService;
using System;
using System.Threading.Tasks;

namespace IdentityValidation
{
    public class CitizenManager
    {
        private readonly IdentityValidateService.KPSPublicSoapClient _client;

        public CitizenManager(KPSPublicSoapClient client)
        {
            _client = client;
        }

        public void Validate(Citizen citizen)
        {
            Task<TCKimlikNoDogrulaResponse> response = _client.TCKimlikNoDogrulaAsync(citizen.TckNo, citizen.Name, citizen.Surname, citizen.BirthDate);

            Console.WriteLine(response.Result.Body.TCKimlikNoDogrulaResult
                ? "Girilen bilgiler doğrulandı"
                : "Hatalı giriş"
            );
        }
    }
}