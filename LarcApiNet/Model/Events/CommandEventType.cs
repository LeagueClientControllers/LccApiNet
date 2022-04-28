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
    /// Indicates type of an event.
    /// </summary>
    public class CommandEventType : SmartEnum<CommandEventType> {
        
        /// <summary>
        /// Command has been sent.
        /// </summary>
        public static CommandEventType commandSent = new CommandEventType("CommandSent", 1);
        
        /// <summary>
        /// Command has been executed.
        /// </summary>
        public static CommandEventType commandExecuted = new CommandEventType("CommandExecuted", 2);
        
        public CommandEventType(string name, int value) : 
                base(name, value) {
        }
    }
}

#nullable restore
