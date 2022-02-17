using System;
using System.Globalization;

namespace IdentityValidation
{
    public class Citizen
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get
            {
                return _name.ToUpper(CultureInfo.CurrentCulture);
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname.ToUpper(CultureInfo.CurrentCulture);
            }
            set
            {
                _surname = value;
            }
        }

        public int BirthDate { get; set; }
        public long TckNo { get; set; }
    }
}