using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 InitialDifference;

    [SerializeField] private Transform Target;

    [SerializeField] private float RotationTime;

    // Start is called before the first frame update
    void Start()
    {

        InitialDifference = Target.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        var diff = Target.position - InitialDifference;

        transform.position = Target.position - InitialDifference;

    }
}
