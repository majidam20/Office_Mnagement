using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

class zuncanclass:searchclass 
{
    DAL DA = new DAL();

    public void Add(string id, string titles_in_zuncan, string place_keeping,
        string others_describetions, bool bailmented)
    {
        string sql = @"INSERT INTO zuncan (id, titles_in_zuncan, place_keeping,
        others_describetions, part_name_fk, 
        bailmented) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5})";
        
        global g=new global();
        sql = string.Format(sql, id, titles_in_zuncan, place_keeping,
            others_describetions,g.get_part_name_fk() , Convert.ToInt32(bailmented));

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }
    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

    public void Edit(string titles_in_zuncan, string place_keeping, string others_describetions,string id)
    {
        string sql = @"UPDATE zuncan SET titles_in_zuncan =N'{0}',
        place_keeping =N'{1}',others_describetions =N'{2}' WHERE id =N'{3}'";

        sql = string.Format(sql, titles_in_zuncan, place_keeping,
            others_describetions, id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE zuncan SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }



    public void Delete(string id)
    {
        string Sql = "delete from zuncan where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from zuncan";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search(string id)
    {
        string Sql = "select * from zuncan where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, titles_in_zuncan AS [عناوین موجود در زونکن], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     FROM zuncan  where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT id AS شماره, titles_in_zuncan AS [عناوین موجود در زونکن], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     FROM zuncan";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from zuncan where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

}

