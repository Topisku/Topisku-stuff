using UnityEngine;
using UnityEngine.Events;

public class VictoryTrigger : MonoBehaviour
{

    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;


    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
        Time.timeScale = 0f;
        Debug.Log("Victory");
    }
}
