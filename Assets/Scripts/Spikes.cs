using UnityEngine;

public class Spikes : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.GetComponent<PlayerMoveScript>())
        {

            collision.collider.GetComponent<PlayerMoveScript>().Die();

        }

    }

}