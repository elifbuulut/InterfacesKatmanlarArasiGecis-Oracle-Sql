using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesKatmanlarArasiGecis_Oracle_Sql
{
    public interface ICostomerDal
    
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICostomerDal

    {
        public void Add()
        {
            Console.WriteLine("Sql Added");

        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");

        }
    }

    class OracleCustomerDal : ICostomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }


    class MySqlCustomerDal : ICostomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    public class CustomerManager
    {

        public void Add(ICostomerDal costomer)
        {
            costomer.Add();

        }
    }
}
