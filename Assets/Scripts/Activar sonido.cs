using UnityEngine;

public class Activarsonido : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.instance.Play3D("Entrar", post.transform.position);

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.instance.Play3D("Salir",post1.transform.position);
        }
    }
}
}