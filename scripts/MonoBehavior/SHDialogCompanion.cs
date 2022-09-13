using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SHDialogSystem
{
    public class SHDialogCompanion : MonoBehaviour
    {
        public DialogStartEvent onStart;
        public DialogGraph dialogGraph;

        public void StartDialog()
        {
            onStart?.Invoke();
            var conversation = GetConversationDefault();
        }

        public void StartDialog(string conversationSlug)
        {
            onStart?.Invoke();
        }
        public List<Conversation> GetConversations()
        {
            return dialogGraph.GetConversations();
        }

        public Conversation GetConversationDefault()
        {
            return dialogGraph.GetConversationDefault();
        }
        
        public Conversation GetConversation(int index)
        {
            return dialogGraph.GetConversation(index);
        }

        public Conversation GetConversation(string conversationSlug)
        {
            return dialogGraph.GetConversation(conversationSlug);
        }
    }

    [Serializable]
    public class DialogStartEvent : UnityEvent
    {
    }
}