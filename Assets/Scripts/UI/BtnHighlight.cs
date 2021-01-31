using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnHighlight : MonoBehaviour
{
    public Text HightlightText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        HightlightText.color = Color.red;
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        HightlightText.color = Color.grey;
    }
}