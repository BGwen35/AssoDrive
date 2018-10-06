using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssoDriverObjects;

namespace AssoDriverBLL
{
    public class BLLContacts
    {
        public List<Contact> DataSource { get; set; }

        public BLLContacts()
        {
            DataSource = new List<Contact>();
        }

        ~BLLContacts()
        {
            DataSource.Clear();
        }

    }
}
