﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect4000 : EventEffectKind
    {
        private int type;

        public override void ApplyEffectKind(Person person, Event e)
        {
            person.PictureIndex = type;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.type = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}
