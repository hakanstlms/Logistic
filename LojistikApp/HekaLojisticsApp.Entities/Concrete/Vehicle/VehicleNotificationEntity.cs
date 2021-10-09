using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
   public  class VehicleNotificationEntity
    {
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleNotificationId { get; set; }
        public string VehicePlate { get; set; }
        // Bakım Adım
        public int CareStep { get; set; }
        public char MailNotification { get; set; }
        public char SmsNotification { get; set; }
        public char ExtraNotification { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

    }
}
