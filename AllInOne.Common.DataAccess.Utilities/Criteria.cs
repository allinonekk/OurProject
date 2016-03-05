#region Header

/*****************************************************************************************************
* Description : This file represents a generic Criteria implementation.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		      Swaroop             	 	Created
*   05/08/2010                Nithin                    Logger Implementation
*****************************************************************************************************/
// <summary>
// File: Criteria.cs
// Description: Class defined as a generic Criteria implementation.
// </summary>
// <copyright file= "Criteria.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.Utilities
{
    using System;

    /// <summary>
    /// Class defined as a generic Criteria implementation.
    /// </summary>
    public class Criteria
    {
        #region Fields

        /// <summary>
        /// Variable to store criteria's name.
        /// </summary>
        private string name;

        /// <summary>
        /// Variable to store criteria's value.
        /// </summary>
        private string value;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Criteria"/> class.
        /// </summary>
        /// <param name="property">Name of the data.</param>
        /// <param name="order">Value of the data.</param>
        public Criteria(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name cannot be null.");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException("Value cannot be null.");
            }

            this.name = name;
            this.value = value;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Should specify Entity's Property Name
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Should specify Sorting Order.
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        #endregion Properties
    }
}