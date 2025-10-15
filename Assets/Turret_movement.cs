using UnityEngine;

public class Turret_movement : MonoBehaviour
{
    public float turnSpeed = 75.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //

        float rotation = 0.0f;
        if (Input.GetKey (KeyCode.Q))
        {
            rotation = -turnSpeed * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.E))
        {
            rotation = turnSpeed * Time.deltaTime;
        }

        Transform t = gameObject.transform;
        t.Rotate (0.0f, rotation, 0.0f);
    }
}
