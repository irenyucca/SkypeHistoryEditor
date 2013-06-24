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
    
    public partial class Participant
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public Nullable<long> convo_id { get; set; }
        public string identity { get; set; }
        public Nullable<long> rank { get; set; }
        public Nullable<long> requested_rank { get; set; }
        public Nullable<long> text_status { get; set; }
        public Nullable<long> voice_status { get; set; }
        public Nullable<long> video_status { get; set; }
        public string live_identity { get; set; }
        public string live_price_for_me { get; set; }
        public string live_fwd_identities { get; set; }
        public Nullable<long> live_start_timestamp { get; set; }
        public Nullable<long> sound_level { get; set; }
        public string debuginfo { get; set; }
        public Nullable<long> next_redial_time { get; set; }
        public Nullable<long> nrof_redials_left { get; set; }
        public string last_voice_error { get; set; }
        public string quality_problems { get; set; }
        public Nullable<long> live_type { get; set; }
        public string live_country { get; set; }
        public string transferred_by { get; set; }
        public string transferred_to { get; set; }
        public string adder { get; set; }
        public Nullable<long> last_leavereason { get; set; }
        public Nullable<long> is_premium_video_sponsor { get; set; }
        public Nullable<long> is_multiparty_video_capable { get; set; }
        public string live_identity_to_use { get; set; }
        public Nullable<long> livesession_recovery_in_progress { get; set; }
        public Nullable<long> extprop_default_identity { get; set; }
    }
}
