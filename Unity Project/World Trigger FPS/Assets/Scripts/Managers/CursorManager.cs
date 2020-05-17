using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorManager : MonoBehaviour
{
    [SerializeField]
    private List<int> LockHideOnAwakeSceneIndexs = new List<int>();
    [SerializeField]
    private List<int> ConfineOnAwakeIndexs = new List<int>();

    private void Awake()
    {
        if (LockHideOnAwakeSceneIndexs.Contains(SceneManager.GetActiveScene().buildIndex))
        {
            LockHide();
        }
        else if (ConfineOnAwakeIndexs.Contains(SceneManager.GetActiveScene().buildIndex))
        {
            Confine();
        }
    }

    private static void LockHide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private static void Confine()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
