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
            Debug.Log("BANG");
        }  
    }
}
