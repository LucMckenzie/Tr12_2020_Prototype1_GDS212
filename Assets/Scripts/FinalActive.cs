using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalActive : MonoBehaviour
{
    public bool isLoaded;
    public GameObject Story;
    string StoryID = Active.storyValue.ToString();
    public string story;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("String " + StoryID);
        
        Story = GameObject.FindWithTag(StoryID);
        Debug.Log(Story.tag);
        
        
        story = Story.ToString();

        if(story == StoryID)
        Debug.Log("Play prefab");
        {
            Story.SetActive(true);
            Debug.Log("Set Active Story");
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}