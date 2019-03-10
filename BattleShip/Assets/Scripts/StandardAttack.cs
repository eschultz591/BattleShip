using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardAttack : MonoBehaviour
{
    public bool destroy = false;
    void Start()
    {
            destroy = false;

}
  

    // Update is called once per frame
    void Update()
    {
        if (destroy == true)
        {
            Destroy(gameObject);
        }  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dummy")
        {
            Debug.Log("HIT");
        }
        else
        {
            Debug.Log("no hit");
        }
        if (other.tag == "Player")
        {
            Debug.Log("Player hit");
        }
                
    }
}
