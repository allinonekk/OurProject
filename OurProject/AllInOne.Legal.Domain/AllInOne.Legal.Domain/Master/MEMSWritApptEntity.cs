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

    /// <summary>Class which represents the entity 'Master.MEMSWritAppt'</summary>
    [Serializable]
    public class MEMSWritApptEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the EMSWritApptCode field. </summary>
        public System.String EMSWritApptCode
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

        /// <summary>Gets or sets the MCaseType field. </summary>
        public MCaseTypeEntity MCaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MEMSApptType field. </summary>
        public MEMSApptTypeEntity MEMSApptType
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
            MEMSWritApptEntity toCompareWith = obj as MEMSWritApptEntity;
            return toCompareWith == null ? false : ((this.EMSWritApptCode == toCompareWith.EMSWritApptCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSWritApptCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}