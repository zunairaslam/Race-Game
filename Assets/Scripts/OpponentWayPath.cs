using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentWayPath : MonoBehaviour
{
    public OpponentCar opponentCar;
    public Waypoint currentWayPoint;

    private void Awake()
    {
        opponentCar = GetComponent<OpponentCar>();
    }

    private void Start()
    {
        opponentCar.LocateDestination(currentWayPoint.GetPosition());
    }

    private void Update()
    {
        if (opponentCar.destinationReachred)
        {
            currentWayPoint = currentWayPoint.nextWaypoint;
            opponentCar.LocateDestination(currentWayPoint.GetPosition());

        }
    }
}
