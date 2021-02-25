using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour
{
    //Variables
    public float moveSpeed = 200f;
    public GameObject player;

    private Rigidbody characterBody;
    private float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = player.GetComponent<Rigidbody> ();

    }



    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while(i< Input.touchCount){
            if (Input.GetTouch (i).position.x > ScreenWidth / 2){
                //MOVEMENT RIGHT
                RunCharacter(1.0f);
            }
            if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
                //Movement LEFT
                RunCharacter (-1.0f);
            }
            ++i;
        }
    }
        private void RunCharacter(float horizontalInput){
            //MOVE PLAYER
            characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
        }
    
}
