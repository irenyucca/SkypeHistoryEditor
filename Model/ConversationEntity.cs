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
    
    public partial class ConversationEntity
    {
        public ConversationEntity()
        {
            this.Message = new HashSet<MessageEntity>();
        }
    
        public long id { get; set; }
        public string identity { get; set; }
        public Nullable<long> type { get; set; }
        public string displayname { get; set; }
        public Nullable<long> local_livestatus { get; set; }
        public Nullable<long> inbox_timestamp { get; set; }
        public Nullable<long> inbox_message_id { get; set; }
        public Nullable<long> unconsumed_suppressed_messages { get; set; }
        public Nullable<long> unconsumed_normal_messages { get; set; }
        public Nullable<long> unconsumed_elevated_messages { get; set; }
        public Nullable<long> unconsumed_messages_voice { get; set; }
        public Nullable<long> active_vm_id { get; set; }
        public Nullable<long> context_horizon { get; set; }
        public Nullable<long> consumption_horizon { get; set; }
        public Nullable<long> last_activity_timestamp { get; set; }
        public Nullable<long> active_invoice_message { get; set; }
        public Nullable<long> spawned_from_convo_id { get; set; }
        public Nullable<long> pinned_order { get; set; }
        public string creator { get; set; }
        public Nullable<long> creation_timestamp { get; set; }
        public Nullable<long> my_status { get; set; }
        public string passwordhint { get; set; }
        public string meta_name { get; set; }
        public string meta_topic { get; set; }
        public string meta_guidelines { get; set; }
        public byte[] meta_picture { get; set; }
        public Nullable<long> premium_video_status { get; set; }
        public Nullable<long> premium_video_is_grace_period { get; set; }
        public string guid { get; set; }
        public string dialog_partner { get; set; }
        public string meta_description { get; set; }
        public string premium_video_sponsor_list { get; set; }
        public Nullable<long> chat_dbid { get; set; }
    
        public virtual ICollection<MessageEntity> Message { get; set; }
    }
}