using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Player_Mana : MonoBehaviour
{
    public int mana = 60;
    public int burst_cost = 20;
    private bool on_cooldown = false;
    public float max_cooldown_time = 2f;
    private float cooldown_time;
    [SerializeField] private TMP_Text manaText;
    [SerializeField] private Animator animator;

    void Start()
    {
        manaText.text = "Mana: " + mana;
        cooldown_time = max_cooldown_time;
    }

    void Update()
    {

        if (Keyboard.current.eKey.wasPressedThisFrame && mana >= burst_cost && !on_cooldown)
        {
            mana = mana - burst_cost;
            manaText.text = "Mana: " + mana;
            animator.SetTrigger("burst");
            on_cooldown = true;
        }

        if (on_cooldown == true && cooldown_time > 0)
        {
            cooldown_time -= Time.deltaTime;
        }
        if (cooldown_time <= 0)
        {
            cooldown_time = max_cooldown_time;
            on_cooldown = false;
        }
    }    
}
