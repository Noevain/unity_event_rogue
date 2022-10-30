using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour,IEffects
{

    private float initTime;
    private float aliveTime;

    private OnEndEvent m_OnEndEvent;

    public void SetOnEndEvent(OnEndEvent ev){
        m_OnEndEvent = ev;
    }


    void OnCollisionEnter(Collision collision){
        if(aliveTime > 1.0f){
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        var explo = Instantiate(Resources.Load("Explosion_02") as GameObject, position, rotation);
        explo.GetComponent<IEffects>().SetOnEndEvent(m_OnEndEvent);
        Destroy(gameObject);
        }
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
         if(aliveTime > 3.0f){
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, transform.eulerAngles);
        Vector3 position = this.transform.position;
        var explo = Instantiate(Resources.Load("Explosion_02") as GameObject, position, rotation);
        explo.GetComponent<IEffects>().SetOnEndEvent(m_OnEndEvent);
        Destroy(gameObject);
        }
        
    }
}
