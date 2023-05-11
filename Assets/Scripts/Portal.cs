using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    void Update()
    {
        if(gameObject.tag == "portal1")
        {
            TeleportarObjeto(GameObject.FindGameObjectWithTag("portal2"));
        }
        else
        {
            TeleportarObjeto(GameObject.FindGameObjectWithTag("portal1"));
        }
    }

    void TeleportarObjeto(GameObject portalSaida)
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, 1f))
        {
            GameObject obj = hit.transform.gameObject;
            if(obj.tag == "ObjetosTeleportaveis")
            {
                obj.transform.position = portalSaida.transform.position;
                obj.GetComponent<Rigidbody>().AddForce(portalSaida.transform.forward * 2,ForceMode.Impulse);
            }
            else
            {
                print("local nao encontrado!");
            }
        }
    }
}
