using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deActivateScript : MonoBehaviour
{
    
    public Transform[] Endings;
    

    // Start is called before the first frame update
    void Start()
    {
        Endings = new Transform[transform.childCount];

        BroadcastMessage("hideText");
       
        
        
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
