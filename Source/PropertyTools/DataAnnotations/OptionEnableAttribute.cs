// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OptionEnableAttribute.cs" company="PropertyTools">
//   Copyright (c) 2024 PropertyTools contributors
// </copyright>
// <summary>
//   Specifies the property name used to enable or disable an option, represented as a radio button, in an enumeration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PropertyTools.DataAnnotations
{
    using System;

    /// <summary>
    /// Specifies the property name used to enable or disable an option, represented as a radio button, in an enumeration.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class OptionEnableAttribute : Attribute
    {
        /// <summary>
        /// Gets the name of the property that determines whether the option is enabled or disabled.
        /// </summary>
        public string PropertyName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionEnableAttribute"/> class with the specified property name.
        /// </summary>
        /// <param name="propertyName">The name of the property that determines the enabled state of the option.</param>
        public OptionEnableAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}