//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voicemail
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public Nullable<long> type { get; set; }
        public string partner_handle { get; set; }
        public string partner_dispname { get; set; }
        public Nullable<long> status { get; set; }
        public Nullable<long> failurereason { get; set; }
        public string subject { get; set; }
        public Nullable<long> timestamp { get; set; }
        public Nullable<long> duration { get; set; }
        public Nullable<long> allowed_duration { get; set; }
        public Nullable<long> playback_progress { get; set; }
        public Nullable<long> convo_id { get; set; }
        public byte[] chatmsg_guid { get; set; }
        public Nullable<long> notification_id { get; set; }
        public Nullable<long> flags { get; set; }
        public Nullable<long> size { get; set; }
        public string path { get; set; }
        public Nullable<long> failures { get; set; }
        public Nullable<long> vflags { get; set; }
        public string xmsg { get; set; }
        public Nullable<long> extprop_hide_from_history { get; set; }
    }
}
