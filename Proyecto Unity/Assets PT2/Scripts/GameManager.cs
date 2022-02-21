using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [SerializeField] public float Counter;
    [SerializeField] private GameObject DefeatPoint;
    [SerializeField] private GameObject thePlayer;

    public Animator LostTransition;
    public GameObject TransitionImage;

    public GameObject defeatMenu;

    public GameObject timerText;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

    }
    void Update()
    {

        Counter -= Time.deltaTime;

        if (Counter <= 0)
        {
            DefeatTime();

        }

    }

    private void DefeatTime()
    {

        StartCoroutine(DefeatTimeOver());

    } 

    IEnumerator DefeatTimeOver()
    {
        timerText.SetActive(false);
        Counter = 300f;
        TransitionImage.SetActive(true);
        LostTransition.Play("LostShadow");

        yield return new WaitForSeconds(20);


        thePlayer.transform.position = DefeatPoint.transform.position;
        TransitionImage.SetActive(false);
        defeatMenu.SetActive(true);
    }
}
