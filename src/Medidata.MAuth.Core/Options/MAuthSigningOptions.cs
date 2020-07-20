﻿using System;

namespace Medidata.MAuth.Core
{
    /// <summary>
    /// Contains the options used by the <see cref="MAuthSigningHandler"/>.
    /// </summary>
    public class MAuthSigningOptions
    {
        /// <summary>
        /// Determines the RSA private key for the authentication requests. The value of this property can be set as a
        /// valid path to a readable key file as well.</summary>
        public string PrivateKey { get; set; }

        /// <summary>Determines the unique identifier used for the MAuth service authentication requests.</summary>
        public Guid ApplicationUuid { get; set; }

        /// <summary>
        /// Determines the time when signing requests instead of the current date and time.
        /// This property is for testing purposes only.
        /// </summary>
        internal DateTimeOffset? SignedTime { get; set; }

        /// <summary>
        /// Comma-separated protocol versions to sign requests, if not provided defaults to "v2".
        /// </summary>
        public string SignVersions { get; set; }
    }
}
