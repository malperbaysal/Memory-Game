using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class Card : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
   
    [Button]
    public void Selected()
    {
        transform.DORotate(Vector3.zero, 0.25f);
    }
    [Button]
    public void Deselect()
    {
        transform.DORotate(new Vector3(0, -180, 0), 0.25f);
    }
    public void Matched()
    {
        StartCoroutine(MatchedDelay());
    }
    IEnumerator MatchedDelay()
    {
        yield return new WaitForSeconds(0.5f);
        transform.DOScale(Vector3.zero, 0.25f);
    }
}
