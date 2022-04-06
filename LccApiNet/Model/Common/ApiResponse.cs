#nullable enable
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
    /// Response of any of the api methods.
    /// </summary>
    public class ApiResponse {
        
        /// <summary>
        /// Whether execution was successful.
        /// </summary>
        [JsonProperty("result")]
        [JsonConverter(typeof(SmartEnumNameConverter<ExecutionResult, int>))]
        public ExecutionResult Result { get; set; } = default!;
        
        /// <summary>
        /// In case of error during execution
        /// specifies name of the error occurred.
        /// </summary>
        [JsonProperty("errorName")]
        [JsonConverter(typeof(SmartEnumNameConverter<MethodError, int>))]
        public MethodError? ErrorName { get; set; }//;
        
        /// <summary>
        /// In case of error during execution
        /// specifies message of the error occurred.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }//;
    }
}

#nullable restore
