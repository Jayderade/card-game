using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    [Header("Text Elements")]
    public Text nameText;
    public Text descriptionText, costText, attackText, healthText;
    [Header("Image Elements")]
    public Image backCard;
    public Image nameBox;
    public Image desBox;
    public Image healthBox;
    public Image attackBox;
    public Image manaBox;
    public Image icon;
    public Image background;
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        costText.text = card.cost.ToString();
        healthText.text = card.health.ToString();
        attackText.text = card.attack.ToString();
        icon.sprite = card.icon;
        background.sprite = card.background;
        card.cardType.OnSetType(this);
    }

}
