using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{
    public class IconClick : MonoBehaviour
    {
        public Color highlightColor;

        private Color originalColor;
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            originalColor = spriteRenderer.color;
        }

        private void OnMouseDown()
        {
            spriteRenderer.color = highlightColor;
        }

        private void OnMouseUp()
        {
            spriteRenderer.color = originalColor;
        }
    }
}
