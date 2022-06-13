using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Deliga
{
    public class Iinitialition
    {
        public ContactLsitcs[] Iinitialize()
        {
            var list = new ContactLsitcs[]
            {
                new ContactLsitcs() { Id = 0, Name = "jor", Surname = "4foo", PhoneNumber = "+380432423" },
                new ContactLsitcs() { Id = 543, Name = "FrAnk", Surname = "4foo", PhoneNumber = "+3809423999" },
                new ContactLsitcs() { Id = 676, Name = "M<ax", Surname = "foo", PhoneNumber = "+380975281" },
                new ContactLsitcs() { Id = 43, Name = "fd", Surname = "ffsdaoo", PhoneNumber = "+380947891" },
                new ContactLsitcs() { Id = 1, Name = "47fAf", Surname = "foo", PhoneNumber = "+380996578919" },
                new ContactLsitcs() { Id = 76, Name = "bvDc", Surname = "00foo", PhoneNumber = "+4328" },
                new ContactLsitcs() { Id = 0034, Name = "l;q", Surname = "foo", PhoneNumber = "+3809659" },
                new ContactLsitcs() { Id = 51, Name = "fds", Surname = "3671foo", PhoneNumber = "+443" },
                new ContactLsitcs() { Id = 8, Name = "nb", Surname = ".foo", PhoneNumber = "++43943" },
            };
            return list;
        }
    }
}
