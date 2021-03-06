using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class albumclass : searchclass
{
    DAL DA = new DAL();

    public void Add(string id, string title, string zone, string type, string part, string area_describe,
                      string provider_name, string provide_year, string place_keeping, string others_describetions,bool bailmented)
    {
        string Sql = @"INSERT INTO Album (id, title, zone, type, part, area_describe,
                      provider_name, provide_year, place_keeping, others_describetions,part_name_fk, bailmented)
                      values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',{11})";

        global g = new global();

        Sql = string.Format(Sql, id, title, zone, type, part, area_describe,
          provider_name, provide_year, place_keeping, others_describetions,g.get_part_name_fk(), Convert.ToInt32(bailmented));
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    
    
     
    
    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeedddddddddddddddiiiiiiiiiiiittttttttttt
    public void Edit(string title, string zone, string type, string part, string area_describe,
                      string provider_name, string provide_year, string place_keeping,
        string others_describetions, string id)
    {
        string sql = @"UPDATE Album SET title =N'{0}', zone =N'{1}', type =N'{2}',
        part =N'{3}', area_describe =N'{4}', provider_name =N'{5}', provide_year =N'{6}', 
        place_keeping =N'{7}', others_describetions =N'{8}'
        WHERE id =N'{9}'";

        sql = string.Format(sql,title, zone, type, part, area_describe,
        provider_name, provide_year, place_keeping, others_describetions,id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public void Edit_bailmented(bool bailmented,string id)
    {
        string sql = @"UPDATE Album SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql,Convert.ToInt32(bailmented),id);

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

    public DataTable Search_Count()
    {
        string Sql = "select count(id) as idd from album";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    public DataTable Search()
    {
        string Sql = "select * from album";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
                     zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
                     provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     from album where part_name_fk = N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
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

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from album where part_name_fk=N'" + part_name_fk + "'";
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

