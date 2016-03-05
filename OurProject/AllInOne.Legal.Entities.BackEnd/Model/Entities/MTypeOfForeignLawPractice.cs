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

    /// <summary>Class which represents the entity 'Master.MTypeOfForeignLawPractice'</summary>
    public partial class MTypeOfForeignLawPractice : IMaster
    {
        #region Fields

        private System.String _description;
        private System.Collections.Generic.ICollection<ForeignLawPracticeReg> _foreignLawPracticeRegs;
        private System.Collections.Generic.ICollection<ForeignLPSolicitorReg> _foreignLPSolicitorRegs;
        private System.String _foreignLPTypeCode;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MTypeOfForeignLawPractice"/> class.</summary>
        public MTypeOfForeignLawPractice()
            : base()
        {
            _foreignLawPracticeRegs = new System.Collections.Generic.HashSet<ForeignLawPracticeReg>();
            _foreignLPSolicitorRegs = new System.Collections.Generic.HashSet<ForeignLPSolicitorReg>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ForeignLawPracticeReg.MTypeOfForeignLawPractice - Master.MTypeOfForeignLawPractice.ForeignLawPracticeRegs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ForeignLawPracticeReg> ForeignLawPracticeRegs
        {
            get { return _foreignLawPracticeRegs; }
            set { _foreignLawPracticeRegs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ForeignLPSolicitorReg.MTypeOfForeignLawPractice - Master.MTypeOfForeignLawPractice.ForeignLPSolicitorRegs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ForeignLPSolicitorReg> ForeignLPSolicitorRegs
        {
            get { return _foreignLPSolicitorRegs; }
            set { _foreignLPSolicitorRegs = value; }
        }

        /// <summary>Gets or sets the ForeignLPTypeCode field. </summary>
        public virtual System.String ForeignLPTypeCode
        {
            get { return _foreignLPTypeCode; }
            set { _foreignLPTypeCode = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
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
            MTypeOfForeignLawPractice toCompareWith = obj as MTypeOfForeignLawPractice;
            return toCompareWith == null ? false : ((this.ForeignLPTypeCode == toCompareWith.ForeignLPTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignLPTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}