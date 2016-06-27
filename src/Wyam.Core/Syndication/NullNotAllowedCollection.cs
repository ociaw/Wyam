//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

using System.Collections.ObjectModel;

namespace Wyam.Core.Syndication
{
    class NullNotAllowedCollection<TCollectionItem> : Collection<TCollectionItem>
        where TCollectionItem : class
    {
        public NullNotAllowedCollection()
            : base()
        {
        }

        protected override void InsertItem(int index, TCollectionItem item)
        {
            if (item == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("item");
            }
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, TCollectionItem item)
        {
            if (item == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("item");
            }
            base.SetItem(index, item);
        }
    }
}
