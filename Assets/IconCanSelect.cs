using System.Collections.Generic;
using UnityEngine;

public class IconCanSelect : MonoBehaviour
{
    public Color highlightColor; // el color azul 

    private Color iconOriginalColor; //el color del icono original
    private Color squareOriginalColor; //el color del cuadro original
    private BoxCollider2D boxCollider;

    public bool highlighted;

    private SpriteRenderer icon;
    private SpriteRenderer square;

    private static List<IconCanSelect> selectedIcons = new List<IconCanSelect>();

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        Transform selectionIcon = transform.Find("Icon");
        icon = selectionIcon.GetComponent<SpriteRenderer>();
        iconOriginalColor = icon.color;
        Transform selectionSquare = transform.Find("Square");
        square = selectionSquare.GetComponent<SpriteRenderer>();
        squareOriginalColor = square.color;
        highlighted = false;
    }

    private void OnMouseDown()
    {
        if(!highlighted){
            // busca todos los iconos seleccionados y los deselecciona
            foreach (IconCanSelect selectedIcon in selectedIcons) {
                selectedIcon.Deselect();
            }
            //limpia la lista de iconos seleccionados
            selectedIcons.Clear();
            
            icon.color = highlightColor;
            square.color = highlightColor;
            highlighted = true;

            // Agrega este icono a la lista de iconos seleccionados
            selectedIcons.Add(this);
        }
    }

    //deselecciona un icono especifico
    public void Deselect()
    {
        icon.color = iconOriginalColor;
        square.color = squareOriginalColor;
        highlighted = false;
    }

    
}