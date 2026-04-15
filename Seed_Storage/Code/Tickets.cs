using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seed_Storage
{
    class Tickets
    {
        public  enum enumLoadType { Shipping,Recieving,GTN,TruUp}


        

        public static int CreateNewShippingTicket(string Customer,string Bin,string Variety,string Lot,string Driver, string Truck_Id, int Weight,bool Driver_On,string Bush_Ticket, string Comments = "",string WeighMaster="")
        {
            int Ticket = CreateNewTicket(Driver, Truck_Id, enumLoadType.Shipping ,Driver_On, Comments,WeighMaster );
            if (Ticket>-1)
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.CreateShippingLoad(Ticket, Customer, Bin, Variety, Lot,Bush_Ticket);
                    Guid Ticket_Weight_UID = NewInboundTicketWeight(Ticket, Weight);

                    if (Properties.Settings.Default.UseInboundCamera)
                    {
                        Picture Pic = new Picture();
                        Pic.TakePicture(Ticket_Weight_UID, Ticket, true);
                    }
                }

            }
            return Ticket;

        }



        public static void UpdateShippingTicket(int Ticket, string Customer, string Bin, string Variety, string Lot, string Driver, string Truck_Id, bool Driver_On, string Bush_Ticket, string Comments = "", string WeighMaster = "")
        {
             UpdateTicket(Ticket,Driver, Truck_Id, enumLoadType.Shipping,Driver_On , Comments,WeighMaster );
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.UpdateShippingLoad(Ticket, Customer, Bin, Variety, Lot,Bush_Ticket );
                   
                }
                
            }
            

        }





        public static int CreateNewGTNTicket(string Customer, string Driver, string Truck_Id, int Weight,bool Driver_On, string Comments = "")
        {
            int Ticket = CreateNewTicket(Driver, Truck_Id, enumLoadType.GTN ,Driver_On, Comments);
            if (Ticket > -1)
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.CreateGTNLoad(Ticket, Customer,0);
                    Guid Ticket_Weight_UID = NewInboundTicketWeight(Ticket, Weight);
                    
                    if (Properties.Settings.Default.UseInboundCamera)
                    {
                        Picture Pic = new Picture();
                        Pic.TakePicture(Ticket_Weight_UID, Ticket, true);
                    }
                    
                }

            }
            return Ticket;

        }



        public static void UpdateGTNTicket(int Ticket, string Customer, string Driver, string Truck_Id,bool Driver_On,string Comments = "")
        {
            UpdateTicket(Ticket, Driver, Truck_Id, enumLoadType.Shipping,Driver_On , Comments);
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.UpdateGTNLoad(Ticket, Customer,0);

                }

            }


        }




        public static int CreateNewRecievingTicket(string Bin, string Variety, string Bush_Ticket,int Bush_Net, string Driver, string Truck_Id, int Weight,bool Driver_On, string Comments = "", string WeighMaster = "")
        {
            int Ticket = CreateNewTicket(Driver, Truck_Id, enumLoadType.Recieving,Driver_On , Comments,WeighMaster);
            if (Ticket > -1)
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.CreateRecievingLoad(Ticket,  Bin, Variety,Bush_Ticket ,Bush_Net );
                    Guid Ticket_Weight_UID = NewInboundTicketWeight(Ticket, Weight);
                    if (Properties.Settings.Default.UseInboundCamera)
                    {
                        Picture Pic = new Picture();
                        Pic.TakePicture(Ticket_Weight_UID, Ticket, true);
                    }
                    
                }

            }
            return Ticket;

        }



        public static void UpdateRecievingTicket(int Ticket, string Bin, string Variety,string Bush_Ticket, int Bush_Net, string Driver, string Truck_Id,bool Driver_On, string Comments = "", string WeighMaster = "")
        {
            UpdateTicket(Ticket, Driver, Truck_Id, enumLoadType.Shipping,Driver_On, Comments,WeighMaster );
            {

                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    Q.UpdateRecievingLoad(Ticket, Bin, Variety, Bush_Ticket, Bush_Net); 

                }

            }


        }



        private static Guid  NewInboundTicketWeight(int Ticket,int Weight)
        {
            using (Seed_Storage_DatasetTableAdapters.Ticket_WeightsTableAdapter Ticket_WeightsTableAdapter = new Seed_Storage_DatasetTableAdapters.Ticket_WeightsTableAdapter())
            {
                using (Seed_Storage_Dataset.Ticket_WeightsDataTable Ticket_WeightsDataTable = new Seed_Storage_Dataset.Ticket_WeightsDataTable())
                {
                    Seed_Storage_Dataset.Ticket_WeightsRow row =Ticket_WeightsDataTable.NewTicket_WeightsRow();
                    Guid UID = Guid.NewGuid();
                    row.UID = UID;
                    row.Time_In = DateTime.Now;
                    row.Ticket = Ticket;
                    row.In_Weight = Weight;
                    Ticket_WeightsDataTable.AddTicket_WeightsRow(row);
                    Ticket_WeightsTableAdapter.Update(Ticket_WeightsDataTable);
                    return UID;

                }

            }

        }



        public static void UpdateOutboundTicketWeight(int Ticket, int Weight)
        {
            try
            {
                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                    {
                        using (Seed_Storage_Dataset.vwTicket_InformationDataTable vwTicket_Information = new Seed_Storage_Dataset.vwTicket_InformationDataTable())
                        {
                            if (vwTicket_InformationTableAdapter.FillByTicket(vwTicket_Information, Ticket) > 0)
                            {
                                if (vwTicket_Information[0].IsTime_OutNull() )
                                {
                                    using (Seed_Storage_DatasetTableAdapters.Ticket_WeightsTableAdapter Ticket_WeightsTableAdapter = new Seed_Storage_DatasetTableAdapters.Ticket_WeightsTableAdapter())
                                    {
                                       using (Seed_Storage_Dataset.Ticket_WeightsDataTable Ticket_Weights= new Seed_Storage_Dataset.Ticket_WeightsDataTable())
                                        {
                                            if (Ticket_WeightsTableAdapter.FillByTIcket(Ticket_Weights,Ticket) >0)
                                            {
                                                if (Properties.Settings.Default.UseOutboundCamera)
                                                {
                                                    Picture pic = new Picture();
                                                    pic.TakePicture(Ticket_Weights[0].UID, Ticket, false);
                                                }
                                                
                                            }

                                        }
                                    }
                                }
                            }

                        }

                    }
                    Q.UpdateOutboundWeight(Ticket, null, Weight);


                }
            }
            catch (Exception ex)
            {
                Alert.Show(string.Format("Error Updating Outbound Weight For Ticket {0:N0} {1}", Ticket, ex.Message));

            }

        }


        public static void UpdateInboundTicketWeight(int Ticket, int Weight)
        {
            try
            {
                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {

                    Q.UpdateInboundWeight(Ticket, null, Weight);
                }
            }
            catch (Exception ex)
            {
                Alert.Show(string.Format("Error Updating Inbound Weight For Ticket {0:N0} {1}", Ticket, ex.Message));

            }

        }

        private static int CreateNewTicket(string Driver, string Truck_Id, enumLoadType LoadType,bool Driver_On, string Comments = "", string Weighmaster = "")
        {
            try
            {
                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {


                    string TypeOfLoad;

                    switch (LoadType)
                    {
                        case enumLoadType.Recieving:
                            TypeOfLoad = "Inbound";
                            break;
                        case enumLoadType.GTN:
                            TypeOfLoad = "Other";
                            break;
                        case enumLoadType.Shipping:
                            TypeOfLoad = "Outbound";
                            break;
                        case enumLoadType.TruUp:
                            TypeOfLoad = "TruUp";
                            break;
                        default:
                            TypeOfLoad = "";
                            break;
                    }
                    int? Ticket = (int)Q.CreateTicket(Driver, Truck_Id, TypeOfLoad, Comments,Driver_On,Weighmaster );
                    if (Ticket == null)
                    {
                        Ticket = -1;
                    }
                    return (int)Ticket;
                }

            }
            catch (Exception ex)
            {
                Alert.Show("Error Creating Ticket " + ex.Message);
                return -1;
            }

        }


     private static void UpdateTicket(int Ticket ,string Driver, string Truck_Id, enumLoadType LoadType,bool Driver_On, string Comments = "",string Weighmaster="")
        {
            try
            {
                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {


                    Q.UpdateTicket(Ticket,Driver, Truck_Id, Comments,Driver_On ,Weighmaster );
                    
                }

            }
            catch (Exception ex)
            {
                Alert.Show("Error Updating Ticket " + ex.Message);
                
            }

        }

    }
}
