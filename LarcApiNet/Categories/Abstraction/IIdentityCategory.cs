#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LarcApiNet.Exceptions;
using LarcApiNet.Model;
using NetLibraryGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;


namespace LarcApiNet.Categories.Abstraction {
    
    
    /// <summary>
    /// Contains methods that are used to get user information or related to the authentication.
    /// </summary>
    public interface IIdentityCategory {
        
        /// <summary>
        /// Authorizes device in the system,
        /// binds it to the user and returns token.
        /// </summary>
        /// <param name="login">User's email or username</param>
        /// <param name="password">User's password</param>
        /// <param name="deviceName">Name of the device that will be authorized under the user</param>
        /// <param name="deviceType">Type of the device that will be authorized under the user</param>
        Task<string> LoginAsync(string login, string password, string deviceName, DeviceType deviceType, CancellationToken token = default);
        
        /// <summary>
        /// Gets full info of the user.
        /// </summary>
        Task<ProfileInfo> GetProfileInfoAsync(CancellationToken token = default);
        
        /// <summary>
        /// Returns a fresh token with reset expiration date.
        /// based on data from current token.
        /// </summary>
        Task<string> RefreshAccessTokenAsync(CancellationToken token = default);
    }
}

#nullable restore
