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

            //new'lenen şey bir ICustomerDal nesnesi değil, içinde ICustomerDal implemente eden classları tutan bir Array nesnesi.
            //Yani en başta Array'i new'ledik, sonra ise
            //class'ları new'ledik, ICustomerDal'ı new'lemedik. Zaten ICustomerDal'ı implemente eden somut class'lar new'lenebilir.
            //Bu şekilde düşünebiliriz
            // SqlServerCustomerDal sqlServerCustomerDal=new SqlServerCustomerDal();
            //OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();   şeklinde de yapabilirdik
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
