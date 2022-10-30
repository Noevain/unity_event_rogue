using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fireball_explosion : MonoBehaviour,IEffects
{

    private float initTime;
    private float aliveTime;
    private OnEndEvent m_OnEndEvent;
    
    public void SetOnEndEvent(OnEndEvent ev){
        m_OnEndEvent = ev;
    }
    // Start is called before the first frame update
    void Start()
    {
        initTime = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        aliveTime = Time.timeSinceLevelLoad - initTime;
        if(aliveTime > 0.3f){
            if(m_OnEndEvent!=null){//if it's not set,it's a children of a children,don't overload the engine
            m_OnEndEvent.Invoke(transform);
            }
            Destroy(gameObject);
        }
    }
}
