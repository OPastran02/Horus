using UnityEngine;
using UnityEngine.EventSystems;

public class CanDeselectIcons : MonoBehaviour
{

    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnMouseDown()
    {
        Debug.Log("AAHAA");
    }

}