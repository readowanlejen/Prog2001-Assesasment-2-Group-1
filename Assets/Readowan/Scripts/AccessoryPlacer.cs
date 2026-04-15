using UnityEngine;

public class AccessoryPlacer : MonoBehaviour
{
    [Header("Snap Settings")]
    public Vector3 snapPosition;
    public float snapDistance = 1.5f;

    [Header("Status")]
    public bool isPlaced = false;

    private Vector3 originalPosition;
    private bool isDragging = false;
    private float zDepth;
    private Camera mainCam;

    void Start()
    {
        originalPosition = transform.position;
        mainCam = Camera.main;
        zDepth = mainCam.WorldToScreenPoint(
            transform.position).z;
    }

    void OnMouseDown()
    {
        if (isPlaced)
        {
            ReturnToTray();
        }
        else
        {
            isDragging = true;
            zDepth = mainCam.WorldToScreenPoint(
                transform.position).z;
        }
    }

    void OnMouseDrag()
    {
        if (!isDragging) return;

        Vector3 screenPos = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            zDepth);

        transform.position =
            mainCam.ScreenToWorldPoint(screenPos);
    }

    void OnMouseUp()
    {
        if (!isDragging) return;
        isDragging = false;

        float dist = Vector3.Distance(
            transform.position,
            snapPosition);

        if (dist < snapDistance)
        {
            PlaceOnSnowman();
        }
        else
        {
            ReturnToTray();
        }
    }

    void PlaceOnSnowman()
    {
        transform.position = snapPosition;
        isPlaced = true;
        Debug.Log(gameObject.name +
            " placed on snowman!");
    }

    public void ReturnToTray()
    {
        transform.position = originalPosition;
        isPlaced = false;
        Debug.Log(gameObject.name +
            " returned to tray!");
    }

    public void ResetAccessory()
    {
        ReturnToTray();
    }
}