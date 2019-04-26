using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public AudioSource sound1;
    public AudioSource sound2;

    private void Start()
    {
        
    }
    public void OnPointerEnter(PointerEventData e)
    {
        if (sound1) sound1.Play();
    }
    public void OnPointerDown(PointerEventData e)
    {
        if (sound2) sound2.Play();
    }
}
