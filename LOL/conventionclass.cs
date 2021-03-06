using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

class conventionclass:searchclass 
{
    DAL DA = new DAL();
    public void Add(string id, string convention_subject, string project_adviser,
    string convention_date, string place_keeping, string others_describetions, bool bailmented)
    {
       
        string sql = @"INSERT INTO convention
        (id, convention_subject, project_adviser, convention_date,
        place_keeping, others_describetions,part_name_fk,bailmented) 
        values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7})";

        global g = new global();
        sql= string.Format(sql,id, convention_subject, project_adviser,
        convention_date, place_keeping, others_describetions, g.get_part_name_fk(), Convert.ToInt32(bailmented));

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

    public void Edit(string convention_subject, string project_adviser, string convention_date,
        string place_keeping, string others_describetions, string id)
    {
        string sql = @"UPDATE convention SET convention_subject =N'{0}', project_adviser =N'{1}', convention_date =N'{2}',
        place_keeping =N'{3}',others_describetions =N'{4}' WHERE id =N'{5}'";

        sql = string.Format(sql, convention_subject, project_adviser, convention_date, place_keeping,
            others_describetions,id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE convention SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public void Delete(string id)
    {
        string Sql = "delete from convention where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    public DataTable Search()
    {
        string Sql = "select * from convention";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    public DataTable Search(string id)
    {
        string Sql = "select * from convention where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, convention_subject AS [موضوع قرارداد], project_adviser AS [مشاور پروژه],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], convention_date AS [تاریخ قرارداد], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات]
                      FROM  convention where part_name_fk=N'" + part_name_fk + "'";
                      
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT id AS شماره, convention_subject AS [موضوع قرارداد], project_adviser AS [مشاور پروژه],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], convention_date AS [تاریخ قرارداد], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات]
                      FROM  convention ";

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from convention where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


}
 
