﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind1412 : ConditionKind
    {
        public override bool CheckConditionKind(Troop troop)
        {
            return (troop.Leader.Braveness < troop.Leader.Calmness);
        }
    }
}

