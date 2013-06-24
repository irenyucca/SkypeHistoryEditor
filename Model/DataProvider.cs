using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataProvider
    {
        Entities entities=new Entities();
        public MessageEntity[] getMessages(string name)
        {
            var messages = from mes in entities.Messages
                           where mes.Conversation.displayname.Equals(name)
                           select mes;
            return messages.ToArray();
        }

        public ConversationEntity[] getConversations()
        {
            var messages = from mes in entities.Conversations
                           select mes;
            return messages.ToArray();
        }
    }
}
