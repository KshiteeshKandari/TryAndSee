using UnityEngine;

public class Animate : MonoBehaviour {
    private Animator anim;

    void Start() {
        // Get an instance of the Animator component attached to the character.
        anim = GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Set the trigger value to True for the parameter Dance.
            anim.SetTrigger("Jump");
        }
        if (Input.GetKey(KeyCode.W)) {
            // Set the trigger value to True for the parameter Dance.
            anim.SetTrigger("Run");
        }
       
        if (Input.GetKey(KeyCode.S)) {
            // Set the trigger value to True for the parameter Dance.
            anim.SetTrigger("Run");
        } 
       
        if (Input.GetKey(KeyCode.S)) {
            // Set the trigger value to True for the parameter Dance.
            anim.SetTrigger("Run");
        } 
        if (Input.GetMouseButtonDown(0))
        {
           anim.SetTrigger("Punch");
        }
    }
}