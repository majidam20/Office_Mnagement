using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public class DAL
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    static public string server_add;
    public DAL()
    {
        cmd = new SqlCommand();
        con = new SqlConnection();
        da = new SqlDataAdapter();
        cmd.Connection = con;
        da.SelectCommand = cmd;
    }

    public void Connect()
    {
        global g = new global();

        //con.ConnectionString = "Data Source=" + g.get() + ";Initial Catalog=nosazi;Integrated Security=True";
        con.ConnectionString = "Data Source="+g.get_serv_add()+";Initial Catalog=nosazi;User ID="+g.get_db_uid()+";password="+g.get_db_pass() ;
        if (con.State != ConnectionState.Open)
            con.Open();
    }

    public void Disconnect()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }

    public DataTable Select(string sql)
    {
        DataTable dt = new DataTable();
        
        sql = sql.Replace(Convert.ToChar(1610), Convert.ToChar(1740));
        sql = sql.Replace(Convert.ToChar(1603), Convert.ToChar(1705));

        cmd.CommandText = sql;
        da.Fill(dt);
        return dt;
    }

    public void DoCommand(string sql)
    {
        sql=sql.Replace(Convert.ToChar(1610), Convert.ToChar(1740));
        sql=sql.Replace(Convert.ToChar(1603), Convert.ToChar(1705));
        
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

 
}


