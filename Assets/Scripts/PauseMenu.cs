using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelPausa;
    public GameObject panelPausa2;
    bool pauseOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.P))
            {
                pauseOn = !pauseOn;
                panelPausa.SetActive(pauseOn);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (!pauseOn)
                {
                    Time.timeScale = 1;
                }
                else
                {
                    Time.timeScale = 0;
                }
            }

        
    }
   
   

    public void PauseOff()
    {
        pauseOn = !pauseOn;
        panelPausa2.SetActive(false);
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
