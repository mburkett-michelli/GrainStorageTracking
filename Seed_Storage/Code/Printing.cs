using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seed_Storage
{
    public static class Printing
    {


        public static void PrintShippingTicket(int Ticket, int iCopies)
        {
            Wait.ShowWait(string.Format("Printing Ticket", Ticket));
            try
            {
                using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
                {
                    using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
                    {
                        System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                    }
                    using (Seed_Storage_DatasetTableAdapters.HeadersTableAdapter HeadersTableAdapter = new Seed_Storage_DatasetTableAdapters.HeadersTableAdapter())
                    {
                        HeadersTableAdapter.Fill(Seed_Storage_Dataset.Headers);

                    }
                    using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                    {
                        vwTicket_InformationTableAdapter.FillByTicket(Seed_Storage_Dataset.vwTicket_Information, Ticket);
                    }
                    using (Seed_Storage_DatasetTableAdapters.vw_Shipping_InfoTableAdapter vw_Shipping_InfoTableAdapter = new Seed_Storage_DatasetTableAdapters.vw_Shipping_InfoTableAdapter())
                    {
                        vw_Shipping_InfoTableAdapter.FillByTicket(Seed_Storage_Dataset.vw_Shipping_Info, Ticket);

                    }
                    using (Reports.Shipping_Ticket_2_Part Shipping_Ticket = new Reports.Shipping_Ticket_2_Part())
                    {
                        Shipping_Ticket.SetDataSource(Seed_Storage_Dataset);
                        Shipping_Ticket.PrintToPrinter(iCopies, true, 0, 0);

                    }
                    
                }

            }
            catch (Exception ex)
            {

                Alert.Show("Something Went Wrong Printing Ticket " + ex.Message);
            }
            finally
            {
                Wait.Hide();
            }
        }






        public static void PrintRecievingTicket(int Ticket, int iCopies)
        {
            Wait.ShowWait(string.Format("Printing Ticket {0}", Ticket));
            try
            {
                using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
                {
                    using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
                    {
                        System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                    }
                    using (Seed_Storage_DatasetTableAdapters.HeadersTableAdapter HeadersTableAdapter = new Seed_Storage_DatasetTableAdapters.HeadersTableAdapter())
                    {
                        HeadersTableAdapter.Fill(Seed_Storage_Dataset.Headers);

                    }
                    using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                    {
                        vwTicket_InformationTableAdapter.FillByTicket(Seed_Storage_Dataset.vwTicket_Information, Ticket);
                    }
                    using (Seed_Storage_DatasetTableAdapters.vw_Recieving_InfoTableAdapter vw_Recieving_InfoTableAdapter = new Seed_Storage_DatasetTableAdapters.vw_Recieving_InfoTableAdapter())
                    {
                        vw_Recieving_InfoTableAdapter.FillByTicket(Seed_Storage_Dataset.vw_Recieving_Info, Ticket);

                    }
                    using (Reports.Recieving_Ticket Recieving_Ticket = new Reports.Recieving_Ticket())
                    {
                        Recieving_Ticket.SetDataSource(Seed_Storage_Dataset);
                        Recieving_Ticket.PrintToPrinter(iCopies, true, 0, 0);

                    }

                }

            }
            catch (Exception ex)
            {

                Alert.Show("Something Went Wrong Printing Ticket " + ex.Message);
            }
            finally
            {
                Wait.Hide();
            }
        }




        public static void PrintGTNTicket(int Ticket,int iCopies)
        {
            Wait.ShowWait(string.Format("Printing Ticket {0}", Ticket));
            try
            {
                using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
                {
                    using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
                    {
                        System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                    }
                    using (Seed_Storage_DatasetTableAdapters.HeadersTableAdapter HeadersTableAdapter = new Seed_Storage_DatasetTableAdapters.HeadersTableAdapter())
                    {
                        HeadersTableAdapter.Fill(Seed_Storage_Dataset.Headers);

                    }
                    using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                    {
                        vwTicket_InformationTableAdapter.FillByTicket(Seed_Storage_Dataset.vwTicket_Information, Ticket);
                    }
                    using (Seed_Storage_DatasetTableAdapters.GTN_TicketTableAdapter GTN_TicketTableAdapter = new Seed_Storage_DatasetTableAdapters.GTN_TicketTableAdapter())
                    {
                        GTN_TicketTableAdapter.FillByTicket(Seed_Storage_Dataset.GTN_Ticket, Ticket);

                    }
                    using (Reports.GTN_Ticket GTN_Ticket = new Reports.GTN_Ticket())
                    {
                        GTN_Ticket.SetDataSource(Seed_Storage_Dataset);
                        GTN_Ticket.PrintToPrinter(iCopies, true, 0, 0);

                    }

                }

            }
            catch (Exception ex)
            {

                Alert.Show("Something Went Wrong Printing Ticket " + ex.Message);
            }
            finally
            {
                Wait.Hide();
            }
        }
    }
}
