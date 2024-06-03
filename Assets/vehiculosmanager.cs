using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiculosmanager : MonoBehaviour
{
    public Vehiculo vehiculosScript;
    // Start is called before the first frame update
    void Start()
    {
        int cantRuedasVehiculo = vehiculosScript.cantRuedas;
        Debug.Log("cant ruedas:" + vehiculosScript.cantRuedas);
        if (cantRuedasVehiculo < 6)
        {
            vehiculosScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
