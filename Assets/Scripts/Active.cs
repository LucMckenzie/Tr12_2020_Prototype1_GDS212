using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Active : MonoBehaviour
{
    public bool isLoaded;
    public static int sceneCount;
    public static int sceneCounVar;
    public static int storyValue;
    // Start is called before the first frame update
    void Start()
    {
        sceneCount = 0;
        sceneCounVar = 0;
        if (!isLoaded)
            isLoaded = true;
       storyValue = sceneCount + sceneCounVar;
        Debug.Log("Scene Active");
        Debug.Log("Story Value " + storyValue);


    }
    // Update is called once per frame
    void Update()
    {

    }


}
