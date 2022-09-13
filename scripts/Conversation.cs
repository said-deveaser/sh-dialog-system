using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using XNode;

namespace SHDialogSystem
{
    public class Conversation : SHBaseNode
    {
        public string conversationSlug = "conversation";
        public string conversationName = "Беседа";
        public bool isDefault = false;

        [Output] public string next;

        public Conversation() : base(NodeType.Conversation)
        {
        }

        public override object GetValue(NodePort port)
        {
            if (port.fieldName == "next")
            {
                return conversationSlug;
            }

            return null;
        }
        
        
    }
}