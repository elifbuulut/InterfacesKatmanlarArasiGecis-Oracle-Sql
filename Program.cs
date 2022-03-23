using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesKatmanlarArasiGecis_Oracle_Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());

            // YUKARDA Kİ KULLANIM YERİNE INTERFACEDEN BİR DİZİ OLUŞTURUP TEK TEK EKLEME İŞLEMLERİNİ YAPTIRIYORUZ 

            ICostomerDal[] costomerDals = new ICostomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
              

            };

            foreach (var customerDaal in costomerDals)
            {
                customerDaal.Add();
            };
            Console.ReadLine();




        }
    }
}
