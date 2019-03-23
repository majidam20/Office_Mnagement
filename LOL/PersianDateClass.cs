using System;
using System.Collections.Generic;
using System.Text;



public  class PersianDateClass
    {
        public static string ShamsiDate()
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            DateTime d = DateTime.Now;
            string DayNow=p.GetDayOfMonth(d).ToString();
            if(DayNow.Length==1)
                DayNow="0"+DayNow;
            string MonthNow=p.GetMonth(d).ToString();
            if(MonthNow.Length==1)
                MonthNow="0"+MonthNow;
            string DateNow = p.GetYear(d).ToString() + "/" + MonthNow + "/" + DayNow;
            return DateNow;
        }
    }

