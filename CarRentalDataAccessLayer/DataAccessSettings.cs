using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString { get; } =
            @"Server=.;Database=CarRentalDB;User Id=sa;Password=123456;Integrated Security=True;";

        //    public static string ConnectionString { get; } =
        //@"Server=(localdb)\MSSQLLocalDB;Database=CarRentalDB;Integrated Security=True;TrustServerCertificate=True";
    }
}
