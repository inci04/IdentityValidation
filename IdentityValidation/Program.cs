using IdentityValidateService;
using System;

namespace IdentityValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenManager citizenManager = new(new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap));
            Citizen citizen = new();

            Console.Write("T.C. No: ");
            citizen.TckNo = Convert.ToInt64(Console.ReadLine());

            Console.Write("İsim: ");
            citizen.Name = Console.ReadLine();

            Console.Write("Soyad: ");
            citizen.Surname = Console.ReadLine();

            Console.Write("Birthdate: ");
            citizen.BirthDate = Convert.ToInt32(Console.ReadLine());

            citizenManager.Validate(citizen);
        }
    }
}
