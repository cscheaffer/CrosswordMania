using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UI2DSprite))]
public class AnimatedFill : MonoBehaviour
{
    [Range(0f, 1f)]
    public float fillAmount = 1f;

    UI2DSprite mWidget;

    void Awake() { mWidget = GetComponent<UI2DSprite>(); }
    void Update() { mWidget.fillAmount = fillAmount; }
}