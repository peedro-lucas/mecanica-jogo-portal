using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGun : MonoBehaviour
{
    public GameObject portalPink, portalRed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GeraPortal(portalPink);
        }

        if (Input.GetMouseButtonDown(1))
        {
            GeraPortal(portalRed);
        }
    }

    private void GeraPortal(GameObject portal)
    {
        Destroy(GameObject.FindGameObjectWithTag(portal.tag));

        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, 25);
        if(hit.transform.gameObject.tag != "ObjetosTeleportaveis")
        {
            //Instantiate(portal, hit.point, Quaternion.LookRotation(hit.transform.forward));
            if (!hit.collider.gameObject.name.Equals("Terrain")) Instantiate(portal, hit.point, Quaternion.LookRotation(hit.transform.forward));
            else Instantiate(portal, hit.point, Quaternion.LookRotation(hit.transform.up));
        }

        else
        {
            print("oi");
        }
    }
}
