using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite btnSlide;
    public UnityEvent btnClick;
    void Awake()
    {
        if (btnClick == null) { btnClick = new UnityEvent();}
    }

    // Update is called once per frame
    void OnMouseSlides()
    {
        GetComponent<SpriteRenderer>().sprite = btnSlide;
    }
}
