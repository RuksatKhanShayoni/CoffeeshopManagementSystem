using DataAccessLayer.Entity;
using System.Configuration;
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
        public SqlDataReader GetData(string sql)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }
        public int Insert(EProduct eproduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into LoginTableStaff (Name,Email,Pass) values ('" + eproduct.Name + "','" + eproduct.Email + "','" + eproduct.Pass + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
        public int LoginEmployees(EProduct eproduct)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            string sql = "SELECT * FROM LoginTableStaff WHERE Email ='" + eproduct.Email + "' AND Pass='" + eproduct.Pass + "'";
            SqlDataReader datareader = this.GetData(sql);
            int approve = 0;
            if (datareader.HasRows)
            {
                approve = 1;

            }
            connection.Close();
            return approve;

        }

        public int LoginAdmin(EProduct eproduct)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            string sql = "SELECT * FROM LoginTableAdmin WHERE ID ='" + eproduct.ID + "' AND Pass='" + eproduct.Pass + "'";
            SqlDataReader datareader = this.GetData(sql);
            int approve = 0;
            if (datareader.HasRows)
            {
                approve = 1;

            }
            connection.Close();
            return approve;

        }
        public void InsertOrder(EProduct eproduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into OrderHistoryTable1 (Name,Contact_No,Email,Price,Date) values ('" + eproduct.Name + "','" + eproduct.Contact_No + "','" + eproduct.Email + "','" + eproduct.Price + "','" + eproduct.Date + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
      public SqlDataAdapter show()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter("Select * from OrderHistoryTable1", connection);
            connection.Close();
            return sqldataadapter;
        }
        public void OrderQ(EProduct eproduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into OrderQ (Latte,Cappuccino,Mocha,Americano,Flatwhite,Espresso) values ('" + eproduct.Latte + "','" + eproduct.Cappuccino + "','" + eproduct.Mocha + "','" + eproduct.Americano + "','" + eproduct.Flatwhite + "','" + eproduct.Espresso + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public SqlDataAdapter showOrder()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter("Select * from OrderQ Order by Order_Id Desc ", connection);
            connection.Close();
            return sqldataadapter;
        }
        public SqlDataAdapter showStaff()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter("Select ID,Name,Email from LoginTableStaff", connection);
            connection.Close();
            return sqldataadapter;
        }
        public void deleteStaff(EProduct eproduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from LoginTableStaff where ID in  ('" + eproduct.SID + "')", connection);
            command.ExecuteNonQuery();

            
        }
        public void updatePass(EProduct eproduct )
        {
            SqlConnection connection = new SqlConnection(@"Data Source=OLIVAIA\SQLEXPRESS;Initial Catalog=DBproduct;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Update Logintablestaff set Pass in ('" + eproduct.UPASS + "')where Email in ('" + eproduct.Email + "')", connection);
            command.ExecuteNonQuery();

        }
    }
}

