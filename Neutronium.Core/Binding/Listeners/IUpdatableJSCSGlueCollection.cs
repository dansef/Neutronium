﻿using Neutronium.Core.Binding.GlueObject;
using System.Collections.Generic;

namespace Neutronium.Core.Binding.Listeners
{
    public interface IUpdatableJSCSGlueCollection : IEntityUpdater<IJSCSGlue>
    {
        ISet<IJSCSGlue> GetAllChildren();
    }
}
