#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ardalis.SmartEnum;


namespace LarcApiNet.Model {
    
    
    /// <summary>
    /// Identifies exactly what was happened in the champ select phase.
    /// </summary>
    public class PickEventType : SmartEnum<PickEventType> {
        
        /// <summary>
        /// 
        /// </summary>
        public static PickEventType SkinChanged = new PickEventType("SkinChanged", 1);
        
        /// <summary>
        /// 
        /// </summary>
        public static PickEventType ActionChanged = new PickEventType("ActionChanged", 2);
        
        /// <summary>
        /// 
        /// </summary>
        public static PickEventType ActionRequested = new PickEventType("ActionRequested", 3);
        
        /// <summary>
        /// 
        /// </summary>
        public static PickEventType ChampSelectEnded = new PickEventType("ChampSelectEnded", 4);
        
        /// <summary>
        /// 
        /// </summary>
        public static PickEventType ChampSelectStarted = new PickEventType("ChampSelectStarted", 5);
        
        public PickEventType(string name, int value) : 
                base(name, value) {
        }
    }
}

#nullable restore
