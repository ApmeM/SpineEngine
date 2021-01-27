using System;
using LocomotorECS;
using LocomotorECS.Matching;

using SpineEngine.ECS.Components;

namespace SpineEngine.ECS.EntitySystems
{
    public class MaterialEffectUpdateSystem : EntityProcessingSystem
    {
        public MaterialEffectUpdateSystem()
            : base(new Matcher().All(typeof(MaterialComponent)))
        {
        }

        protected override void DoAction(Entity entity, TimeSpan gameTime)
        {
            base.DoAction(entity, gameTime);

            var material = entity.GetComponent<MaterialComponent>();
            material.Material.Update(gameTime);
        }
    }
}