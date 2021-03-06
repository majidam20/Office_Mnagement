using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class bailmentclass:searchclass
{
    DAL DA = new DAL();

    public void Add(string id, string name_family, string type,string name,string unit_name,
      string phone_number,string bailment_date, string ret_date, string others_describetions,bool bailmented,string bail_ret_date)
    {
        string Sql = @"INSERT INTO bailment (id, name_family, type,name,unit_name,phone_number,
                      bailment_date,ret_date,others_describetions,part_name_fk,bailmented,bail_ret_date)
                      values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',{10},N'{11}')";

        global g = new global();

        Sql = string.Format(Sql, id, name_family, type,name,unit_name, phone_number,
            bailment_date, ret_date, others_describetions, g.get_part_name_fk(), Convert.ToInt32(bailmented), bail_ret_date);
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeedddddddddddddddddddddddddiiittt

    public void Edit(string id, string name, string name_family, string type, string unit_name, string phone_number, string bailment_date,
        string ret_date, string others_describetions, string old_id, string old_name_family, string old_type, string old_bailment_date)
    {
        string sql = @"UPDATE bailment SET id=N'{0}',name_family =N'{1}',type =N'{2}', unit_name=N'{3}',
        phone_number =N'{4}', bailment_date =N'{5}', ret_date =N'{6}', others_describetions =N'{7}' , name=N'{8}'
        WHERE ((id=N'" + old_id + "') and (name_family=N'" + old_name_family + "') and (type=N'" + old_type + "') and (bailment_date=N'" + old_bailment_date + "') )";


        sql = string.Format(sql, id, name_family, type, unit_name, phone_number, bailment_date,
            ret_date, others_describetions, name, id, old_name_family, old_type, old_bailment_date);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public void Edit_bailmented(bool bailmented, string bail_ret_date, string id, string name_family,string type,string bailment_date )
    {
        string sql = @"UPDATE bailment SET  bailmented={0},bail_ret_date=N'{1}'
where ((id=N'" + id + "') and (name_family=N'" + name_family + "') and (type=N'" + type + "') and (bailment_date=N'" + bailment_date + "') )";

        sql = string.Format(sql, Convert.ToInt32(bailmented), bail_ret_date, id,name_family,type,bailment_date);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

//sssssssssssssssssssssseeeeeeeeeeeeeeeeerrrr
    public DataTable Search(string id, string name_family, string type, string bailment_date)
    {
        string Sql = "select * from bailment where ((id=N'" + id + "') and (name_family=N'" + name_family + "') and (type=N'" + type + "') and (bailment_date=N'" + bailment_date + "') )";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    //




    //deeeeeeeeeeeeeeeeeelllllllllllllllllllllllllllleteeeeeeeeeeeeeeeeeeeeeee   


    public void Delete(string id, string name_family, string type, string bailment_date)
    {
        string Sql = @"delete from bailment where ( (id=N'" + id + "') and (name_family=N'" + name_family + "') and(type=N'" + type + "') and(bailment_date=N'" + bailment_date + "'))";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from bailment";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search(string id)
    {
        string Sql = "select * from bailment where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT     id AS شماره,name as نام,bailmented as [امانت داده شده] ,name_family AS [نام و نام خانوادگی امانت گیرنده],part_name_fk as [نام بخش] ,
          type AS نوع,bailment_date AS [تاریخ تحویل],ret_date AS [سررسید تحویل],bail_ret_date as[تاریخ بازگشت],
          unit_name as [واحد امانت گیرنده] ,phone_number AS [شماره تلفن], 
          others_describetions AS [سایر توضیحات] FROM  bailment
          where part_name_fk = N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT     id AS شماره,name as نام,bailmented as [امانت داده شده] ,name_family AS [نام و نام خانوادگی امانت گیرنده],part_name_fk as [نام بخش] ,
          type AS نوع,bailment_date AS [تاریخ تحویل],ret_date AS [سررسید تحویل],bail_ret_date as[تاریخ بازگشت],
          unit_name as [واحد امانت گیرنده] ,phone_number AS [شماره تلفن], 
          others_describetions AS [سایر توضیحات] FROM  bailment";

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

}
