using System.Collections.Generic;
using LawFirmListImplement.Models;

namespace LawFirmListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Document> Documents { get; set; }
        public List<Warehouse> Warehouses { get; set; }
        private DataListSingleton()
        {
            Components = new List<Component>();
            Orders = new List<Order>();
            Documents = new List<Document>();
            Warehouses = new List<Warehouse>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
