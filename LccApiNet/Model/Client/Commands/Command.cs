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
    /// Describes command for client controller to execute.
    /// </summary>
    public class Command {
        
        /// <summary>
        /// Identifier of the command.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;
        
        /// <summary>
        /// Name of the command.
        /// </summary>
        [JsonProperty("name")]
        public CommandName Name { get; set; } = default!;
        
        /// <summary>
        /// Arguments of the command.
        /// </summary>
        [JsonProperty("args")]
        public SomeParametrizedCommandArgs? Args { get; set; }//;
    }
}
