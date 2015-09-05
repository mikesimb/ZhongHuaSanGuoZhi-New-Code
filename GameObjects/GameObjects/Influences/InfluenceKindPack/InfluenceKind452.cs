﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind452 : InfluenceKind
    {
        private int increment = 0;

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.IncrementOfInvestigateRadius = this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.IncrementOfInvestigateRadius = 0;
        }
    }
}
