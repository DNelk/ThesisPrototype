﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonBirds : Card
{
    public override void Execute()
    {
       BattleDelegateHandler.EnemyEffect  += () => BattleManager.Instance.CurrentEnemy.AtkDebuff = 2;
    }
}
