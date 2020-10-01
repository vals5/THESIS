using UnityEngine;

public class BoundsCalculator : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"{name} mide: {CalculateBoundsWidth()}");
    }

    public float CalculateBoundsWidth()
    {
        float width = 0;

        var renderers = GetComponentsInChildren<SpriteRenderer>();

        foreach (var spriteRenderer in renderers)
        {
            width += spriteRenderer.bounds.size.x;
        }

        return width;
    }
}