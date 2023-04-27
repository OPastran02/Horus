using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton

    private List<IconCanSelect> selectableIcons = new List<IconCanSelect>(); // Lista de iconos seleccionables
    private IconCanSelect currentSelectedIcon; // Icono actualmente seleccionado

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Este metodo permite agregar un nuevo objeto IconCanSelect a la lista de iconos seleccionables.
    public void RegisterSelectableIcon(IconCanSelect icon)
    {
        selectableIcons.Add(icon);
    }

    //Este metodo permite quitar un objeto IconCanSelect de la lista de iconos seleccionables.
    public void UnregisterSelectableIcon(IconCanSelect icon)
    {
        selectableIcons.Remove(icon);
    }

    //Este metodo selecciona un objeto IconCanSelect. Primero, 
    //si ya hay un objeto seleccionado, lo deselecciona. Luego, 
    //marca el nuevo objeto como seleccionado y deselecciona todos los demas.
    public void SelectIcon(IconCanSelect icon)
    {
        if (currentSelectedIcon != null && currentSelectedIcon != icon)
        {
            currentSelectedIcon.Deselect();
        }

        currentSelectedIcon = icon;

        foreach (IconCanSelect selectableIcon in selectableIcons)
        {
            if (selectableIcon != icon)
            {
                selectableIcon.Deselect();
            }
        }
    }

    public void DeselectAllIcons()
    {
        foreach (IconCanSelect selectableIcon in selectableIcons)
        {
            selectableIcon.Deselect();
        }
    }
}