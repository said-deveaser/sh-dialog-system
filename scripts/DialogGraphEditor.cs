using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;

namespace SHDialogSystem
{
    [CustomNodeGraphEditor(typeof(DialogGraph))]
    public class DialogGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type) {
            if (typeof(SHBaseNode).IsAssignableFrom(type)) {
                return base.GetNodeMenuName(type);
            } else return null;
        }
    }
}