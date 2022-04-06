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
    /// Describes the event related to the device
    /// </summary>
    public class DeviceEvent {
        
        /// <summary>
        /// Type of the event
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(SmartEnumNameConverter<DeviceEventType, int>))]
        public DeviceEventType Type { get; set; } = default!;
        
        /// <summary>
        /// If the device was added, stores id of the new device;
        /// If the device was changed, stores id of the device whose changes invoked this event;
        /// If the device was removed, stores id of the removed device
        /// </summary>
        [JsonProperty("deviceId")]
        public int DeviceId { get; set; } = default!;
        
        /// <summary>
        /// If the device was changed, stores names of the properties 
        /// that has been changed and properties' new values; otherwise null
        /// </summary>
        [JsonProperty("changes")]
        public Dictionary<string, object>? Changes { get; set; }//;
    }
}

#nullable restore
