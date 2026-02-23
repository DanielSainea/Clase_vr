using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    public GameObject PickedObject;
    public Transform ZonadeInteraccion;


    void Update()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<Agarrarobjeto>().esAgarrable == true && PickedObject == null)
        {
            if(Input.GetButtonDown("Firel"))
            {
                PickedObject = ObjectToPickUp;
              PickedObject.GetComponent<Agarrarobjeto>().esAgarrable = false;
                PickedObject.transform.SetParent(ZonadeInteraccion);
                PickedObject.transform.position = ZonadeInteraccion.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        } else if(PickedObject != null)
        {
            if (Input.GetButton("Firel"))
            
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<Agarrarobjeto>().esAgarrable = true;
                PickedObject.transform.SetParent(ZonadeInteraccion);
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject = null;
            }
        }
    }
}
