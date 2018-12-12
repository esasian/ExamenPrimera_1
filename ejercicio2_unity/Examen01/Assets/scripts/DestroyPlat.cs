using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlat : MonoBehaviour {


    public GameObject plataforma;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("colision");
        plataforma.SetActive(false);
    }
}
