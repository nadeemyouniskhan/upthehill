using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuelfill : MonoBehaviour
{
    public CarController carController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        carController.fuel = 1;
        Destroy(gameObject);
    }

}
