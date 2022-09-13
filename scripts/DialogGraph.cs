using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

namespace SHDialogSystem
{
    [CreateAssetMenu(fileName = "DialogController", order = 51, menuName = "SHDialogSystem/DialogController")]
    public class DialogGraph : NodeGraph
    {
        public List<Conversation> conversations;

        public List<Conversation> GetConversations()
        {
            return conversations ??=
                (from node in nodes
                    select node as SHBaseNode
                    into baseNode
                    where baseNode.nodeType == NodeType.Conversation
                    select baseNode as Conversation).ToList();
        }

        public Conversation GetConversation(string conversationSlug)
        {
            return GetConversations().Find(conversation => conversation.conversationSlug == conversationSlug);
        }

        public Conversation GetConversation(int index)
        {
            return GetConversations()[index];
        }

        public Conversation GetConversationDefault()
        {
            return GetConversations().Find(conversation => conversation.isDefault);
        }
    }
}