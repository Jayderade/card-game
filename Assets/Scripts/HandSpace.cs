using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSpace : MonoBehaviour
{ 
    
    public int random;
    public bool deckSelect;
     public static bool overPlay = false;
    public GameObject[] cardSlot;
    Transform emptySpace;
    List<Transform> allSpaces = new List<Transform>();

    

    // Start is called before the first frame update
    void Start()
    {
        
        random = Random.Range(0, 1);
        cardSlot = GameObject.FindGameObjectsWithTag("Hand Space");
        foreach(GameObject cs in cardSlot)
        {
            emptySpace = cs.GetComponent<Transform>();
            allSpaces.Add(emptySpace);
        }

    }
    public void OnDeckClick()
    {
        
        
            
            overPlay = true;
            foreach (Transform es in allSpaces)
            {
            Debug.Log("w");


            #region Place In Hand
            DeckHighlight.highlightedCard.transform.SetParent(es);
                    // CHANGE CARD TAG HERE
                    allSpaces.Remove(es);

                    DeckHighlight.highlightedCard.transform.position = es.position;
                    DeckHighlight.highlightedCard.transform.rotation = es.rotation;

                    DeckHighlight.highlightedCard = null;
                    overPlay = false;
                    #endregion
                    #region Swap To Card

                    #endregion
                
            }

        
    }
    // Update is called once per frame
    void Update()
    {
        deckSelect = DeckHighlight.selected;

        if(deckSelect)
        {
            overPlay = true;
            foreach(Transform es in allSpaces)
            {
                if(Input.GetMouseButtonUp(0) && overPlay)
                {
                    
                    #region Place In Hand
                    DeckHighlight.highlightedCard.transform.SetParent(es);
                    // CHANGE CARD TAG HERE
                    allSpaces.Remove(es);

                    DeckHighlight.highlightedCard.transform.position = es.position;
                    DeckHighlight.highlightedCard.transform.rotation = es.rotation;

                    DeckHighlight.highlightedCard = null;
                    overPlay = false;
                    #endregion
                    #region Swap To Card
                    
                    #endregion
                }
            }
            
        }
    }
}
