using System;
using System.Collections.Generic;
using System.Text;

    class global
    {

        static public string server_add;
        static public string db_uid;
        static public string db_pass;
        static public string part_name_fk;

        static public string COdeClipBoard;
        static public string COdeClipBoard_name;
        static public bool IsAdmin;
        static public string  user_id;//uuuu
        //cbtype
        static public bool album;
        static public bool book;
        static public bool cd_dvd;
        static public bool magazine;
        static public bool report;
        static public bool repertory;
        static public bool map;
        static public bool resume;
        static public bool zuncan;
        static public bool convention;
       
        public void set_user_id(string uid)//uuuu
        {
            user_id  = uid;
        }

        public string get_user_id()//uuuu
        {
            return user_id;
        }

        public void set(string serv_add,string id,string pass)
        {
            server_add = serv_add;
            db_uid = id;
            db_pass = pass;
            
        }

        public void set_CodeClipBoard(string code)
        {
            COdeClipBoard = code;
        }
        public void set_CodeClipBoard_name(string name)
        {
            COdeClipBoard_name = name;
        }
        public void set_part_name(string part_name)
        {
            part_name_fk = part_name;
        }

        public void set_IsAdmin(bool IsAdmin1)
        {
            IsAdmin = IsAdmin1;
        }
        
        
        public string get_serv_add()
        {
            return server_add;
        }
        public string get_db_uid()
        {
            return db_uid;
        }
        public string get_db_pass()
        {
            return db_pass;
        }
        public string get_part_name_fk()
        {
            return part_name_fk;
        }

        public string get_CodeClipBoard()
        {
            return COdeClipBoard ;
        }
        public string get_CodeClipBoard_name()
        {
            return COdeClipBoard_name;
        }

        public bool get_IsAdmin()
        {
            return IsAdmin;
        }
//cb type=form bailment

        //album
        public void  set_album(bool album1)
        {
            album=album1;
        }
        public bool get_album()
        {
            return album;
        }

        //book
        public void set_book(bool book1)
        {
            book = book1;
        }
        public bool get_book()
        {
            return book;
        }
        //cd_dvd
        public void set_cd_dvd(bool cd_dvd1)
        {
            cd_dvd = cd_dvd1;
        }
        public bool get_cd_dvd()
        {
            return cd_dvd;
        }
        //magazine
        public void set_magazine(bool magazine1)
        {
            magazine = magazine1;
        }
        public bool get_magazine()
        {
            return magazine;
        }
        //report
        public void set_report(bool report1)
        {
            report = report1;
        }
        public bool get_report()
        {
            return report;
        }
        //repertory
        public void set_repertory(bool repertory1)
        {
            repertory = repertory1;
        }
        public bool get_repertory()
        {
            return repertory;
        }
        //map
        public void set_map(bool map1)
        {
            map = map1;
        }
        public bool get_map()
        {
            return map;
        }
        //resume
        public void set_resume(bool resume1)
        {
            resume = resume1;
        }
        public bool get_resume()
        {
            return resume;
        }
        //zuncan
        public void set_zuncan(bool zuncan1)
        {
            zuncan = zuncan1;
        }
        public bool get_zuncan()
        {
            return zuncan;
        }

        //convention
        public void set_convention(bool convention1)
        {
            convention = convention1;
        }
        public bool get_convention()
        {
            return convention;
        }
    }

