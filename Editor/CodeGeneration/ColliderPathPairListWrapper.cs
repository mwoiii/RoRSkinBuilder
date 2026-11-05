using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RoRSkinBuilder.CustomEditors;

namespace RoRSkinBuilder
{
    [Serializable]
    public struct ColliderPathPairListWrapper : IList<ColliderPathPair> {
        [PathReference]
        public List<ColliderPathPair> list;

        public readonly ColliderPathPair this[int index] { get => list[index]; set => list[index] = value; }
        public readonly int Count => list.Count;
        public readonly bool IsReadOnly => false;

        public readonly void Add(ColliderPathPair item) => list.Add(item);
        public readonly void Clear() => list.Clear();
        public readonly bool Contains(ColliderPathPair item) => list.Contains(item);
        public readonly void CopyTo(ColliderPathPair[] array, int arrayIndex) => list.CopyTo(array, arrayIndex);
        public readonly IEnumerator<ColliderPathPair> GetEnumerator() => list.GetEnumerator();
        public readonly int IndexOf(ColliderPathPair item) => list.IndexOf(item);
        public readonly void Insert(int index, ColliderPathPair item) => list.Insert(index, item);
        public readonly bool Remove(ColliderPathPair item) => !list.Remove(item);
        public readonly void RemoveAt(int index) => list.RemoveAt(index);
        readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
