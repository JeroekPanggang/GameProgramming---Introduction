using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    // Start is called before the first frame update
    
    public SceneLoader sceneLoader;
    public string sceneName;
    void Start()
    {
        Invoke("AutoLoad", 3.0f);
    }

    // Update is called once per frame
    void AutoLoad()
    {
        sceneLoader.ChangeScene(sceneName);
    }
}
