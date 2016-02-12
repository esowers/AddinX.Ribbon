﻿using AddinX.Core.Contract.Ribbon;

namespace AddinX.Core.Contract
{
    public interface ICustomUi
    {
        IRibbonUi Ribbon { get; }

        ICustomUi AddNamespace(string letter, string privateNamespace);
    }
}