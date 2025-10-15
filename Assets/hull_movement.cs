using UnityEngine;

public class hull_movement : MonoBehaviour
{

    public float speed = 40.0f;
    public float turnSpeed = 40.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime;

        float steering = Input.GetAxis("Horizontal");
        float turn = steering * turnSpeed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate (0.0f, 0.0f, -movement);
        t.Rotate (0.0f, turn, 0.0f);
    }
}
