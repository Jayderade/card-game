using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CardHighlight : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler
{
    #region Variables
    public float height;
    //One single reference 
    public static GameObject highlightedCard;
    //mouse pos
    public Vector2 mouse;
    //card origin
    public Vector3 mouseOriginalSpot;
    public bool placed;
    public bool playSpace;

    public bool inZone;
    public bool hover;
    public Transform zone;
    #endregion

    #region Hover Events
    //HOVER
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.25f, 1.25f, 1);
    }
        public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    #endregion
    #region Click Events
    //CLICK
    public void OnPointerUp(PointerEventData eventData)
    {
        if (mouse.y >= 370 )
        {
            mouseOriginalSpot = mouse;
            playSpace = true;
        }
        
            highlightedCard.transform.position = mouseOriginalSpot;
            highlightedCard = null;

        if(inZone)
        {
            Instantiate(CardHighlight.highlightedCard.gameObject.GetComponent<CardDisplay>().card.prefab, zone);
            Destroy(CardHighlight.highlightedCard);
        }
        CardHighlight.highlightedCard = null;
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        highlightedCard = this.gameObject;
        

    }
    #endregion
    #region Unity Functions
    void Start()
    {
        placed = true;
        mouseOriginalSpot = this.transform.position;
    }    
    void Update()
    {
        if (highlightedCard != null && highlightedCard == this.gameObject)
        {
            mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            highlightedCard.transform.position = mouse;
        }
    }
    #endregion
}

