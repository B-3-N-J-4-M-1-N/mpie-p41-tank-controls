using UnityEngine;

public class Turret_movement : MonoBehaviour
{
    public float turnSpeed = 75.0f;
    public int controlMode = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            controlMode = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            controlMode = 2;
        }

        float rotation = 0.0f;

        if (controlMode == 1) {
            float turn = Input.GetAxis("Mouse X");
            rotation = turn * turnSpeed * Time.deltaTime;
        }
        else if (controlMode == 2) {
            if (Input.GetKey(KeyCode.Q))
            {
                rotation = -turnSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.E))
            {
                rotation = turnSpeed * Time.deltaTime;
            }
        }

        Transform t = gameObject.transform;
        t.Rotate (0.0f, rotation, 0.0f);
    }
}
