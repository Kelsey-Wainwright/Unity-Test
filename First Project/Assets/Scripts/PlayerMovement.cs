using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference to Rigidbody Component: "rb"
    public Rigidbody rb;

    // Creates Variable for Forward Movement of Player, that Can Be Accessed From Unity
    public float forwardForce = 200f;
    // Creates Variable for Sideways Movement of Player, that Can Be Accessed From Unity
    public float sidewaysForce = 300f;

    // Things that Iterate Every Frame (Fixed is Used for Physics)
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
