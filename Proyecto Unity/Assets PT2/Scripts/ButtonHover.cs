using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public RectTransform Button;

   
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().SetBool("Hover", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().SetBool("Hover", false);
    }
}
