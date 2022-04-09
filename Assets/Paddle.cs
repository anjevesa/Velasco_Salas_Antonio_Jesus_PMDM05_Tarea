using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

   [SerializeField]  private float speed = 7f;
    [SerializeField] private bool isPaddle_Left;
    [SerializeField] private bool isPaddle_Right;
    [SerializeField] private bool isPaddle_Left_Horizontal;
    [SerializeField] private bool isPaddle_Rigth_Horizontal;
    float movement_vertical;
    float movement_horizontal;
    private float yBound = 3.75f;
    private float xBound = 8f;

    // Start is called before the first frame update
    void Start()
    {
         
    } 

    // Update is called once per frame
    void Update()
    { 
        

        if (isPaddle_Left)
        {
            movement_vertical = Input.GetAxisRaw("Vertical");

            Vector2 paddlePosition = transform.position;
            paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement_vertical * speed * Time.deltaTime, -yBound, yBound);
            transform.position = paddlePosition;
        }
        if (isPaddle_Right)
        {
            movement_vertical = Input.GetAxisRaw("Vertical2");
            Vector2 paddlePosition = transform.position;
            paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement_vertical * speed * Time.deltaTime, -yBound, yBound);
            transform.position = paddlePosition;
        }
        if (isPaddle_Left_Horizontal)
        {

            movement_vertical = Input.GetAxisRaw("Vertical");

            Vector2 paddlePosition = transform.position;
            paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement_vertical * speed * Time.deltaTime, -yBound, yBound);
            transform.position = paddlePosition;

            movement_horizontal = Input.GetAxisRaw("Horizontal");

            Vector2 paddlePosition2 = transform.position;
            paddlePosition2.x = Mathf.Clamp(paddlePosition2.x + movement_horizontal * speed * Time.deltaTime, -xBound, xBound);
            transform.position = paddlePosition2;
        }

        if (isPaddle_Rigth_Horizontal)
        {

            movement_vertical = Input.GetAxisRaw("Vertical2"); 
            Vector2 paddlePosition = transform.position;
            paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement_vertical * speed * Time.deltaTime, -yBound, yBound);
            transform.position = paddlePosition;

            movement_horizontal = Input.GetAxisRaw("Horizontal2");

            Vector2 paddlePosition2 = transform.position;
            paddlePosition2.x = Mathf.Clamp(paddlePosition2.x + movement_horizontal * speed * Time.deltaTime, -xBound, xBound);
            transform.position = paddlePosition2;
        }



    } 
}
 