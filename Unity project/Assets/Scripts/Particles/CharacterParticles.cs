using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterParticles : MonoBehaviour
{
    // Variables for foot-based particle animations
    // &&&&& With a GameObject &&&&& 
    //public GameObject particles;

    // ^^^^^^^^^^ With a user-defined Particle system ^^^^^^^^^^
    public VisualFX footstepsFX;

    public Transform leftFoot;
    public Transform rightFoot;

    public void Step(int footIndex)
    {
        // Find the correct foot to spawn particles at. If the footIndex is 1, then it's leftFoot, else it's rightFoot
        Transform foot = footIndex == 1 ? leftFoot : rightFoot;

        // Instantiate a copy of the particle with no rotation at the foot's position. It is NOT a child of the foot.
        // &&&&& With a GameObject &&&&& 
        //GameObject go = Instantiate(particles, foot.position, Quaternion.identity);

        // ^^^^^^^^^^ With a user-defined Particle system ^^^^^^^^^^
        GameObject go = footstepsFX.Spawn(foot);

        // Remove the particle system after a few seconds, after all particles have died away
        Destroy(go, 3);

        // Just some debugs
        //if (footIndex == 1)
        //{
        //    Debug.Log("Left foot hit the ground.");
        //}

        //if (footIndex == 2)
        //{
        //    Debug.Log("Right foot hit the ground.");
        //}
    }
}
