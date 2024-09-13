using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personController : MonoBehaviour
{
    Animator animator;
    CharacterController characterController;
    public float speed = 5.0f;
    public float accel = 2.0f;
    public float currentSpeed = 0.0f;
    public Vector3 currentMovement = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool change = Input.GetKey("c");
        animator.SetBool("change", change);
        bool isWalking = Input.GetKey("w");
        animator.SetBool("isWalking", isWalking);
        
        if(isWalking) {
            currentSpeed = Mathf.Lerp(currentSpeed, speed, accel * Time.deltaTime);
            currentMovement = transform.forward * currentSpeed * Time.deltaTime;
        }
        
        //AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        characterController.Move(currentMovement);
    }
}
