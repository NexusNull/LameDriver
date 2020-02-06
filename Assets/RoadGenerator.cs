using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Driver driver = default;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform tmp = transform.GetChild(transform.childCount - 4);
        if (tmp) {
            if ((driver.transform.position - tmp.transform.position).magnitude > 10f)
            {
                this.generateNewRoadPiece();
                driver.reward();
            }
        }
    }

    float accumulator = 0f;
    public void generateNewRoadPiece()
    {
        Transform tmp1 = transform.GetChild(0);
        Transform tmp2 = transform.GetChild(transform.childCount - 1);
        GameObject lastRoad;
        GameObject firstRoad;
        if (tmp1 && tmp2)
        {
            firstRoad = tmp1.gameObject;
            lastRoad = tmp2.gameObject;
            lastRoad.transform.position = firstRoad.transform.position + (firstRoad.transform.forward*9.5f);
            lastRoad.transform.rotation = firstRoad.transform.rotation;
            accumulator = Mathf.Clamp(accumulator + Random.Range(-3f, 3f), -10f, 10f);
            lastRoad.transform.Rotate(0, accumulator, 0);
            lastRoad.transform.SetSiblingIndex(0);
        }

    }


}
