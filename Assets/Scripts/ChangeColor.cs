using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private MeshRenderer malha;
    private Color corPrimaria;
    void Start()
    {
        malha = GetComponent<MeshRenderer>();
        corPrimaria = malha.material.color;
    }

    public void Selected()
    {
        malha.material.color = Color.magenta;
    }

    public void NotSelected()
    {
        malha.material.color = corPrimaria;
    }

}
