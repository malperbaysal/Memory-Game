using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class LevelMaker : MonoBehaviour
{
    [SerializeField] private List<Sprite> spriteList;
    [SerializeField] private Card cardPrefab;
    
    [Button]
    public void MakeLevel()
    {
        List<GameObject> cards = new List<GameObject>();
        foreach (var sprite in spriteList)
        {
            Card card1 = Instantiate(cardPrefab, transform);
            card1.spriteRenderer.sprite = sprite;
            cards.Add(card1.gameObject);
            Card card2 = Instantiate(cardPrefab, transform);
            card2.spriteRenderer.sprite = sprite;
            cards.Add(card2.gameObject);
        }
        List<GameObject> cardsToShuffle = new List<GameObject>(cards);
        for (int i = 0; i < cardsToShuffle.Count; i++)
        {
            cardsToShuffle[Random.Range(0, cardsToShuffle.Count)].transform.position = new Vector3(i % 4, i / 4f, 0);
        }
    }
}
