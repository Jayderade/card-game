using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/*
public class PlaceCard : MonoBehaviour
{
    public bool overPlay = false;
    public GameObject[] cardSlot;
    Transform emptySpace;
    List<Transform> allSpaces = new List<Transform>();

    

    // Start is called before the first frame update
    void Start()
    {
        cardSlot = GameObject.FindGameObjectsWithTag("Card Space");
        foreach(GameObject cs in cardSlot)
        {
            emptySpace = cs.GetComponent<Transform>();
            allSpaces.Add(emptySpace);
        }

    }

    // Update is called once per frame
    void Update()
    {
        PointerEventData mouse = new PointerEventData(EventSystem.current);
        mouse.position = Input.mousePosition;
        List<RaycastResult> mouseList = new List<RaycastResult>();
        EventSystem.current.RaycastAll(mouse, mouseList);
        
        foreach(RaycastResult result in mouseList)
        {
            if(result.gameObject.tag == "World Space")
            {
                overPlay = true;
            }
            else
            {
                overPlay = false;
            }
        }

        if(CardHighlight.highlightedCard)
        {
            foreach(Transform es in allSpaces)
            {
                if(Input.GetMouseButtonUp(0) && overPlay)
                {
                    CardHighlight.highlightedCard.transform.SetParent(es);
                    // CHANGE CARD TAG HERE
                    allSpaces.Remove(es);

                    CardHighlight.highlightedCard.transform.position = es.position;
                    CardHighlight.highlightedCard.transform.rotation = es.rotation;

                    CardHighlight.highlightedCard = null;
                }
            }
        }
    }
}
*/