using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    [SerializeField] SceneController controller;

    private int _id;

    public int Id
    {
        get { return _id; }
    }
    
    public void SetCard(int id, Sprite img)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = img;
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReval)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }
    
    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}
