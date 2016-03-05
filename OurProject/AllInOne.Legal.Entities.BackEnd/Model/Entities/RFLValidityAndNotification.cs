﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>Class which represents the entity 'Common.RFLValidityAndNotification'</summary>
    public partial class RFLValidityAndNotification : ICommon
    {


        /// <summary> /// Initializes a new instance of the <see cref="ReqExaminationFeedetail"/> class./// </summary>
        public RFLValidityAndNotification()
            : base()
        {

        }

        #region Properties

        public virtual string RFLValidityNotificationID { get; set; }
        public virtual string SubmissionGroupID { get; set; }
        public virtual long? RFLCaseInfoId { get; set; }
        public virtual DateTime ValidFrom { get; set; }
        public virtual DateTime ValidTo { get; set; }
        public virtual Int32 MonthsNotifiCation { get; set; }
        public virtual Int32 WeeksNotifiCation { get; set; }
        public virtual Int32 DaysNotifiCation { get; set; }
        public virtual string ObsInd { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
        public virtual Int32 RFLVerNo { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            RFLValidityAndNotification toCompareWith = obj as RFLValidityAndNotification;
            return toCompareWith == null ? false : ((this.RFLValidityNotificationID == toCompareWith.RFLValidityNotificationID) && (this.SubmissionGroupID == toCompareWith.SubmissionGroupID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RFLValidityNotificationID.GetHashCode();
            toReturn ^= this.SubmissionGroupID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}