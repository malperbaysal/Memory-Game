using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance { get; private set; }
    private Card _lastSelectedCard;
    private void Awake()
    {
        Instance = this;
    }
    public void CardSelected(Card selectedCard)
    {
        selectedCard.Selected();
        if(_lastSelectedCard==null)
        {
            _lastSelectedCard = selectedCard;
            return;
        }
        else
        {
            if (selectedCard.spriteRenderer.sprite == _lastSelectedCard.spriteRenderer.sprite)
            {
                selectedCard.Matched();
                _lastSelectedCard.Matched();
                _lastSelectedCard = selectedCard;
            }
            else
            {
                _lastSelectedCard.Deselect();
                _lastSelectedCard = selectedCard;
                selectedCard.Selected();
            }
        }
    }
    public void CardDeselected()
    {
        _lastSelectedCard.Deselect();
        _lastSelectedCard = null;
    }
}
