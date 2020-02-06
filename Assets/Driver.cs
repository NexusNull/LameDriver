using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class Driver : Agent
{
    // Start is called before the first frame update
    [SerializeField] GameObject road = default;
    [SerializeField] float MaxRayDistance = default;
    [SerializeField] float turnStrength = 5;
    float turn = 0;
    void Start()
    {
        AgentReset();
    }
    void Update()
    {
        Vector3 forward = this.transform.forward.normalized;
        float angle = Mathf.Atan2(forward.x, forward.z);
        this.transform.Rotate(0, turn * turnStrength, 0);
        this.transform.position = this.transform.position + forward;

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            turn = 0;
        }
    
        if (Input.GetKeyDown(KeyCode.A))
        {
            turn = -1;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            turn = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Done");
        Done();
    }

    public override void AgentReset()
    {
        Transform tmp2 = road.transform.GetChild(road.transform.childCount - 4);
        GameObject lastRoad;
        if (tmp2)
        {
            lastRoad = tmp2.gameObject;
            Vector3 tmp = lastRoad.transform.position;
            tmp.y = .5f;
            this.transform.position = tmp;
            this.transform.rotation = lastRoad.transform.rotation;
        }
    }

    public override void AgentAction(float[] vectorAction)
    {
        turn = Mathf.Clamp(vectorAction[0], -1, 1);
    }

    public void reward()
    {
        AddReward(1f);
    }

    public override void CollectObservations()
    {
        //View Vectors;

        
        Vector3 forward = this.transform.forward.normalized;
        float angle = Mathf.Atan2(forward.x, forward.z);

        Vector3 leftForwardVector = new Vector3(Mathf.Sin(angle - .5f), 0, Mathf.Cos(angle - .5f));
        Vector3 rightForwardVector = new Vector3(Mathf.Sin(angle + .5f), 0, Mathf.Cos(angle + .5f));
        Vector3 leftleftForwardVector = new Vector3(Mathf.Sin(angle - 1), 0, Mathf.Cos(angle - 1));
        Vector3 rightrightForwardVector = new Vector3(Mathf.Sin(angle + 1), 0, Mathf.Cos(angle + 1));

        RaycastHit leftleftHit;
        Physics.Raycast(transform.position, leftleftForwardVector, out leftleftHit, MaxRayDistance);
        RaycastHit leftHit;
        Physics.Raycast(transform.position, leftForwardVector, out leftHit, MaxRayDistance);
        RaycastHit forwardHit;
        Physics.Raycast(transform.position, transform.forward, out forwardHit, MaxRayDistance);
        RaycastHit rightHit;
        Physics.Raycast(transform.position, rightForwardVector, out rightHit, MaxRayDistance);
        RaycastHit rightrightHit;
        Physics.Raycast(transform.position, rightrightForwardVector, out rightrightHit, MaxRayDistance);


        AddVectorObs(leftleftHit.distance == 0 ? MaxRayDistance : leftleftHit.distance);
        AddVectorObs(leftHit.distance == 0 ? MaxRayDistance: leftHit.distance);
        AddVectorObs(forwardHit.distance == 0 ? MaxRayDistance : forwardHit.distance);
        AddVectorObs(rightHit.distance == 0 ? MaxRayDistance : rightHit.distance);
        AddVectorObs(rightrightHit.distance == 0 ? MaxRayDistance : rightrightHit.distance);
        /*
        Debug.Log((leftleftHit.distance == 0 ? MaxRayDistance : leftleftHit.distance) + " " +
        (leftHit.distance == 0 ? MaxRayDistance : leftHit.distance) + " " +
        (forwardHit.distance == 0 ? MaxRayDistance : forwardHit.distance) + " " +
        (rightHit.distance == 0 ? MaxRayDistance : rightHit.distance) + " " +
        (rightrightHit.distance == 0 ? MaxRayDistance : rightrightHit.distance));
        */
    }
}
