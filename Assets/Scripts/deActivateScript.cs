using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deActivateScript : MonoBehaviour
{
    
    public GameObject hideText;

    // Start is called before the first frame update
    void Start()
    {
        hideText = GameObject.Find("Canvas");
        BroadcastMessage("hideText");
       
        hideText.SetActive(false);
        
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
