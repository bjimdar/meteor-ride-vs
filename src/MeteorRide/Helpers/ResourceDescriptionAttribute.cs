﻿using System;
using System.ComponentModel;

namespace Vectria.MeteorRide.Helpers
{
    [AttributeUsage(AttributeTargets.All)]
    internal sealed class ResourcesDescriptionAttribute : DescriptionAttribute
    {
        #region Fields
        private bool replaced;
        #endregion

        #region Constructors
        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="description">Attribute description.</param>
        public ResourcesDescriptionAttribute(string description)
            : base(description)
        {
        }
        #endregion

        #region Overriden Implementation
        /// <summary>
        /// Gets attribute description.
        /// </summary>
        public override string Description
        {
            get
            {
                if (!replaced)
                {
                    replaced = true;
                    DescriptionValue = ResourceHelper.GetString(base.Description);
                }

                return base.Description;
            }
        }
        #endregion
    }
}
