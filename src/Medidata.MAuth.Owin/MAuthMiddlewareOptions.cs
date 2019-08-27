﻿using System;
using Medidata.MAuth.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Owin;

namespace Medidata.MAuth.Owin
{
    /// <summary>
    /// Contains the options used by the <see cref="MAuthMiddleware"/>.
    /// </summary>
    public class MAuthMiddlewareOptions: MAuthOptionsBase
    {
        /// <summary>
        /// Determines if the middleware should swallow all exceptions and return an empty HTTP response with a
        /// status code Unauthorized (401) in case of any errors (including authentication and validation errors).
        /// The default is <see langword="true"/>.
        /// </summary>
        public bool HideExceptionsAndReturnUnauthorized { get; set; } = true;

        /// <summary>
        /// Determines a function which evaluates if a given request should bypass the MAuth authentication.
        /// </summary>
        /// <remarks>
        /// The function takes a <see cref="IOwinRequest"/> and should produce <see langword="true"/> as a result,
        /// if the given request satisfies the conditions to bypass the authentication; otherwise it should result
        /// <see langword="false"/> therefore an authentication attempt will occur. If no Bypass predicate provided in
        /// the options, every request will be authenticated by default.
        /// </remarks>
        public Func<IOwinRequest, bool> Bypass { get; set; } = (request) => false;

        /// <summary>
        /// Determines the <see cref="ILoggerFactory"/> instance passed by the application to create the logger.
        /// The default is <see langword="NullLoggerFactory.Instance"/>.
        /// </summary>
        public ILoggerFactory LoggerFactory { get; set; } = NullLoggerFactory.Instance;
    }
}
