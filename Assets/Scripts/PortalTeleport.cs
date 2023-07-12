using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public GameObject portal1;
    public GameObject portal2;




    private void Update()
    {
        
    }

    private void OnTriggerEnte(Collider other, GameObject portalSaida)
    {
        if (other.CompareTag("ObejtosTeleportaveis"))
        {
            other.transform.position = portalSaida.transform.position;
        }
    }
}
