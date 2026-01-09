using UnityEngine;
using UnityEngine.InputSystem;

public class Switchplayerstance : MonoBehaviour
{
	public InputActionAsset PlayerAction;
	public Animator PlayerSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAction.FindAction("Move").IsPressed())
		{
			PlayerSprite.SetBool("Idle", true);
		}
		else 
		{
			PlayerSprite.SetBool("Idle", false);
		}
		if (PlayerAction.FindAction("Move").IsPressed())
		{
			PlayerSprite.SetBool("Run", true);
		}
		else 
		{
			PlayerSprite.SetBool("Run", false);
		}
    }
}
