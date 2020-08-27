using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeleApp.Shared.Utils
{
    public static class GridUtil
    {
        public static string ConvertTypeCall(int typecall)
        {
            string type = "";
            switch (typecall)
            {
                case 1:
                    type = "Cuộc gọi đến";
                    break;
                case 2:
                    type = "Cuộc gọi đi";
                    break;
                case 3:
                    type = "Cuộc gọi nhỡ";
                    break;
                //default:
                //    type = "Không xác định";
                //    break;
            }
            return type;
        }
        public static string ConvertNgay(long createtime)
        {
            System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds( createtime ).ToLocalTime();
            string datetimereturn = dtDateTime.ToString("tt h:mm:ss dd/MM");
            return datetimereturn;
        }
        public static string ConvertDistanceTimeFromNow(long createtime)
        {
            //DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,DateTimeKind.Utc);
            long timeutc7 = 7 * 3600 * 1000;
            TimeSpan time = TimeSpan.FromMilliseconds(createtime - timeutc7);
            DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,DateTimeKind.Utc) + time;
            long unixTimestamp = (long)(DateTime.Now.Subtract(dtDateTime)).TotalMilliseconds;
            string stringDate = ConvertDurationTimeFromNowToString(unixTimestamp);
            
            return stringDate;
        }
        public static string ConvertDurationTimeFromNowToString(long milisecondTime)
        {
            var time = TimeSpan.FromMilliseconds(milisecondTime);
            string timeNew = "";
            if (milisecondTime != 0 && milisecondTime != null)
            {
                //timeNew = string.Format("{0} ngày - {1} giờ - {2} phút - {3} giây", ((int) time.TotalDays), ((int) time.TotalHours), time.Minutes, time.Seconds);
                if (time.TotalDays != 0 && time.TotalDays >= 1) timeNew += ((int)time.TotalDays) + " ngày";
                if (time.TotalDays != 0 && time.TotalDays >= 1 && time.Hours != 0 && time.Hours >= 1) timeNew += " - ";
                if (time.Hours != 0 && time.Hours >= 1) timeNew += ((int)time.Hours) + " giờ";
                if (((time.Hours != 0 && time.Hours >= 1) || (time.TotalDays != 0 && time.TotalDays >= 1)) && time.Minutes != 0 && time.Minutes >= 1) timeNew += " - ";
                if (time.Minutes != 0 && time.Minutes >= 1) timeNew += time.Minutes + " phút";
            }
            return timeNew;
        }
        public static string ConvertDurationTimeToString(long milisecondTime)
        {
            var time = TimeSpan.FromMilliseconds(milisecondTime);
            string timeNew = "";
            if (milisecondTime != 0 && milisecondTime != null)
            {
                //timeNew = string.Format("{0} ngày - {1} giờ - {2} phút - {3} giây", ((int) time.TotalDays), ((int) time.TotalHours), time.Minutes, time.Seconds);
                if (time.TotalDays != 0 && time.TotalDays >= 1) timeNew += ((int)time.TotalDays) + " ngày";
                if (time.TotalDays != 0 && time.TotalDays >= 1 && time.TotalHours != 0 && time.TotalHours >= 1) timeNew += " - ";
                if (time.TotalHours != 0 && time.TotalHours >= 1) timeNew += ((int)time.TotalHours) + " giờ";
                if (time.TotalHours != 0 && time.TotalHours >= 1 && time.Minutes != 0 && time.Minutes >= 1) timeNew += " - ";
                if (time.Minutes != 0 && time.Minutes >= 1) timeNew += time.Minutes + " phút";
                if (time.Minutes != 0 && time.Minutes >= 1 && time.Seconds != 0 && time.Seconds >= 1) timeNew += " - ";
                if (time.Seconds != 0 && time.Seconds >= 1) timeNew += time.Seconds + " giây";
            }
            return timeNew;
        }
        public static string UnixMiliSecondFromDateTime(DateTime time)
        {
            var timeSpan = (time - new DateTime(1970, 1, 1, 0, 0, 0));
            return timeSpan.TotalMilliseconds.ToString();
        }
        public static string GetClassTypeCall(int typecall)
        {
            var classtype = "";
            switch (typecall)
            {
                case 1:
                    classtype = "spancallin";
                    break;
                case 2:
                    classtype = "spancallout";
                    break;
                case 3:
                    classtype = "spancallmiss";
                    break;
            }
            return classtype;
        }
        public static string phoneFormat(object p)
        {
            string phone_ = p.ToString().Trim().Replace(" ", "");
            if (phone_.Count() == 0)
                return "";

            if (phone_.Length == 10)
                phone_ = phone_.Insert(4, " ").Insert(8, " ");
            if (phone_.Length == 11)
                phone_ = phone_.Insert(5, " ").Insert(9, " ");
            if (phone_.Length == 9)
                phone_ = phone_.Insert(3, " ").Insert(7, " ");
            if (phone_.Length == 8)
                phone_ = phone_.Insert(2, " ").Insert(6, " ");
            return phone_.ToString();
        }
        public static string FilterStringUnicode(string str)
        {
            //chuyển sang chữ thường
            if (!string.IsNullOrEmpty(str))
            {
                string strResult = new string(str.Where(c => !char.IsWhiteSpace(c)).ToArray());
                strResult = strResult.ToLower();
                //kí tự a
                strResult = strResult.Replace("à", "a").Replace("á", "a").Replace("ả", "a").Replace("ã", "a").Replace("ạ", "a");
                strResult = strResult.Replace("ă", "a").Replace("ằ", "a").Replace("ắ", "a").Replace("ẳ", "a").Replace("ẵ", "a").Replace("ặ", "a");
                strResult = strResult.Replace("â", "a").Replace("ấ", "a").Replace("ầ", "a").Replace("ẫ", "a").Replace("ẩ", "a").Replace("ậ", "a");
                strResult = strResult.Replace("đ", "d");
                strResult = strResult.Replace("è", "e").Replace("é", "e").Replace("ẻ", "e").Replace("ẽ", "e").Replace("ẹ", "e");
                strResult = strResult.Replace("ê", "e").Replace("ế", "e").Replace("ề", "e").Replace("ể", "e").Replace("ễ", "e").Replace("ệ", "e");
                strResult = strResult.Replace("ì", "i").Replace("í", "i").Replace("ỉ", "i").Replace("ĩ", "i").Replace("ị", "i");
                strResult = strResult.Replace("ò", "o").Replace("ó", "o").Replace("ỏ", "o").Replace("õ", "o").Replace("ọ", "o");
                strResult = strResult.Replace("ô", "o").Replace("ồ", "o").Replace("ố", "o").Replace("ổ", "o").Replace("ỗ", "o").Replace("ộ", "o");
                strResult = strResult.Replace("ơ", "o").Replace("ờ", "o").Replace("ớ", "o").Replace("ở", "o").Replace("ỡ", "o").Replace("ợ", "o");
                strResult = strResult.Replace("ù", "u").Replace("ú", "u").Replace("ủ", "u").Replace("ũ", "u").Replace("ụ", "u");
                strResult = strResult.Replace("ư", "u").Replace("ừ", "u").Replace("ứ", "u").Replace("ử", "u").Replace("ữ", "u").Replace("ự", "u");
                strResult = strResult.Replace("ý", "y").Replace("ỳ", "y").Replace("ỷ", "y").Replace("ỹ", "y").Replace("ỵ", "y");

                return strResult;
            }
            else { 
                return str;
            }
        }
    }
}
