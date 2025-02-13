// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

namespace Nethermind.Trie.Pruning
{
    // ReSharper disable once InconsistentNaming
    public static class ITrieStoreExtensions
    {
        public static IReadOnlyTrieStore AsReadOnly(this ITrieStore trieStore, INodeStorage? readOnlyStore = null) =>
            trieStore.AsReadOnly(readOnlyStore);
    }
}
