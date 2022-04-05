//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace LccApiNet.Model {
    
    
    /// <summary>
    /// Describes result of the command.
    /// </summary>
    public class CommandResult {
        
        /// <summary>
        /// Result of the command.
        /// </summary>
        [JsonProperty("result")]
        public ExecutionResult Result { get; set; } = default!;
        
        /// <summary>
        /// Type of the error if one occurred.
        /// </summary>
        [JsonProperty("error")]
        public CommandError? Error { get; set; }//;
        
        /// <summary>
        /// Error message if one occurred.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }//;
        
        /// <summary>
        /// Additional info or results of the command.
        /// </summary>
        [JsonProperty("info")]
        public object? Info { get; set; }//;
    }
}
