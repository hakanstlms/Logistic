using System.Reflection;

namespace HekaLojisticsApp.Core.Settings
{
    public static class AppSetting
    {

        #region FIELDS

        

        #region PRODUCT INFORMATION
        public static string PRODUCT_NAME { get; set; }

      //  public static string PRODUCT_VERSION { get; set; }

        public static string PRODUCT_VERSION
        {
            get
            {
                return  Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }


        public static string PRODUCT_LOGO_URL { get; set; }
        #endregion


        #region SYSTEM

        public static string DISK_SIZE { get; set; }

        public static string MACHINE_NAME { get; set; }

        public static string IP_ADRESS { get; set; }

        #endregion

        public static string URL {get; } = "http://localhost:42151";

        public static string PORT { get; set; } = ":42151";

        public static bool IS_SSL { get; set; } = false;

        public static string CopyRightText { get; } = "Copyright © 2021-2022. lojistikapp.io. All rights reserved.";



        #region DATABASE
        public static string DB_SERVER_ADRDESS { get; set; }
        public static string DB_USER_NAME { get; set; }
        public static string DB_PASSWORD { get; set; }

        public static int DB_PORT { get; set; }

        public static string ConnectionStrings = @"Server=DESKTOP-P18LD6G;Database=LojistikAppDB;Trusted_Connection=True;Connect Timeout = 30; MultipleActiveResultSets=True;";


        #endregion

        #region SMS
        public static string SMS_SERVER_ADRDESS { get; set; }
        public static string SMS_USER_NAME { get; set; }
        public static string SMS_PASSWORD { get; set; }
        #endregion

        #region FTP
        public static string FTP_SERVER_ADRDESS { get; set; }
        public static string FTP_USER_NAME { get; set; }
        public static string FTP_PASSWORD { get; set; }
        #endregion

        #region MAIL
        public static string MAIL_SERVER_ADRDESS { get; set; }
        public static string MAIL_USER_NAME { get; set; }
        public static string MAIL_PASSWORD { get; set; }
        #endregion

        #region PATHS

        public static string IMG__UPLOAD_PATH { get; set; }
        public static string PDF__UPLOAD_PATH { get; set; }

        public static string TEMP_PATH { get; set; }


        #endregion

        #endregion
 
        #region METHODS
        #endregion

        #region EVENTS
        #endregion



    }
}
