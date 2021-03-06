using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class usersclass:searchclass
{
    DAL DA = new DAL();
    public void Add(string name, string family, string uid, string upass, string part_name_fk)
    {
        string sql = "INSERT INTO users (name, family, uid, upass, part_name_fk) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')";
        sql = string.Format(sql, name, family, uid, upass, part_name_fk);
        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();

    }
    public void Edit(string name, string family, string upass, string part_name_fk, string uid)
    {
        string sql = @"UPDATE users SET name =N'{0}', family =N'{1}', upass =N'{2}',
        part_name_fk =N'{3}' WHERE uid =N'{4}'";

        sql = string.Format(sql, name, family, upass, part_name_fk, uid);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();


    }

    

    public void Delete(string uid)
    {
        string Sql = "delete from users where uid='" + uid + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    public DataTable Search()
    {
        DataTable dt = new DataTable();
        string Sql = "select * from Users ";
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    public DataTable Search(string uid)
    {
        DataTable dt = new DataTable();
        string Sql = "select * from Users where uid=N'" + uid + "'";
        Sql = string.Format(Sql, uid);
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    public DataTable Search(string uid, bool a)
    {
        string Sql = "select * from users where uid=N'"+uid+"'";
        Sql = string.Format(Sql, uid);
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid()
    {
        string Sql = @"SELECT name AS نام, family AS [نام خانوادگی],part_name_fk AS [نام بخش], uid AS [نام کاربری], upass AS [رمز عبور]
FROM  users";
                      
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_admin(string admin)
    {
        string Sql = "select * from users where part_name_fk like N'%{0}%'";
        Sql = string.Format(Sql, admin);

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

}

