using UnityEngine;

public class Agarrarobjeto : MonoBehaviour
{
    public bool esAgarrable = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ZonadeInteraccion")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
            AudioManager.instance.Play2D("1");
        }
                        

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "ZonadeInteraccion")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
            AudioManager.instance.Play2D("1");
        }
    }
}
