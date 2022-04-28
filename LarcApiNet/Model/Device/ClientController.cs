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
    /// Representation of the device that is owned by the user
    /// if it's computer that controls league of legends client
    /// </summary>
    public class ClientController {
        
        /// <summary>
        /// Identifier of the controller.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;
        
        /// <summary>
        /// Name of the controller.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        
        /// <summary>
        /// Whether the device is online
        /// </summary>
        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; } = default!;
        
        /// <summary>
        /// Gameflow phase of the league client that is controlled by this controller.
        /// </summary>
        [JsonProperty("gameflowPhase")]
        [JsonConverter(typeof(SmartEnumNameConverter<GameflowPhase, int>))]
        public GameflowPhase? GameflowPhase { get; set; }//;
        
        /// <summary>
        /// Time when ready check was initiated.
        /// </summary>
        [JsonProperty("readyCheckStarted")]
        public System.DateTime? ReadyCheckStarted { get; set; }//;
    }
}

#nullable restore
