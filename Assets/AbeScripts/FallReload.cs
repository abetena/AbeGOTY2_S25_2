using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallReload : MonoBehaviour
{

    public float deathY = -10f;

    // Update is called once per frame
    void Update()
    {
        //if player reaches death height, reload the scene

        if(transform.position.y <= deathY)
        {
            Destroy(gameObject);
        }
    }
}
