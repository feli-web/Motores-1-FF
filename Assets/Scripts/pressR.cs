using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressR : MonoBehaviour

{
   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("level1");
        }
    }


}
// FindObjectOfType<manager>().EndGame();