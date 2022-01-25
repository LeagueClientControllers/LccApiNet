﻿using Ardalis.SmartEnum;

namespace LccApiNet.Model.General
{
    /// <summary>
    /// Possible API method errors enumeration
    /// </summary>
    public class MethodError : SmartEnum<MethodError>
    {
        public MethodError(string name, int value) : base(name, value) { }


        /// <summary>
        /// Occurs when API key was not provided or was wrong
        /// </summary>
        public static readonly MethodError WrongApiKey = new MethodError("WrongApiKeyError", 1);

        /// <summary>
        /// Occurs when provided access tokens was invalid
        /// during the call of the method that requires access token to execute
        /// </summary>
        public static readonly MethodError WrongAccessToken = new MethodError("WrongAccessTokenError", 2);

        /// <summary>
        /// Occurs when access tokens was not provided
        /// during the call of the method that requires access token to execute
        /// </summary>
        public static readonly MethodError AccessTokenNotProvided = new MethodError("AccessTokenNotProvidedError", 3);

        /// <summary>
        /// Occurs when wrong email, nickname or password was used for authorization
        /// </summary>
        public static readonly MethodError WrongNicknameEmailOrPassword = new MethodError("WrongNicknameEmailOrPasswordError", 4);

        /// <summary>
        /// Occurs when API method that requires JSON parameters was provided
        /// with body that contains JSON syntax errors
        /// </summary>
        public static readonly MethodError JsonParsingError = new MethodError("JsonParsingError", 5);

        /// <summary>
        /// Occurs when API method that requires some parameters
        /// was not provided with them
        /// </summary>
        public static readonly MethodError MissingMethodParameters = new MethodError("MissingMethodParametersError", 5);

        /// <summary>
        /// Occurs when the API method parameter is invalid
        /// </summary>
        public static readonly MethodError InvalidMethodParameter = new MethodError("InvalidMethodParameterError", 6);

        /// <summary>
        /// Occurs when the API method not found on requested URL.
        /// </summary>
        public static readonly MethodError MethodNotFound = new MethodError("MethodNotFoundError", 7);
    }
}
