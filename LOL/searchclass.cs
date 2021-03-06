using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class searchclass
{
    DAL DA = new DAL();



    public DataTable album_search(string key,string select_part_name, string az_date_1, string az_date_2,
    bool az_date, bool id, bool title,bool part_name ,bool zone, bool type, bool part, bool area_describe,
    bool provider_name, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;//false:in avaliye /////true :or bezar
        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
                     zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
                     provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
                     
                    FROM Album where (";
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

       

        if (az_date)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((provide_year>=N'{0}') and  (provide_year<=N'{1}'))";
            else
            {
                Sql += "((provide_year>=N'{0}') and  (provide_year<=N'{1}'))";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, az_date_1, az_date_2);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (title)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(title like N'%{0}%')";
            else
            {
                Sql += "(title like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (zone)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(zone like N'%{0}%')";
            else
            {
                Sql += "(zone like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (type)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(type like N'%{0}%')";
            else
            {
                Sql += "(type like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (part)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part like N'%{0}%')";
            else
            {
                Sql += "(part like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (area_describe)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(area_describe like N'%{0}%')";
            else
            {
                Sql += "(area_describe like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (provider_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(provider_name like N'%{0}%')";
            else
            {
                Sql += "(provider_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        //pppppppppp
       
       
            if (select_part_name == "همه بخش ها")
            {
                Sql += ") and" + "(part_name_fk like N'%%')";
                Sql = string.Format(Sql, select_part_name);
            }
            else
            {
                Sql += ") and" + "(part_name_fk=N'{0}')";
                Sql = string.Format(Sql, select_part_name);
            }
       // Sql = string.Format(Sql, select_part_name);
        //eeeeeepppppppp
        
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    public DataTable book_search(string key,string select_part_name, bool id, bool title, bool writer_name, 
        bool part_name,bool adverties_name,bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, title AS عنوان,part_name_fk as [نام بخش], bailmented AS [امانت داده شده], writer_name AS [نام نویسنده], adverties_name AS [نام انتشارات], place_keeping AS [محل نگهداری], 
                     others_describetions AS [سایر توضیحات] FROM book
                     where (";

        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (title)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(title like N'%{0}%')";
            else
            {
                Sql += "(title like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (writer_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(writer_name like N'%{0}%')";
            else
            {
                Sql += "(writer_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (adverties_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(adverties_name like N'%{0}%')";
            else
            {
                Sql += "(adverties_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
       
        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }



    //7777777777777777777777777

    public DataTable cd_dvd_search(string key,string select_part_name ,bool id, bool type_cd, bool type_dvd,bool part_name, bool title_in_tablet,
    bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, type_cd AS [سی دی], type_dvd AS [دی وی دی],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], title_in_tablet AS [عناوین موجود در لوح فشرده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] FROM cd_dvd
                      where (";
      
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (type_cd)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(type_cd=1)";
            else
            {
                Sql += "(type_cd=1)";
                not_fisrt = true;
            }

            Sql = string.Format(Sql,key);
        }

        if (type_dvd)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(type_dvd=1)";
            else
            {
                Sql += "(type_dvd=1)";
                not_fisrt = true;
            }

            Sql = string.Format(Sql,key);
        }

        if (title_in_tablet)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(title_in_tablet like N'%{0}%')";
            else
            {
                Sql += "(title_in_tablet like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp
        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    //888888888888888888888888888888

    public DataTable convention_search(string key,string select_part_name, string az_date_1, string az_date_2,
    bool az_date, bool id,
        bool convention_subject, bool project_adviser, 
   bool part_name, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, convention_subject AS [موضوع قرارداد], project_adviser AS [مشاور پروژه],part_name_fk as [نام بخش],bailmented AS [امانت داده شده], convention_date AS [تاریخ قرارداد], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات]  FROM  convention
                      where (";
                     
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (az_date)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((convention_date>=N'{0}') and  (convention_date<=N'{1}'))";
            else
            {
                Sql += "((convention_date>=N'{0}') and  (convention_date<=N'{1}'))";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, az_date_1, az_date_2);
        }


        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (convention_subject)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(convention_subject like N'%{0}%')";
            else
            {
                Sql += "(convention_subject like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (project_adviser)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(project_adviser like N'%{0}%')";
            else
            {
                Sql += "(project_adviser like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    //99999999999999999999999999999999999999999

    public DataTable magazine_search(string key,string select_part_name, string az_date_1, string az_date_2,
    bool az_date, bool id, bool name, bool subject,bool part_name, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT  id AS شماره, name AS نام, distribute_date AS [زمان انتشار], subject AS موضوع, part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] FROM  magazine
                      where (";
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (az_date)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((distribute_date>=N'{0}') and  (distribute_date<=N'{1}'))";
            else
            {
                Sql += "((distribute_date>=N'{0}') and (distribute_date<=N'{1}'))";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, az_date_1, az_date_2);
        }

        if (name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(name like N'%{0}%')";
            else
            {
                Sql += "(name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (subject)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(subject like N'%{0}%')";
            else
            {
                Sql += "(subject like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

               if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    //000000000000000000000000000000000000

   
     public DataTable map_search(string key,string select_part_name, bool id, bool project, bool size, bool part_name,
         bool adviser, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, project AS پروژه, size AS ابعاد, adviser AS مشاور,part_name_fk as [نام بخش],bailmented AS [امانت داده شده] , place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات]
                     FROM map where (";
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (project)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(project like N'%{0}%')";
            else
            {
                Sql += "(project like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (size)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(size like N'%{0}%')";
            else
            {
                Sql += "(size like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (adviser)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(adviser like N'%{0}%')";
            else
            {
                Sql += "(adviser like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    //111111111111111111111111111111111111111

    public DataTable repertory_search(string key,string select_part_name, string az_date_1, string az_date_2,
    bool az_date,
        bool id, bool subject, bool provider_company, bool part_name,bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, subject AS موضوع, provider_company AS [شرکت تولید کننده], part_name_fk as [نام بخش],bailmented AS [امانت داده شده],year_into_atelier AS [زمان ورورد به بخش], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات]
         FROM repertory where (";
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (az_date)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((year_into_atelier>=N'{0}') and  (year_into_atelier<=N'{1}'))";
            else
            {
                Sql += "((year_into_atelier>=N'{0}') and  (year_into_atelier<=N'{1}'))";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, az_date_1, az_date_2);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (subject)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(subject like N'%{0}%')";
            else
            {
                Sql += "(subject like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (provider_company)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(provider_company like N'%{0}%')";
            else
            {
                Sql += "(provider_company like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        
        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

//2222222222222222222222222222222222222222222222222222222222

    public DataTable report_search(string key,string select_part_name, bool id, bool title, bool subject,bool part_name, bool provider_name, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, title AS عنوان, subject AS موضوع,part_name_fk as [نام بخش],bailmented AS [امانت داده شده],provider_name AS [تهیه کننده], place_keeping AS [محل نگهداری], 
                      others_describetions AS [سایر توضیحات] FROM  report
                      where (";
       
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (title)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(title like N'%{0}%')";
            else
            {
                Sql += "(title like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (subject)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(subject like N'%{0}%')";
            else
            {
                Sql += "(subject like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (provider_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(provider_name like N'%{0}%')";
            else
            {
                Sql += "(provider_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

//33333333333333333333333333333333333333333333333333


    public DataTable resume_search(string key,string select_part_name, bool id,bool part_name ,bool applicant_name, bool action_type, bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, applicant_name AS [نام درخواست کننده], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], action_type AS [نوع کار],
                      place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] FROM resume
                     where (";

        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (applicant_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(applicant_name like N'%{0}%')";
            else
            {
                Sql += "(applicant_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (action_type)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(action_type like N'%{0}%')";
            else
            {
                Sql += "(action_type like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        
        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
         //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    //44444444444444444444444444444444444444444444444444

    public DataTable zuncan_search(string key,string select_part_name, bool id, bool titles_in_zuncan, bool part_name,
        bool place_keeping, bool others_describetions)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره, titles_in_zuncan AS [عناوین موجود در زونکن], 
                     part_name_fk as [نام بخش],bailmented AS [امانت داده شده], place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] FROM zuncan
                     where (";
       
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (titles_in_zuncan)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(titles_in_zuncan like N'%{0}%')";
            else
            {
                Sql += "(titles_in_zuncan like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        
        if (place_keeping)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(place_keeping like N'%{0}%')";
            else
            {
                Sql += "(place_keeping like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
         //pppppppppp
        if (select_part_name == "همه بخش ها")
        {
            Sql += ") and" + "(part_name_fk like N'%%')";
        }
        else
        {
            //part = select_part_name;
            Sql += ") and" + "(part_name_fk like N'%{0}%')";
            Sql = string.Format(Sql, select_part_name);
        }
        //eeeeeepppppppp

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


//55555555555555555555555555555555555555555555555555555555

    public DataTable users_search(string key, bool name, bool family,bool part_name ,bool uid)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT name AS نام, family AS [نام خانوادگی],part_name_fk as [نام بخش]
         , uid AS [نام کاربری]
                     FROM  users where ";

        if (name)
        {
            if (not_fisrt == true)
                Sql += "(name like N'%{0}%')";
            else
            {
                Sql += "(name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if (part_name )
        {
            if (not_fisrt == true)
                Sql += "or"+"(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (family)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(family like N'%{0}%')";
            else
            {
                Sql += "(family like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (uid)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(uid like N'%{0}%')";
            else
            {
                Sql += "(uid like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

       

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }

    //66666666666666666666666666666666666666666666666666666666

    public DataTable part_Search(string part_name)
    {
        string Sql = @"SELECT part_name AS [نام بخش], album AS آلبوم, book AS کتاب, 
        CD_DVD AS [لوح فشرده], magazine AS مجله, report AS گزارش, repertory AS کاتالوگ,
        map AS نقشه,resume AS رزومه, zuncan AS زونکن, convention AS قرارداد FROM parts
        where part_name like N'%{0}%'";
        
        Sql = string.Format(Sql, part_name);

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    public DataTable ret_search(string key, string az_date_1, string az_date_2,
    bool az_date, string az_date_ret1, string az_date_ret2, bool az_date_ret,
       
        bool id, bool type, bool name_family,bool part_name,
        bool phone_number,bool others_describetions)
    {
               bool not_fisrt = false;
               string Sql = @"SELECT id AS شماره,name_family AS [نام و نام خانوادگی امانت گیرنده],part_name_fk AS [نام بخش] , 
              type AS نوع,phone_number AS [شماره تلفن],bailment_date AS [تاریخ امانت], 
              ret_date AS [تاریخ سررسید], others_describetions AS [سایر توضیحات] FROM  ret
              where ";
       
        if (id)
        {
            if (not_fisrt == true)
                Sql += "(id like N'%{0}%')";
            else
            {
                Sql += "(id like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (az_date)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((bailment_date>=N'{0}') and  (bailment_date<=N'{1}'))";
            else
            {
                Sql += "((bailment_date>=N'{0}') and  (bailment_date<=N'{1}'))";
                not_fisrt = true;
            }


            Sql = string.Format(Sql, az_date_1, az_date_2);
        }
        if (az_date_ret)
        {
            if (not_fisrt == true)
                Sql += "OR" + "((ret_date>=N'{0}') and  (ret_date<=N'{1}'))";
            else
            {
                Sql += "((ret_date>=N'{0}') and  (ret_date<=N'{1}'))";
                not_fisrt = true;
            }
            Sql = string.Format(Sql, az_date_ret1, az_date_ret2);
        }


        if (part_name)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }



        if (type)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(type like N'%{0}%')";
            else
            {
                Sql += "(type like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (name_family)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(name_family like N'%{0}%')";
            else
            {
                Sql += "(name_family like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (phone_number)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(phone_number like N'%{0}%')";
            else
            {
                Sql += "(phone_number like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += "OR" + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }



        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }


    //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaaaaaaaaaaiiiiiiiiiiiillllll

    public DataTable bailment_search(string key,bool bail_yes,bool bail_no,string az_date_1, string az_date_2,
    bool az_date,string az_date_ret1,string az_date_ret2,bool az_date_ret,
      string late_date,bool late_date5,
        bool id, bool name_family, bool part_name, bool type,bool name,
        bool unit_name,bool phone_number, bool others_describetions,string manteghi,string part_name_st)
    {
        bool not_fisrt = false;
        string Sql = @"SELECT id AS شماره,name as نام,bailmented as [امانت داده شده] , name_family AS [نام و نام خانوادگی امانت گیرنده],
        part_name_fk AS [نام بخش],type AS نوع,bailment_date AS [تاریخ تحویل],ret_date AS [سررسید تحویل],
         bail_ret_date as[تاریخ بازگشت],
         unit_name as [واحد امانت گیرنده] ,phone_number AS [شماره تلفن],
         others_describetions AS [سایر توضیحات]
         FROM  bailment where ( ";

        if (id)
        {
            Sql += "(id like N'%{0}%')";
            if (not_fisrt == false)
            {
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
  
        if (az_date)
        {
            if (not_fisrt == true)
                Sql += manteghi + "((bailment_date>=N'{0}') and  (bailment_date<=N'{1}'))";
            else
            {
                Sql += "((bailment_date>=N'{0}') and  (bailment_date<=N'{1}'))";
                not_fisrt = true;
            }


            Sql = string.Format(Sql, az_date_1, az_date_2);
        }
        if (az_date_ret)
        {
            if (not_fisrt == true)
                Sql += manteghi + "((ret_date>=N'{0}') and  (ret_date<=N'{1}'))";
            else
            {
                Sql += "((ret_date>=N'{0}') and  (ret_date<=N'{1}'))";
                not_fisrt = true;
            }
            Sql = string.Format(Sql,az_date_ret1, az_date_ret2 );
        }
        //lllllllllllllllllllllllllllaaaaaaaaaaaaaate
        
        if ((bail_yes)&& !(late_date5))
        {
            if (not_fisrt == true)
                Sql += manteghi+"(bailmented=1)";
            else
            {
                Sql += "(bailmented=1)";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (bail_no)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(bailmented=0)";
            else
            {
                Sql += "(bailmented=0)";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }
        if ((late_date5)&&(bail_yes))
        {
            if (not_fisrt == true)
                Sql += manteghi + "((ret_date<N'{0}')and (bailmented=1))";
            else
            {
                Sql += "((ret_date<N'{0}') and (bailmented=1))";
                not_fisrt = true;
            }


            Sql = string.Format(Sql, late_date);
        }
        //lllllllllllllllaaaaaaaaaaaattttttttttttttttteeeeeeee
        if (part_name)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (name_family)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(name_family like N'%{0}%')";
            else
            {
                Sql += "(name_family like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (type)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(type like N'%{0}%')";
            else
            {
                Sql += "(type like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (name)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(name like N'%{0}%')";
            else
            {
                Sql += "(name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        
        if (unit_name)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(unit_name like N'%{0}%')";
            else
            {
                Sql += "(unit_name like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        if (phone_number)
        {
            if (not_fisrt == true)
                Sql +=manteghi + "(phone_number like N'%{0}%')";
            else
            {
                Sql += "(phone_number like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }


        if (others_describetions)
        {
            if (not_fisrt == true)
                Sql += manteghi + "(others_describetions like N'%{0}%')";
            else
            {
                Sql += "(others_describetions like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, key);
        }

        //#############################################################################

        if (part_name_st == "همه بخش ها")
        {
            if (not_fisrt == true)
                Sql += ")AND" + "(part_name_fk like N'%%')";
            else
            {
                Sql += "(part_name_fk like N'%%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, part_name_st);
        }

        else if (part_name_st != "همه بخش ها")
        {
            if (not_fisrt == true)
                Sql += ")AND" + "(part_name_fk like N'%{0}%')";
            else
            {
                Sql += "(part_name_fk like N'%{0}%')";
                not_fisrt = true;
            }

            Sql = string.Format(Sql, part_name_st);
        }
        //#####################################################################################

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        return dt;
    }
//    public DataTable album_Search_date(string provide_year)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                     zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                     provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//                     FROM Album where provide_year like N'%{0}%'";

//        Sql = string.Format(Sql, provide_year);

//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }



/*
        if (title)
            Sql = string.Format(Sql, key, "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}");

        if (zone)
            Sql = string.Format(Sql, key, "{0}", "{1}", "{2}", "{3}", "{4}", "{5}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}", "{2}", "{3}", "{4}", "{5}");



        if (type)
            Sql = string.Format(Sql, key, "{0}", "{1}", "{2}", "{3}", "{4}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}", "{2}", "{3}", "{4}");


        if (part)
            Sql = string.Format(Sql, key, "{0}", "{1}", "{2}","{3}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}", "{2}","{3}");

        if (area_describe)
            Sql = string.Format(Sql, key, "{0}", "{1}", "{2}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}", "{2}");


        if (provider_name)
            Sql = string.Format(Sql, key, "{0}", "{1}");
        else
            Sql = string.Format(Sql, "", "{0}", "{1}");


        if (place_keeping)
            Sql = string.Format(Sql, key, "{0}");
        else
            Sql = string.Format(Sql, "", "{0}");

        if (others_describetions)
            Sql = string.Format(Sql, key);
        else
            Sql = string.Format(Sql, "");  


        
        

    }
        */
//    public DataTable fullsearch_title(string title)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where title like N'%{0}%'";

//        Sql = string.Format(Sql, title);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_zone(string zone)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where (zone like N'%{0}%') ";

//        Sql = string.Format(Sql, zone);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_type(string type)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where type like N'%{0}%'";

//        Sql = string.Format(Sql, type);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_part(string part)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where part like N'%{0}%'";

//        Sql = string.Format(Sql, part);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_area_describe(string area_describe)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where area_describe like N'%{0}%'";

//        Sql = string.Format(Sql, area_describe);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_provider_name(string provider_name)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where provider_name like N'%{0}%'";

//        Sql = string.Format(Sql, provider_name);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_place_keeping(string place_keeping)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where place_keeping like N'%{0}%'";

//        Sql = string.Format(Sql, place_keeping);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
//    public DataTable fullsearch_others_describetions(string others_describetions)
//    {
//        string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
//                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
//                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
//            
//                         FROM Album where others_describetions like N'%{0}%'";

//        Sql = string.Format(Sql, others_describetions);
//        DataTable dt = new DataTable();
//        DA.Connect();
//        dt = DA.Select(Sql);
//        DA.Disconnect();
//        return dt;
//    }
        public DataTable fullsearch_all(string all)
        {
            string Sql = @"SELECT id AS شماره, title AS [عنوان آلبوم],part_name_fk as [نام بخش], bailmented AS [امانت داده شده],
                         zone AS منطقه, type AS  [نوع آلبوم], part AS قطعه, area_describe AS مساحت, provider_name AS [نام تهیه کننده],
                         provide_year AS [سال تهیه],place_keeping AS [محل نگهداری], others_describetions AS [سایر توضیحات] 
            
                         FROM Album where (id like N'%{0}%') or (title like N'%{0}%')
                         or (zone like N'%{0}%')or (type like N'%{0}%')or (part like N'%{0}%')
                         or (area_describe like N'%{0}%')or (provider_name like N'%{0}%')
                         or (place_keeping like N'%{0}%')or (others_describetions like N'%{0}%')";

            Sql = string.Format(Sql, all);
            DataTable dt = new DataTable();
            DA.Connect();
            dt = DA.Select(Sql);
            DA.Disconnect();
            return dt;
        }

}

    




