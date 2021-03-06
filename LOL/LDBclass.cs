using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class LDBclass
{
    LDAL DA = new LDAL();

    public void Add(string ServerAddress, string DbUserID, string DbUserPass)
    {
        string Sql = @"INSERT Config (ServerAddress, DbUserID, DbUserPass)
                      values (N'{0}',N'{1}',N'{2}',N'{3}')";

        global g = new global();

        Sql = string.Format(ServerAddress, DbUserID, DbUserPass);
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }
    
    public void Edit(string ServerAddress, string DbUserID, string DbUserPass)
    {
        string sql = @"UPDATE Config SET ServerAddress=N'{0}', DbUserID =N'{1}', DbUserPass =N'{2}'";

        sql = string.Format(sql,ServerAddress, DbUserID, DbUserPass);
        
        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Delete(string id)
    {
        string Sql = "delete from album where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    public DataTable Search()
    {
        string Sql = "select * from Config";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid()
    {
        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
                     zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
                     provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     from album";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    public DataTable Search(string id)
    {
        string Sql = "select * from album where id=N'"+id+"'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    //public DataTable Search(int id)
    //{
    //    string Sql = "select * from album where id=" + id;
    //    DataTable dt = new DataTable();
    //    db.Connect();
    //    dt = db.Select(Sql);
    //    db.Disconnect();
    //    return dt;
    //}



}

