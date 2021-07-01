using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField]
    private SceneChanger playerCamera;
    [SerializeField]
    private string sceneName;
    public void OnMouseDown()
    {
        playerCamera.ChangeScene(sceneName);
    }
}
