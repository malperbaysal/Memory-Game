using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                if(hit.collider.TryGetComponent(out Card card))
                {
                    CardManager.Instance.CardSelected(card);
                }
                else
                {
                    CardManager.Instance.CardDeselected();
                }
            }
        }
    }
}
