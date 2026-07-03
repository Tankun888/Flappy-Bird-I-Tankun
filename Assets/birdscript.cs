using UnityEngine;
using UnityEngine.InputSystem;
public class birdscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10f;

    void Start()
    {

    }

    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = new Vector2(0, jumpForce * 2);
        }
    }
}