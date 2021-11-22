using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Fungus;

public class SelectableObject : MonoBehaviour
{
    public bool clicked;
    public bool hovered;

    [Space(10)]

    public UnityEvent<bool> onClick;
    public UnityEvent onHover;
    public UnityEvent onStopHover;

    public virtual void DoClick()
    {
        clicked = !clicked;

        onClick?.Invoke(clicked);
    }

    public virtual void DoHover(bool isHovered)
    {
        if (isHovered)
            onHover?.Invoke();
        else
            onStopHover?.Invoke();

        hovered = isHovered;
    }

    public virtual void Update()
    {

    }
}