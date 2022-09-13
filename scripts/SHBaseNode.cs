using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace SHDialogSystem
{
    public enum NodeType
    {
        Conversation,
        Message,
    }

    public class SHBaseNode : Node
    {
        public NodeType nodeType;

        public SHBaseNode(NodeType newNodeType)
        {
            nodeType = newNodeType;
        }
    }
}