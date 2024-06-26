using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDeactivateScript : MonoBehaviour
{
    public GameObject gameObjectToDeactivate;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Activate Game Object 
            gameObjectToDeactivate.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //Activate Game Object 
            gameObjectToDeactivate.SetActive(true);
        }
    }
}

//source code: https://gamedevtraum.com/en/game-and-app-development-with-unity/basic-unity-engine-management/activate-and-deactivate-gameobject-through-code-in-unity/ 