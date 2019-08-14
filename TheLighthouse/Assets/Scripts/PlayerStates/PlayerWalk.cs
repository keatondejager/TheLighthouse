using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : StateMachineBehaviour
{
    protected GameObject Player;
    private Animator animControl;

    private Rigidbody rb;

    public float speed;
    private Vector3 lookPoint;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if (!Player) 
       {
           Player = GameObject.FindGameObjectWithTag("Player");
       }
        animControl = Player.GetComponent<Animator>();
        rb = Player.GetComponent<Rigidbody>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); 
       if (input.sqrMagnitude == 0) {
           animControl.SetBool("isWalking", false);
           return;
       }

        rb.velocity = input.normalized * speed;
        lookPoint = Player.transform.position + rb.velocity;

        Player.transform.rotation = Quaternion.Lerp(Player.transform.rotation, Quaternion.LookRotation(rb.velocity, Vector3.up), 30f * Time.deltaTime);

       if (Input.GetButtonDown("Jump")) {
           animControl.SetTrigger("Jump");
           return;
       }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
