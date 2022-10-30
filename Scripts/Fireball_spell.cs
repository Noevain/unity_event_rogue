using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fireball_spell : MonoBehaviour, ISpell
{
    private OnEndEvent m_OnEndEvent;

    public void Cast(Transform origin){
            var newProjectile = Instantiate(Resources.Load("Fireball") as GameObject);
        	newProjectile.transform.position = origin.position + origin.forward * 0.6f;
        	newProjectile.transform.rotation = origin.rotation;
        	const int size = 1;
        	newProjectile.transform.localScale *= size;
            newProjectile.GetComponent<IEffects>().SetOnEndEvent(m_OnEndEvent);
        	newProjectile.GetComponent<Rigidbody>().mass = Mathf.Pow(size, 3);
        	newProjectile.GetComponent<Rigidbody>().AddForce(origin.forward * 20f, ForceMode.Impulse);
    }

    public void SetOnEndEvent(OnEndEvent ev){
        m_OnEndEvent = ev;
    }
    public string UIName(){
        return "Fireball";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
