using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Book_page : MonoBehaviour
{

    void OnCollisionEnter(Collision collision) {
       
        if (collision.gameObject.tag == "Player"){
            //add to spellbook
            FirstPersonController pc = collision.gameObject.GetComponent<FirstPersonController>();
            pc.AddToSpellBook(new Fireball_spell());
            Destroy(gameObject);

        }
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
