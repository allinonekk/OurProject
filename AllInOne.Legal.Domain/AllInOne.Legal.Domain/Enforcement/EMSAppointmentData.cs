namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Serializable]
    public class EMSAppointmentData
    {
        #region Properties

        public List<EMSAppointmentEntity> EMSAppointmentEntity
        {
            get; set;
        }

        public List<EMSApptDateTimeEntity> EMSApptDateTimeEntity
        {
            get; set;
        }

        public List<EMSApptDebtorEntity> EMSApptDebtorEntity
        {
            get; set;
        }

        public List<EMSDisburseClaimEntity> EMSDisburseClaimEntity
        {
            get; set;
        }

        public List<EMSTptClaimEntity> EMSTptClaimEntity
        {
            get; set;
        }

        #endregion Properties
    }
}