using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveInput;

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }
}
