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
    /// 
    /// </summary>
    public class ActionChangedParameters {
        
        /// <summary>
        /// Is champion action completed or the champion is only hovered.
        /// </summary>
        [JsonProperty("completed")]
        public bool Completed { get; set; } = default!;
        
        /// <summary>
        /// ID of the picked or banned champion.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; } = default!;
        
        /// <summary>
        /// Position of the actor in ally or enemy team. [0..4]
        /// </summary>
        [JsonProperty("actorPosition")]
        public int ActorPosition { get; set; } = default!;
        
        public ActionChangedParameters(bool completed, int championId, int actorPosition) {
            this.Completed = completed;
            this.ChampionId = championId;
            this.ActorPosition = actorPosition;
        }
    }
}

#nullable restore
