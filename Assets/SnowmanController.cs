using UnityEngine;

public class SnowmanController : MonoBehaviour
{
    private Vector3 originalScale;
    private Quaternion originalRotation;

    void Start()
    {
        originalScale = transform.localScale;
        originalRotation = transform.rotation;
    }

    public void Grow()
    {
        transform.localScale *= 1.2f;
    }

    public void Shrink()
    {
        transform.localScale *= 0.8f;
    }

    public void SpinLeft()
    {
        transform.Rotate(0, -30, 0);
    }

    public void SpinRight()
    {
        transform.Rotate(0, 30, 0);
    }

    public void Reset()
    {
        transform.localScale = originalScale;
        transform.rotation = originalRotation;
    }
}