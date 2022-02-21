using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameManager theGameManager;


    public Text TimeText;

    public GameObject PauseMenu;

    public Animator InventoryAnimation;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);

            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            InventoryAnimation.SetBool("pop", true);
        }

        if(Input.GetKeyUp(KeyCode.Tab))
        {
            InventoryAnimation.SetBool("pop", false);
        }



        TimeText.GetComponent<Text>().text = "Time Left: " + Mathf.RoundToInt(theGameManager.Counter).ToString();
    }

    public void ChangeUIColor(RawImage KeyImage, Color KeyColor)
    {
        KeyImage.color = KeyColor;
    }

    public void LoadScene(int SceneIndex)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneIndex);
    }
}
