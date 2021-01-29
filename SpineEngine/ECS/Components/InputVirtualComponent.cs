﻿namespace SpineEngine.ECS.Components
{
    using System.Collections.Generic;

    using LocomotorECS;

    using SpineEngine.ECS.EntitySystems.VirtualInput;

    /// <summary>
    ///     Input component that is filled by InputVirtualUpdateSystem for mapping real inputs to virtual inputs.
    /// </summary>
    public class InputVirtualComponent : Component
    {
        public List<VirtualInput> InputConfiguration { get; } = new List<VirtualInput>();
    }
}