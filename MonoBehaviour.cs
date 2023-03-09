using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MonoBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    private void Start()
    {
       startEvent.Invoke(); 
    }
    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
