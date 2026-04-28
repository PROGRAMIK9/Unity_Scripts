using UnityEngine;

public class Rotation2_5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotation = 2.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*rotation*Time.deltaTime);
    }
}
