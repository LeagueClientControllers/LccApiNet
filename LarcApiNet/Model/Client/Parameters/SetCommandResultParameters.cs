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


namespace LarcApiNet.Model {
    
    
    /// <summary>
    /// Parameters of the /client/setCommandResult method.
    /// </summary>
    public class SetCommandResultParameters {
        
        /// <summary>
        /// Id of the command to set result of.
        /// </summary>
        [JsonProperty("commandId")]
        public int CommandId { get; set; } = default!;
        
        /// <summary>
        /// Result of the command.
        /// </summary>
        [JsonProperty("result")]
        public CommandResult Result { get; set; } = default!;
        
        public SetCommandResultParameters(int commandId, CommandResult result) {
            this.CommandId = commandId;
            this.Result = result;
        }
    }
}

#nullable restore
