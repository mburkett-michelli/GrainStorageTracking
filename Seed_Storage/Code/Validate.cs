using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Seed_Storage
{
    class validation

    {
        /// <summary>
        /// See if the truck is in the yard
        /// </summary>
        /// <param name="Truck">The truck id to search for</param>
        /// <param name="Ticket">if Ticket is not null then look for a truck not matching the ticket</param>
        /// <returns></returns>
        public static bool IsTruckInYard(string Truck, int? Ticket)
        {
            using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
            {
                bool RetVal = false;
                bool? InYard = (bool)Q.TruckInYard(Truck,Ticket  );
                if (InYard !=null )
                {
                    RetVal = (bool)InYard;

                }
                return RetVal;
            }

        }


     

        public static bool IsValidIPAddress(string Address)
        {
            System.Net.IPAddress address;
            if (System.Net.IPAddress.TryParse(Address, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;
                        
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        // we have IPv6
                        return true;
                        
                    default:
                        return false;
                        
                }

            }
            else
            {
                return false;
            }
        }
    }
}
