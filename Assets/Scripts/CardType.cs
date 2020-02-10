using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardType : ScriptableObject
{
    public string typeName;
    public virtual void OnSetType(CardDisplay visuals)
    {
        /*visuals.healthBox.gameObject.SetActive(false);
        visuals.attackBox.gameObject.SetActive(false); 
        visuals.background.gameObject.SetActive(false);
        visuals.desBox.gameObject.SetActive(false);
        visuals.manaBox.gameObject.SetActive(false);
        visuals.icon.gameObject.SetActive(false);

        visuals.backCard.gameObject.SetActive(true);*/
    }
}
