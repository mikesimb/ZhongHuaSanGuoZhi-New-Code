﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind921 : ConditionKind
    {
        public override bool CheckConditionKind(Person person)
        {
            return person.BelongedFactionWithPrincess == null || person.BelongedFactionWithPrincess.Leader.Spouse != person;
        }
    }
}

