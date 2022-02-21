using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPick : MonoBehaviour
{


    [SerializeField] private Transform RayCast;
    [SerializeField] private float MaxDistance;
    [SerializeField] private LayerMask RaycastLayer;
    [SerializeField] private GameObject Key;

    public UnityEngine.UI.RawImage KeyImage;

    public Color KeyColor;

    public Menu theMenu;


    public bool PickedUpKey;

    public Vector3 RaycastDirection;

    public Animator TextAnimator;

    private void Update()
    {
        Debug.DrawRay(RayCast.position, RaycastDirection, Color.blue);

        if (Input.GetKeyDown(KeyCode.E))
        {

            RayCastInteract();

        }

    }
    public void RayCastInteract()
    {
        RaycastHit hit;
        var Collided = Physics.Raycast(RayCast.position, RaycastDirection, out hit, MaxDistance, RaycastLayer);

        if (Collided)
        {
            Debug.Log($"Hit{hit.transform.position}");
            Key.SetActive(false);
            PickedUpKey = true;

            theMenu.ChangeUIColor(KeyImage, KeyColor);

            TextAnimator.Play("TextPopUp");

        }
        else
        {
            Debug.Log($"Didn't hit anything");


        }


    }
}