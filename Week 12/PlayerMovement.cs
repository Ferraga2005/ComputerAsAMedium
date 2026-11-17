using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    
    public SpriteRenderer spriteRenderer;
    public GameObject firepoint;

    public Sprite plrTop;
    public Sprite plrBottom;
    public Sprite plrLeft;
    public Sprite plrRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        // In rotation, 0 is up.
        if (Keyboard.current.aKey.isPressed) // Left
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = plrRight;
            transform.localScale = new Vector3(-.3f, .3f, .3f);
            firepoint.transform.localPosition = new Vector2(1.5f, -.5f);
            firepoint.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Keyboard.current.dKey.isPressed) // Right
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = plrRight;
            transform.localScale = new Vector3(.3f, .3f, .3f);
            firepoint.transform.localPosition = new Vector2(1.5f, -.5f);
            firepoint.transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed) // Up
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = plrTop;
            firepoint.transform.localPosition = new Vector2(0, 1.5f);
            firepoint.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Keyboard.current.sKey.isPressed) // Down
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = plrBottom;
            firepoint.transform.localPosition = new Vector2(.5f, -1.5f);
            firepoint.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else
        {
            speedY = 0;
        }
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
