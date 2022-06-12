using BaseX;
using FrooxEngine;
using FrooxEngine.LogiX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLogix
{
    public static partial class LogixValue
    {
        public static IElementContent<T> CreateReference<T>(this Slot slot, T changeable) where T : class, IChangeable
        {
            var referenceNode = slot.AttachComponent<ReferenceNode<T>>();
            referenceNode.RefTarget.Target = changeable;

            return new LogixValue<T>(referenceNode, slot);
        }

        internal static LogixValue<T> Create<T>(IElementContent<T> element, Slot slot)
        {
            return new LogixValue<T>(element, slot);
        }
    }

    internal class LogixValue<T> : IElementContent<T>
    {
        internal readonly IElementContent<T> element;
        internal readonly Slot slot;

        public T Content => element.Content;
        public bool IsLocalElement => element.IsLocalElement;
        public bool IsPersistent => element.IsPersistent;
        public bool IsRemoved => element.IsRemoved;
        public string Name => element.Name;
        public IWorldElement Parent => element.Parent;
        public RefID ReferenceID => element.ReferenceID;
        public World World => element.World;

        internal LogixValue(IElementContent<T> element, Slot slot)
        {
            this.element = element;
            this.slot = slot;
        }

        public void ChildChanged(IWorldElement child)
        {
            element.ChildChanged(child);
        }

        public string GetSyncMemberName(ISyncMember member)
        {
            return element.GetSyncMemberName(member);
        }

        public void Load(DataTreeNode node, LoadControl control)
        {
            element.Load(node, control);
        }

        public DataTreeNode Save(SaveControl control)
        {
            return element.Save(control);
        }
    }
}