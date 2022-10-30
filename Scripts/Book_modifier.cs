using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Book_modifier : MonoBehaviour
{

    void OnCollisionEnter(Collision collision) {
       
        if (collision.gameObject.tag == "Player"){
            //add to spellbook
            FirstPersonController pc = collision.gameObject.GetComponent<FirstPersonController>();
            pc.AddToEndEvent(Modifier_effect);
            Destroy(gameObject);

        }
    }

    static void Modifier_effect(Transform origin){
         var newProjectile = Instantiate(Resources.Load("Fireball") as GameObject);
            //newProjectile.GetComponent<IEffects>().SetOnEndEvent(m_OnEndEvent);//no repetition(for now lul)
        	newProjectile.transform.position = origin.position + origin.forward * 0.6f;
        	newProjectile.transform.rotation = origin.rotation;
        	const int size = 1;
        	newProjectile.transform.localScale *= size;
        	newProjectile.GetComponent<Rigidbody>().mass = Mathf.Pow(size, 3);
        	newProjectile.GetComponent<Rigidbody>().AddForce(origin.forward * 20f, ForceMode.Impulse);

    }
    
}
