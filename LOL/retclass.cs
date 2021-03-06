using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class retclass:searchclass 
{
    DAL DA = new DAL();

    public void Add(string id, string type, string name_family, string phone_number, 
        string bailment_date,string ret_date,string others_describetions)
    {
        string Sql = @"INSERT INTO ret (id, type, name_family,phone_number, bailment_date,
                      ret_date,others_describetions,part_name_fk)
                      values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')";

        global g = new global();

        Sql = string.Format(Sql, id, type, name_family, phone_number,
            bailment_date, ret_date, others_describetions, g.get_part_name_fk());
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeedddddddddddddddiiiiiiiiiiiittttttttttt
    public void Edit(string type, string name_family, string phone_number,string bailment_date,
        string ret_date,string others_describetions, string id)
    {
        string sql = @"UPDATE ret SET type =N'{0}', name_family =N'{1}', phone_number =N'{2}',
        bailment_date =N'{3}', ret_date =N'{4}', others_describetions =N'{5}'
        WHERE id =N'{6}'";

        sql = string.Format(sql, type, name_family, phone_number, bailment_date, ret_date, others_describetions, id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public void Delete(string id)
    {
        string Sql = "delete from ret where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from ret";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search(string id)
    {
        string Sql = "select * from ret where id=N'" + id+ "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid()
    {
        string Sql = @"SELECT     id AS شماره, name_family AS [نام و نام خانوادگی امانت گیرنده],
  part_name_fk AS [نام بخش] ,type AS نوع, phone_number AS [شماره تلفن],bailment_date AS [تاریخ امانت], 
                      ret_date AS [تاریخ سررسید], others_describetions AS [سایر توضیحات]
                      FROM  ret";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    
}

