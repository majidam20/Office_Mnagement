using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class magazineclass:searchclass 
{
    DAL DA = new DAL();
    public void Add(string id,string name,string distribute_date,string subject,
       string place_keeping,string others_describetions,
        bool bailmented)
    {

        string sql = @"INSERT INTO magazine
        (id, name, distribute_date, subject, place_keeping, others_describetions,
        part_name_fk, bailmented) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7})";

        global g=new global();
        sql = string.Format(sql, id, name, distribute_date, subject, place_keeping,
        others_describetions,g.get_part_name_fk(), Convert.ToInt32(bailmented));

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();

    }


    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

    public void Edit(string name,string distribute_date,string subject,
       string place_keeping,string others_describetions,string id)
    {
        string sql = @"UPDATE magazine SET name =N'{0}', distribute_date =N'{1}', subject =N'{2}',
        place_keeping =N'{3}',others_describetions =N'{4}' WHERE id =N'{5}'";

        sql = string.Format(sql,name, distribute_date, subject, place_keeping,
        others_describetions,id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE magazine SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Delete(string id)
    {
        string Sql = "delete from magazine where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    public DataTable Search()
    {
        string Sql = "select * from magazine";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    public DataTable Search(string id)
    {
        string Sql = "select * from magazine where id=N'"+id+"'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT  id AS شماره, name AS نام, distribute_date AS [زمان انتشار], subject AS موضوع, part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] 
                      FROM  magazine where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT  id AS شماره, name AS نام, distribute_date AS [زمان انتشار], subject AS موضوع, part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] 
                      FROM  magazine";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from magazine where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
}

