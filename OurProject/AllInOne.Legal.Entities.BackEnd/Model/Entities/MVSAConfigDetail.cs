﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Master.MSentence'</summary>
    public partial class MVSAConfigDetail : IMaster
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DSGCategory field.
        /// </summary>
        /// <value>The DSG category.</value>
        public virtual string VSAConfigDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DSGCode field.
        /// </summary>
        /// <value>The DSG code.</value>
        public virtual MDocCode MDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsPAAllowed field.
        /// </summary>
        /// <value>The is PA allowed.</value>
        public virtual string ShowPrayer
        {
            get;
            set;
        }


        public virtual string CorrespondingFormNo
        {
            get;
            set;
        }

        public virtual string ShowGround
        {
            get;
            set;
        }
        public virtual string MainBodyText
        {
            get;
            set;
        }

        public virtual MNOACode MNOACode
        {
            get;
            set;
        }

        public virtual MCourtType MCourtType
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
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
            MVSAConfigDetail toCompareWith = obj as MVSAConfigDetail;
            return toCompareWith == null ? false : ((this.VSAConfigDetailId == toCompareWith.VSAConfigDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.VSAConfigDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}