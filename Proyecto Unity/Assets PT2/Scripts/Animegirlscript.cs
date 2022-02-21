using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animegirlscript : MonoBehaviour
{
    [SerializeField] private Transform interactBasePosition;

    public PlayerData1 Data;
    
    private Animator Animator;

    public float speed = 6f;
    public CharacterController controller;
    private float smoothTime = 0.1f;
    private float turnSmoothVelocity;

    public Transform cam;

    public bool itemInFront;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(interactBasePosition.position, Data.InteractionRadius);
    }

    private void PlayerMovement(Vector3 movement)
    {


        //transform.position += PlayerSpeed * movement * Time.deltaTime;

        Animator.SetFloat("Speed", movement.magnitude);

        if (Input.GetKey(KeyCode.E) && itemInFront)
        {
            
            Animator.SetBool("E", true);

        }

    }

    private void DetectInteractable()
    {
        if (!Input.GetKeyDown(Data.InteractionKey))
            return;
        var objectsInRange = Physics.OverlapSphere(interactBasePosition.position, Data.InteractionRadius,
            Data.InteractableLayerMask);

        if (objectsInRange.Length == 0) return;

        if (objectsInRange[0].TryGetComponent<InteractableObject>(out var interactable))
        {
            interactable.OnInteraction();
        }

       
    }

    void Start()
    {


        Animator = GetComponent<Animator>();
        


    }

   
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z).normalized;

        if(movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDirection.normalized * Data.Speed * Time.deltaTime);
        }

        

        PlayerMovement(movement);

        DetectInteractable();

    }

    

}
