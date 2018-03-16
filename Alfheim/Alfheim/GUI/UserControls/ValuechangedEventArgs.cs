using System;

namespace Alfheim.GUI.UserControls
{
    public class ValuechangedEventArgs : EventArgs
    {
        public string Property { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public long ID { get; set; }
    }
    
}
