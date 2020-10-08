using System.Collections;
using System.Collections.Generic;
using Object.Player;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetInput();
    }

    private KeyCode? GetInput()
    {
        var horizontalMoving = Input.GetAxis("Horizontal");
        KeyCode? input = null;
        if (horizontalMoving != 0)
        {
            input = horizontalMoving > 0 ? KeyCode.RightArrow : KeyCode.LeftArrow;
            player.Move(horizontalMoving);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("Input X");
            player.Jump();
        }
        
        return input;
    }
}
