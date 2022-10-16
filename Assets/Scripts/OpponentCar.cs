using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCar : MonoBehaviour
{

    public float movingSpeed;
    public float turningSpeed = 50f;
    public float breakSpeed = 12f;

    public Vector3 destination;
    public bool destinationReachred;

    private void Update()
    {
        Drive();
    }

    public void Drive()
    {
        if(transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;
            float destinationDistance = destinationDirection.magnitude  ;
            if (destinationDistance >= breakSpeed)
            {
                destinationReachred = false;
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turningSpeed * Time.deltaTime);

                transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
            }else
            {
                destinationReachred = true;
            }
        }
    }
    
    public void LocateDestination(Vector3 destination)
    {
        this.destination = destination;
        destinationReachred = false;

    }


}
