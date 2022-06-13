using FrooxEngine;
using FrooxEngine.LogiX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLogix
{
    public static class LogixReferences
    {
        public static IElementContent<T> CreateReferenceNode<T>(this Slot slot, T changeable) where T : class, IChangeable
        {
            var referenceNode = slot.AttachComponent<ReferenceNode<T>>();
            referenceNode.RefTarget.Target = changeable;

            return referenceNode;
        }
    }
}