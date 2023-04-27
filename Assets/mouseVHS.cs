using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseVHS : MonoBehaviour
{
void OnMouseEnter()
{
    GetComponent<Renderer>().material.color = Color.red;
}

void OnMouseExit()
{
    GetComponent<Renderer>().material.color = Color.white;
}
}
