using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            byebye();
        }
    }
    public void byebye()
    {
        SceneManager.LoadScene(0);
    }
}
