using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

public class cd_dvdclass:searchclass 
{
    DAL DA = new DAL();
    public void Add(string id, bool type_cd, bool type_dvd,string title_in_tablet, string place_keeping, string others_describetions,
       bool bailmented)
    {

        string sql = @"INSERT INTO cd_dvd
       (id, type_cd, type_dvd, title_in_tablet,place_keeping,others_describetions,
        part_name_fk, bailmented) values(N'{0}',{1},{2},N'{3}',N'{4}',N'{5}',N'{6}',{7})";

        global g = new global();
        sql = string.Format(sql, id, Convert.ToInt32(type_cd), Convert.ToInt32(type_dvd), title_in_tablet, place_keeping,
        others_describetions,g.get_part_name_fk() , Convert.ToInt32(bailmented));

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();

    }

    //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
    public void Edit( bool type_cd, bool type_dvd,string title_in_tablet,string place_keeping, string others_describetions,
    string id)
    {
        string sql = @"UPDATE cd_dvd SET type_cd ={0}, type_dvd ={1},title_in_tablet=N'{2}', place_keeping =N'{3}',
     others_describetions=N'{4}' WHERE id =N'{5}'";

        sql = string.Format(sql, Convert.ToInt32(type_cd), Convert.ToInt32(type_dvd), title_in_tablet, place_keeping,
        others_describetions,id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }
    public void Edit_bailmented(bool bailmented, string id)
    {
        string sql = @"UPDATE cd_dvd SET  bailmented={0} where id =N'{1}'";

        sql = string.Format(sql, Convert.ToInt32(bailmented), id);

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public void Delete(string id)
    {
        string Sql = "delete from cd_dvd where id=N'" + id + "'";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }


    public DataTable Search()
    {
        string Sql = "select * from cd_dvd ";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    
    public DataTable Search(string id)
    {
        string Sql = "select * from cd_dvd where id=N'" + id + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
    public DataTable Search_grid(string part_name_fk)
    {
        string Sql = @"SELECT id AS شماره, type_cd AS [سی دی], type_dvd AS [دی وی دی],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], title_in_tablet AS [عناوین موجود در لوح فشرده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] 
                      FROM cd_dvd where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_grid1()
    {
        string Sql = @"SELECT id AS شماره, type_cd AS [سی دی], type_dvd AS [دی وی دی],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], title_in_tablet AS [عناوین موجود در لوح فشرده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] 
                      FROM cd_dvd";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable Search_partname_fk(string part_name_fk)
    {
        string Sql = "select * from cd_dvd where part_name_fk=N'" + part_name_fk + "'";
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
}

