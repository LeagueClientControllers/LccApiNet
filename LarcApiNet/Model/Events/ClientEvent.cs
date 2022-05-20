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
using Newtonsoft.Json.Converters;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace LarcApiNet.Model {
    
    
    /// <summary>
    /// Describes the event related to the client.
    /// </summary>
    public class ClientEvent {
        
        /// <summary>
        /// Type of the event.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(SmartEnumNameConverter<ClientEventType, int>))]
        public ClientEventType Type { get; set; } = default!;
        
        /// <summary>
        /// Contains id of the client that reported about client changes.
        /// </summary>
        [JsonProperty("controllerId")]
        public int ControllerId { get; set; } = default!;
        
        /// <summary>
        /// Contains changes of the client values.
        /// </summary>
        [JsonProperty("changes")]
        public Dictionary<string, object>? Changes { get; set; }//;
    }
}

#nullable restore
