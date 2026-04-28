using UnityEngine;

public class Rotation1_7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotation = 1.7f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*rotation*Time.deltaTime);
    }
}
