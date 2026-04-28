using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime,0f,0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*Time.deltaTime,0f,0f);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f,0f,speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f,0f,-speed*Time.deltaTime);
        }
        if(transform.position.z >= -0.5 && transform.position.x >= -0.5)
        {
            //end game
            Debug.Log("Game Over");
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        //rotate mechanism 
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f,-100f*Time.deltaTime,0f);
        }
         if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,100f*Time.deltaTime,0f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-100f*Time.deltaTime,0f,0f);
        }
         if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(100f*Time.deltaTime,0f,0f);
        }
    }

    void Awake()
    {
        Debug.Log("Awake");
    }
}

