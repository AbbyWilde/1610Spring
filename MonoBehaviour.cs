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

using UnityEngine;
using System.Collections;

public class Class : MonoBehaviour
{
    void OnBecameInvisible()
    {
        enabled = false;
    }
}

using UnityEngine;
using System.Collections;

public class Class : MonoBehaviour
{
    void OnBecameVisible()
    {
        enabled = true;
    }
}

public class script: MonoBehaviour
{
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void DestroyScriptInstance()
    {
        Destroy(this);
    }

    void DestroyComponent()
    {
        Destroy(GetComponent<Rigidbody>());
    }

    void DestroyObjectDelayed()
    {
       Destroy(gameObject,10 );
    }
