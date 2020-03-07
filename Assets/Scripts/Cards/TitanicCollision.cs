﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanicCollision : Card
{
    public override void Execute()
    {
        base.Execute();
        PowerTotal = BattleManager.Instance.CurrentEnemy.CurrentAttack.TotalDamage * 2;
    }
}