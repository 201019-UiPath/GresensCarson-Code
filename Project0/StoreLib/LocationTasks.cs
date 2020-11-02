using StoreLib.Models;
using System.Collections.Generic;

namespace StoreLib
{
    public class LocationTasks
    {

        public void RecordOrder(Order o){
            //record order made at this location
        }

        public List<Order> GetOrderHistory(){
            //get order history of this location
            List<Order> lst = new List<Order>();
            return lst;
        }

    }
}