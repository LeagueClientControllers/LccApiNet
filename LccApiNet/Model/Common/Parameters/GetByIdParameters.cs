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
    /// 
    /// </summary>
    public class GetByIdParameters {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;
        
        public GetByIdParameters(int id) {
            this.Id = id;
        }
    }
}
