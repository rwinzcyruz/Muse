using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Muse
{
    public enum Contract : byte
    {
        Customer,
        User,
        Bill,
        Order,
        Product
    }

    public enum Gender : byte
    {
        Female,
        Male,
        Unknown
    }
}
