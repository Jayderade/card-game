using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeckHighlight : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerDownHandler// IPointerUpHandler
{
    #region Variables
    public float height;
    //One single reference 
    public static GameObject highlightedCard;
    public GameObject card;
    //mouse pos
    public Vector2 mouse;
    //card origin
    public Vector3 mouseOriginalSpot;

    public bool placed;
    public static bool selected;    
    #endregion

    #region Hover Events
    //HOVER
    public void OnPointerEnter(PointerEventData eventData)
    {
        //transform.localScale = new Vector3(1.25f, 1.25f, 1);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //transform.localScale = new Vector3(1, 1, 1);
    }
    #endregion
    #region Click Events
    //CLICK
   /* public void OnPointerUp(PointerEventData eventData)
    {
        if (mouse.x >= 270 && mouse.y <= 126)
        {
            mouseOriginalSpot = mouse;            
        }
        
        highlightedCard.transform.position = mouseOriginalSpot;
        highlightedCard = null;
        if (selected)
        {
            this.gameObject.transform.localPosition = new Vector2(200, -130);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }*/
    public void OnPointerDown(PointerEventData eventData)
    {
        if(selected)
        {
           // this.gameObject.transform.localPosition = new Vector2(200, -130);
        }
        highlightedCard = this.gameObject;
        //transform.localScale = new Vector3(1.25f, 1.25f, 1);
        selected = true;

    }
    #endregion
    #region Unity Functions
    void Start()
    {
        selected = false;
        placed = true;
        mouseOriginalSpot = this.transform.position;
    }
    void Update()
    {
        if (highlightedCard != null && highlightedCard == this.gameObject)
        {
           // mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

           // highlightedCard.transform.position = mouse;
        }
    }
    #endregion
}