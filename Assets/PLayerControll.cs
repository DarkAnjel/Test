using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerControll : MonoBehaviour
{
    float X;
    float Y;
    public float moveSpeed;
    public float rotateSpeed;
    public bool canMove;
    public DynamicJoystick joy;
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            if(Application.platform==RuntimePlatform.WindowsEditor)
            {
                X = Input.GetAxis("Vertical");
                Y = Input.GetAxis("Horizontal");
                transform.Rotate(0, Y * Time.deltaTime * rotateSpeed, 0);
                if (X > 0)
                {
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                }
            }
            else
            {
                X = joy.Vertical;
                Y = joy.Horizontal;
                transform.Rotate(0, Y * Time.deltaTime * rotateSpeed, 0);
                if (X > 0)
                {
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                }
            }
            
        }
        

       
       

    }
}
