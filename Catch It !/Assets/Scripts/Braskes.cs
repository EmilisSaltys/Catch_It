using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Braskes : MonoBehaviour
{

    public GameObject braske;

    public Transform FirePoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Instantiate(braske, FirePoint.position, FirePoint.rotation);
    }

}
