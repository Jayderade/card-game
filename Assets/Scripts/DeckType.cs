using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Deck", menuName = "Card/Type/Deck")]
public class DeckTypeType : CardType
{
    public override void OnSetType(CardDisplay visuals)
    {
        base.OnSetType(visuals);
        visuals.healthBox.gameObject.SetActive(false);
        visuals.attackBox.gameObject.SetActive(false);
        visuals.manaBox.gameObject.SetActive(false);
        visuals.icon.gameObject.SetActive(false);
        visuals.nameBox.gameObject.SetActive(false);
        visuals.desBox.gameObject.SetActive(false);
    }
}
