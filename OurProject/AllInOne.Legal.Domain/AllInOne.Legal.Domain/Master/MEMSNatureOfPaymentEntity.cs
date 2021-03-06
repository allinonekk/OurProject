﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MEMSNatureOfPaymentEntity.
    /// </summary>
    [Serializable]
    public class MEMSNatureOfPaymentEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSNatureOfPaymentEntity"/> class.</summary>
        public MEMSNatureOfPaymentEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EMSNatureOfPaymentCode field. </summary>
        public System.String EMSNatureOfPaymentCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public Nullable<System.Int32> FrequencyInd
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MEMSNatureOfPaymentEntity toCompareWith = obj as MEMSNatureOfPaymentEntity;
            return toCompareWith == null ? false : ((this.EMSNatureOfPaymentCode == toCompareWith.EMSNatureOfPaymentCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSNatureOfPaymentCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}