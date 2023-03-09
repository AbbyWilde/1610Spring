using UnityEngine;
using UnityEngine.Events;


public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private coid OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
