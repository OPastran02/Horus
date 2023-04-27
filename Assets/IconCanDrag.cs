using UnityEngine;

public class IconCanDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 startPosition;
    private Vector3 offset;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnMouseDown()
    {
        isDragging = true;
        startPosition = transform.position;
        offset = startPosition - mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 currentMousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(currentMousePosition.x, currentMousePosition.y, 0);
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}