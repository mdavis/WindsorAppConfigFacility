﻿namespace AppConfigFacility.Azure
{
    using Microsoft.Azure;

    /// <summary>
    /// Extensions for the <see cref="AppConfigFacility"/>.
    /// </summary>
    public static class AppConfigFacilityExtensions
    {
        /// <summary>
        /// Indicates that we should get the settings using Azure's <see cref="CloudConfigurationManager"/>.
        /// </summary>
        /// <param name="facility">The facility.</param>
        public static AppConfigFacility FromAzure(this AppConfigFacility facility)
        {
            facility.AddSettingsProvider<AzureSettingsProvider>();

            return facility;
        }
    }
}
