﻿using System;
using Serilog;

namespace Kmd.Logic.DigitalPost.Client.Sample
{
    internal class ConfigurationValidator
    {
        private readonly AppConfiguration configuration;

        public ConfigurationValidator(AppConfiguration configuration)
        {
            this.configuration = configuration ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.configuration.TokenProvider?.ClientId)
                || string.IsNullOrWhiteSpace(this.configuration.TokenProvider?.ClientSecret)
                || string.IsNullOrWhiteSpace(this.configuration.TokenProvider?.AuthorizationScope)
                || string.IsNullOrWhiteSpace(this.configuration.Title)
                || string.IsNullOrWhiteSpace(this.configuration.DocumentPath)
                || string.IsNullOrWhiteSpace(this.configuration.Identifier)
                || this.configuration.IdentifierType == null
                || this.configuration.DigitalPost == null
                || this.configuration.DigitalPost.SubscriptionId == Guid.Empty
                || this.configuration.DigitalPost.ConfigurationId == Guid.Empty)
            {
                Log.Error(
                    "Invalid configuration. Please provide proper information to `appsettings.json`. Current data is: {@Settings}",
                    this.configuration);

                return false;
            }

            return true;
        }
    }
}
