﻿using System;
using System.Collections.Generic;

namespace Memoria.Patcher
{
    public sealed class PatchCollection<T> where T : class, IPatch
    {
        private readonly Dictionary<string, T> _sourceToPatch = new Dictionary<string, T>();
        private readonly Dictionary<string, T> _targetToPatch = new Dictionary<string, T>();

        public Int32 Count => _sourceToPatch.Count;

        public PatchCollection(IEnumerable<T> patches)
        {
            foreach (T patch in patches)
            {
                _sourceToPatch.Add(patch.SourceName, patch);
                if (patch.TargetName != null)
                    _targetToPatch.Add(patch.TargetName, patch);
            }
        }

        public T FindBySource(String sourceName)
        {
            T value;
            return _sourceToPatch.TryGetValue(sourceName, out value)
                ? value
                : null;
        }

        public T FindByTarget(String targetName)
        {
            T value;
            return _targetToPatch.TryGetValue(targetName, out value)
                ? value
                : null;
        }
    }
}