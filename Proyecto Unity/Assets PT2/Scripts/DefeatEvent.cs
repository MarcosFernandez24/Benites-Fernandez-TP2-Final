using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DefeatEvent : MonoBehaviour
{
    public event Action<Vector3> onDefeat;
    public GameObject Player;
    public Transform defeatPoint;
    public float Counter;
    [SerializeField] private DefeatEvent[] Followers;
    private bool winningGame;
   

    public void Defeat(Vector3 dir)
    {
        Counter -= Time.deltaTime;

        if (Counter <= 0)
        {

            Player.transform.position = defeatPoint.position;

        }

        if (winningGame == true)
        {

            Counter += Time.deltaTime;

        }

    }
    private void Awake()
    {
        for (int i = 0; i < Followers.Length; i++)
        {
            onDefeat += Followers[i].Defeat;
        }
        
    }
    private void Update()
    {
        
        var dir = new Vector3(0, 0.6538765f, 0);
        onDefeat?.Invoke(dir);
        Defeat(dir);
    }
}
