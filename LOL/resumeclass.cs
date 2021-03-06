using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class resumeclass:searchclass 
{
    DAL DA = new DAL();

    public void Add(string id, string applicant_name, string action_type, 
        string place_keeping, string others_describetions, bool bailmented)
    {
        string sql = @"INSERT INTO resume (id, applicant_name, action_type,
        place_keeping, others_describetions,part_name_fk,bailmented) 
        values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6})";

        global g=new global();
        sql = string.Format(sql, id, applicant_name, action_type,
        place_keeping, others_describetions,g.get_part_name_fk(), Convert.ToInt32(bailmented));
        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }



    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

    public void Edit(string applicant_name, string action_type, string place_keeping, string others_describetions, string id)
    {
        string sql = @"UPDATE resume SET applicant_name =N'{0}', action_type =N'{1}',
        place_keeping =N'{2}',others_describetions =N'{3}' WHERE id =N'{4}'";

        sql = string.Format(sql, applicant_name, action_type, place_keeping,
            others_describetions, id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE resume SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Delete(string id)
    {
        string Sql = "delete from resume where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from resume";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search(string id)
    {
        string Sql = "select * from resume where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, applicant_name AS [نام درخواست کننده], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], action_type AS [نوع کار],
                      place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     FROM resume  where part_name_fk=N'" + part_name_fk + "'";

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT id AS شماره, applicant_name AS [نام درخواست کننده], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], action_type AS [نوع کار],
                      place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     FROM resume";

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from resume where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    
}

