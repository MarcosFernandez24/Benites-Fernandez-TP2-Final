using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    [SerializeField] private List<Button> buttonList;

    [SerializeField] private GameObject mainMenuPanel, creditsPanel;

    public Animator transition;

    public GameObject transitionImage;

    public GameObject introImage;

    public GameObject music;

    public AudioSource ButtonEffect;
    private void Start()
    {

        for (int i = 0; i < buttonList.Count; i++)
        {

            var currButton = buttonList[i];

            
        }

        StartCoroutine(IntroTransition());

    }

    public void StartGame()
    {

        StartCoroutine(IntroExit());

    }
    public void ExitGame()
    {
        StartCoroutine(IntroExitGame());
        

    }
    public void GoToCredits()
    {

        StartCoroutine(CreditsTransition());

    }
    public void GoToMainMenu()
    {

        StartCoroutine(MenuTransition());

    }

    public IEnumerator CreditsTransition()
    {
        ButtonEffect.Play();
        transitionImage.SetActive(true);
        transition.SetBool("Transition", true);

        yield return new WaitForSeconds(0.7f);

        creditsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);

        yield return new WaitForSeconds(0.7f);

        
        transition.SetBool("Transition", false);
        transitionImage.SetActive(false);
    }


    public IEnumerator MenuTransition()
    {
        ButtonEffect.Play();
        transitionImage.SetActive(true);
        transition.SetBool("Transition", true);

        yield return new WaitForSeconds(0.7f);

        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);

        yield return new WaitForSeconds(0.7f);


        transition.SetBool("Transition", false);
        transitionImage.SetActive(false);
    }

    public IEnumerator IntroTransition()
    {
        yield return new WaitForSeconds(2);

        introImage.SetActive(false);
    }

    public IEnumerator IntroExit()
    {
        ButtonEffect.Play();

        introImage.SetActive(true);

        introImage.GetComponent<Animator>().Play("IntroExit");

        music.GetComponent<Animator>().Play("MusicExit");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Complete Scene");


    }

    public IEnumerator IntroExitGame()
    {
        ButtonEffect.Play();

        introImage.SetActive(true);

        introImage.GetComponent<Animator>().Play("IntroExit");

        music.GetComponent<Animator>().Play("MusicExit");

        yield return new WaitForSeconds(2);

        Application.Quit();


    }
}

