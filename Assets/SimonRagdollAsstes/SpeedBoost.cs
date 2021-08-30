using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public Rigidbody Speedy;
    public float Speed=50;
    // Start is called before the first frame update
    void Start()
    {
        Speedy = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedUp();
        };
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
         
    }

    public void SpeedUp()
    {
        Speed += 10;
    }
  
}
