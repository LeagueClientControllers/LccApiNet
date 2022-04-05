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
    /// Describes event that is related to the client controller command.
    /// </summary>
    public class CommandEvent {
        
        /// <summary>
        /// Type of the event.
        /// </summary>
        [JsonProperty("type")]
        public CommandEventType Type { get; set; } = default!;
        
        /// <summary>
        /// If command has been sent contains command details.
        /// </summary>
        [JsonProperty("command")]
        public Command? Command { get; set; }//;
        
        /// <summary>
        /// If command has been executed contains id of the command.
        /// </summary>
        [JsonProperty("commandId")]
        public int? CommandId { get; set; }//;
        
        /// <summary>
        /// If command has been executed contains result of the command.
        /// </summary>
        [JsonProperty("commandResult")]
        public CommandResult? CommandResult { get; set; }//;
    }
}
