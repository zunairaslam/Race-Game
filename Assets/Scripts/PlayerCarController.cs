using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    public WheelCollider fLWC;
    public WheelCollider fRWC;
    public WheelCollider bLWC;
    public WheelCollider bRWC;
    public Transform fLWT;
    public Transform fRWT;
    public Transform bLWT;
    public Transform bRWT;
    public float aForce = 300f;
    private float pAF = 0f;
    public float bForce = 3000f;
    private float pBForce = 0f;
    public float wTorque = 40f;
    private float pTAngle = 0f;




    private void Update()
    {
        CarMovement();
        CarHandling();
        CarBreaks();
    }

    private void CarMovement()
    {
        fLWC.motorTorque = pAF;
        fRWC.motorTorque = pAF;
        bLWC.motorTorque = pAF;
        bRWC.motorTorque = pAF;

        pAF = aForce * Input.GetAxis("Vertical");

    }

    private void CarHandling()
    {
        fLWC.steerAngle = pTAngle;
        fRWC.steerAngle = pTAngle;

        pTAngle = wTorque * Input.GetAxis("Horizontal");

        wheelsMovement(fLWC, fLWT);
        wheelsMovement(fRWC, fRWT);
        wheelsMovement(bLWC, bLWT);
        wheelsMovement(bRWC, bRWT);
    }

    void wheelsMovement(WheelCollider WC, Transform WT)
    {
        Vector3 position;
        Quaternion rotation;

        WC.GetWorldPose(out position, out rotation);

        WT.position = position;
        WT.rotation = rotation;
    }

    public void CarBreaks()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            pBForce = bForce;
        }else
        {
            pBForce = 0f;
            
        }
        fLWC.brakeTorque = pBForce;
        fRWC.brakeTorque = pBForce;
        bLWC.brakeTorque = pBForce;
        bRWC.brakeTorque = pBForce;

    }
}
