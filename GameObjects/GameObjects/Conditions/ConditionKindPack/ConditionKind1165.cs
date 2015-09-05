﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind1165 : ConditionKind
    {
        private int number = 0;

        public override bool CheckConditionKind(Troop troop)
        {
            return (troop.AvoidSurroundedChance < this.number);
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.number = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}
