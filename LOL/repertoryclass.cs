using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class repertoryclass:searchclass 
{
    DAL DA = new DAL();
    public void Add(string id, string subject, string provider_company, string year_into_atelier,
       string place_keeping, string others_describetions, bool bailmented)
    {

        string sql = @"INSERT INTO repertory
        (id, subject, provider_company, year_into_atelier, place_keeping, 
        others_describetions, part_name_fk, bailmented )
        values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7})";

        global g = new global();
        sql = string.Format(sql, id, subject, provider_company, year_into_atelier,
            place_keeping,others_describetions,g.get_part_name_fk(), Convert.ToInt32(bailmented));

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();

    }


    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeedddddddddddddddiiiiiiiiiiiittttttttttt
    public void Edit(string subject, string provider_company, string year_into_atelier,
       string place_keeping, string others_describetions, string id)
    {
        string sql = @"UPDATE repertory
        SET  subject =N'{0}', provider_company =N'{1}', year_into_atelier =N'{2}', place_keeping =N'{3}',
        others_describetions =N'{4}' where id =N'{5}'";

        sql = string.Format(sql, subject, provider_company, year_into_atelier,
            place_keeping, others_describetions, id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE repertory SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Delete(string id)
    {
        string Sql = "delete from repertory where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from repertory";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search(string id)
    {
        string Sql = "select * from repertory where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, subject AS موضوع, provider_company AS [شرکت تولید کننده], part_name_fk as [نام بخش],bailmented AS [امانت داده شده],year_into_atelier AS [زمان ورورد به بخش], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات]
                     FROM repertory  where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT id AS شماره, subject AS موضوع, provider_company AS [شرکت تولید کننده], part_name_fk as [نام بخش],bailmented AS [امانت داده شده],year_into_atelier AS [زمان ورورد به بخش], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات]
                     FROM repertory";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from repertory where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
}

