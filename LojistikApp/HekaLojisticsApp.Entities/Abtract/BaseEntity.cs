using System;

namespace HekaLojisticsApp.Entities.Base
{
    public abstract class BaseEntity
    {
        #region CTOR
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;

        }

        #endregion


        #region PROPERTIES
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual string CreatedUser { get; set; }
        public virtual string UpdatedUser { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string Description { get; set; }
        #endregion

    }
}
