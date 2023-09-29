using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// This script reads input and animates the character
public class PlayerController : MonoBehaviour
{
    // An object to animate the character
    Animator animator;

    void Start()
    {
        // Set our Animator equal to the one attached to the object that calls this script
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Get a reference to the Animator sibling component and feed it values for how much to go forwards, backwards and turn, which correspond to the following exposed parameters in the AnimationController:
         * "Forward" determines how fast the character should move ( 0 = idle, 0.5 = walk, 1 = run )
         * "Turn" determines how much to turn ( -1 = left,m 0 = straight ahead, +1 = right )
         * "Sense" determines whether the character is moving forward (+1) or backwards (-1)
        */

        // Define a float that will be used for animation transitions
        float fwd = Input.GetAxis("Vertical");

        // Send float values to the Animator to affect animation transitions
        animator.SetFloat("Forward", Mathf.Abs(fwd));
        animator.SetFloat("Sense", Mathf.Sign(fwd));
        animator.SetFloat("Turn", Input.GetAxis("Horizontal"));
    }
}
