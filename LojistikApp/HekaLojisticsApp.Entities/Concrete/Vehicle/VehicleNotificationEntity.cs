using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleNotificationEntity : BaseEntity, IEntity
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
