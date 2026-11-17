using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public GameObject bullet;
    public Transform FirePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Shoot();
    }

    void Attack()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }
    void Shoot()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Instantiate(bullet, FirePoint.position, FirePoint.rotation);
        }
    }
}
