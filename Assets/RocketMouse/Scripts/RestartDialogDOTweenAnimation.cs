using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RestartDialogDOTweenAnimation : MonoBehaviour
{
    RectTransform rt;

    void Awake()
    {
        rt = (RectTransform)transform;
    }

    void OnEnable()
    {
        rt.anchoredPosition = new Vector2(-1500, 0);
        rt.DOAnchorPos(Vector2.zero, 0.6f).SetEase(Ease.OutBack);
    }
}
