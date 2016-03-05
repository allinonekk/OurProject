#region Header

/*****************************************************************************************************
* Description : This file represents a standard MCaseType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MCaseTypeEntity.cs
// Description: Represents a standard MCaseType entity.
// </summary>
// <copyright file= "MCaseTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MCaseType.
    /// </summary>
    [Serializable]
    public class MCaseTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MCaseType"/> class.
        /// </summary>
        public MCaseTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CaseFileLocation field.
        /// </summary>
        /// <value>The case file location.</value>
        public String CaseFileLocation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseTypeCode field.
        /// </summary>
        /// <value>The case type code.</value>
        public String CaseTypeCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseTypeGroupCode field.
        /// </summary>
        /// <value>The case type group code.</value>
        public String CaseTypeGroupCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PreROCInd field.
        /// </summary>
        /// <value>The pre ROC ind.</value>
        public String PreROCInd
        {
            get; set;
        }

        public String CaseLevelInd
        {
            get;
            set;
        }


        public string CaseTypeCodeDescription
        {
            get
            {
                return string.Format("{0} - {1}", CaseTypeCode, Description);
            }
        }

        public YesNo? LABAccessInd
        {
            get;
            set;
        } 

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MCaseTypeEntity toCompareWith = obj as MCaseTypeEntity;
            return toCompareWith == null ? false : ((this.CaseTypeCode == toCompareWith.CaseTypeCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}