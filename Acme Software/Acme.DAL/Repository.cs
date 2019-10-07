using Acme.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Acme.DAL
{
    public class Repository
    {
        
        //Hmm, jag vill testa att använda en DB istället för List<T>
        //jag behöver kontakt med DB
        //det borde finnas hjälp att få i Framework
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ACME;Integrated Security=True");

        public Repository()
        {
            //constructor, dvs denna kod körs vid NEW
        }

        public void Save(Customer customer)
        {
            cn.Open();

            SqlCommand cm = new SqlCommand("INSERT INTO Customers (Name) VALUES ('" + customer.Name + "');");
            cm.Connection = cn;
            cm.ExecuteNonQuery();

            cn.Close();
        }

        public int NumberOfCustomers()
        {
            cn.Open();

            SqlCommand cm = new SqlCommand("SELECT COUNT(Name) FROM Customers");
            cm.Connection = cn;
            int numberOfCustomers =int.Parse(cm.ExecuteScalar().ToString());

            cn.Close();

            return numberOfCustomers;
        }
    }
}
