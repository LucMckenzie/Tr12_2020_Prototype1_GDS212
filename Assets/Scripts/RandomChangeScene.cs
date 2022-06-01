using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomChangeScene : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        sceneID = Random.Range(1,5);
        SceneManager.LoadScene(sceneID);
    }
}