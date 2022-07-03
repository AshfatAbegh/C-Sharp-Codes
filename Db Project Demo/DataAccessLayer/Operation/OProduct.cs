using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class OProduct
    {
        //CRUD Operation
        public int insert(EProduct eProduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=PC-TL2020;Initial Catalog=DBProductInfo;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TProduct(Id, Name) values('"+eProduct.Id+"','"+eProduct.Name+"')",connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;

        }
        
    }
}
