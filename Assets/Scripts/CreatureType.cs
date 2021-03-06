﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Creature", menuName = "Card/Type/Creature")]
public class CreatureType : CardType
{
    public override void OnSetType(CardDisplay visuals)
    {
        base.OnSetType(visuals);
        
        visuals.healthBox.gameObject.SetActive(true);
        visuals.attackBox.gameObject.SetActive(true);
    }
}
