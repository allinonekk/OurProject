#region Header

/*****************************************************************************************************
* Description : This file represents a standard InterfaceCriminal entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			        Author			        Description
*-----------------------------------------------------------------------------------------------------
* 28/06/2011                CJ             	 	Created
*****************************************************************************************************/
// <summary>
// File: InterfaceCriminalEntity.cs
// Description: Represents a standard InterfaceCriminal entity.
// </summary>
// <copyright file= "InterfaceCriminalEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'BackEndSpecific.InterfaceCriminalEntity'</summary>
    public partial class InterfaceCriminalEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="InterfaceCriminalEntity"/> class.</summary>
        public InterfaceCriminalEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseName field. </summary>
        public String CaseName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseNo field. </summary>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InterfaceCriminalId field. </summary>
        public String InterfaceCriminalId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StatusInd field. </summary>
        public InterfaceCriminalStatus StatusInd
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
            InterfaceCriminalEntity toCompareWith = obj as InterfaceCriminalEntity;
            return toCompareWith == null ? false : ((this.InterfaceCriminalId == toCompareWith.InterfaceCriminalId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.InterfaceCriminalId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}