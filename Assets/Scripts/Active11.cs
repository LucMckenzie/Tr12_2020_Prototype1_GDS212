using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Active11 : MonoBehaviour
{
    public bool isLoaded;
    public int sceneCount;
    // Start is called before the first frame update
    void Start()
    {
        if (!isLoaded)
            isLoaded = true;
        Active.sceneCounVar = 1170;

        Active.storyValue = Active.storyValue + Active.sceneCounVar;
        Debug.Log("Scene Active");
        Debug.Log("Story Value " + Active.storyValue);


    }
    // Update is called once per frame
    void Update()
    {

    }
}
