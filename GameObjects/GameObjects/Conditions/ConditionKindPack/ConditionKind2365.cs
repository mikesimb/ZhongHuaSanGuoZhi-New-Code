﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2365 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Architecture a)
        {
            return a.FacilityCount < val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }

    }
}

