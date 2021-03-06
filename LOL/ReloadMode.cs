using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

    class ReloadMode:searchclass
    {
        DAL DA = new DAL();

        public void Add(string part_name, bool album, bool book, bool CD_DVD, bool magazine, bool report, bool repertory, bool map, bool resume, bool zuncan, bool convention, bool admin)
        {
            string Sql = @"INSERT INTO parts (part_name, album, book, 
        CD_DVD, magazine,report, repertory, map, resume, zuncan, convention,admin)
        values (N'{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})";

            Sql = string.Format(Sql, part_name, Convert.ToInt32(album), Convert.ToInt32(book), Convert.ToInt32(CD_DVD), Convert.ToInt32(magazine),
            Convert.ToInt32(report), Convert.ToInt32(repertory), Convert.ToInt32(map), Convert.ToInt32(resume), Convert.ToInt32(zuncan), Convert.ToInt32(convention), Convert.ToInt32(admin));
            DA.Connect();
            DA.DoCommand(Sql);
            DA.Disconnect();
        }

        public void Edit(bool album, bool book, bool CD_DVD, bool magazine, bool report, bool repertory, bool map, bool resume,
            bool zuncan, bool convention, bool users,bool parts)
        {
            string Sql = @"UPDATE    ReloadMode
             SET  album ={0}, book ={1}, CD_DVD ={2}, magazine ={3}, report ={4},
             repertory ={5}, map ={6}, resume ={7}, zuncan ={8}, convention ={9}, users ={10}, parts ={11}";

            Sql = string.Format(Sql, Convert.ToInt32(album), Convert.ToInt32(book), Convert.ToInt32(CD_DVD), Convert.ToInt32(magazine),
            Convert.ToInt32(report), Convert.ToInt32(repertory), Convert.ToInt32(map), Convert.ToInt32(resume), Convert.ToInt32(zuncan),
            Convert.ToInt32(convention), Convert.ToInt32(users), Convert.ToInt32(parts));

            DA.Connect();
            DA.DoCommand(Sql);
            DA.Disconnect();
        }

        public void Delete(string part_name)
        {
            string Sql = "delete from parts where part_name=N'" + part_name + "'";
            DA.Connect();
            DA.DoCommand(Sql);
            DA.Disconnect();
        }


        public DataTable Search()
        {
            string Sql = "select * from ReloadMode";
            DataTable dt = new DataTable();
            DA.Connect();
            dt = DA.Select(Sql);
            DA.Disconnect();
            return dt;
        }

        public DataTable Search(string part_name)
        {
            string Sql = "select * from parts where part_name=N'" + part_name + "'";
            DataTable dt = new DataTable();
            DA.Connect();
            dt = DA.Select(Sql);
            DA.Disconnect();
            return dt;
        }
        public DataTable Search(string field_name, string field_value)
        {
            string Sql = "select * from PARTS where  {0}=N'{1}'";
            Sql = string.Format(Sql, field_name, field_value);
            DataTable dt = new DataTable();
            DA.Connect();
            dt = DA.Select(Sql);
            DA.Disconnect();
            return dt;
        }
        public DataTable search_grid()
        {
            string Sql = @"SELECT part_name AS [نام بخش],admin as [دسترسی به بخش مدیریت سیستم],album AS آلبوم,book AS کتاب, 
        CD_DVD AS [لوح فشرده], magazine AS مجله, report AS گزارش, repertory AS کاتالوگ,
        map AS نقشه,resume AS رزومه, zuncan AS زونکن, convention AS قرارداد FROM parts";
            DataTable dt = new DataTable();
            DA.Connect();
            dt = DA.Select(Sql);
            DA.Disconnect();
            return dt;
        }

        //public DataTable Search(string field_name, string field_value)
        //{
        //    string Sql = "select * from PARTS where  {0}=N'{1}'";
        //    Sql = string.Format(Sql, field_name, field_value);
        //    DataTable dt = new DataTable();
        //    DA.Connect();
        //    dt = DA.Select(Sql);
        //    DA.Disconnect();
        //    return dt;
        //}

        //public DataTable Search(int AId_fk, bool a)
        //{
        //    string Sql = "select * from Kala where AId_fk=" + AId_fk;
        //    DataTable dt = new DataTable();
        //    db.Connect();
        //    dt = db.Select(Sql);
        //    db.Disconnect();
        //    return dt;
        //}
    }

