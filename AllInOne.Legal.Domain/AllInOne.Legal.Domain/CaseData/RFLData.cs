using System.Collections.Generic;
using AllInOne.Legal.Domain.Common;
using AllInOne.Legal.Domain.Interfaces;
using System;

namespace AllInOne.Legal.Domain.CaseData
{
    [Serializable]
    public class RFLData : ICaseTypeInfo
    {
        #region Properties

        public List<RegistrationOfForeignLawyerEntity> ListRegistrationOfForeignLawyerEntity
        {
            get;
            set;
        }
        public List<ForeignUserRegAddressDetailsEntity> ListForeignUserRegAddressDetailsEntity
        {
            get;
            set;
        }
        public List<ForeignUserPracticeInformationEntity> ListForeignUserPracticeInformationEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}
