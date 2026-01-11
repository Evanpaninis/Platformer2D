using System;
using System.Collections.Generic;
using UnityEngine;

public class PatrolSystem : MonoBehaviour
{
    [SerializeField] private Transform patrolPath;
    [SerializeField] private float speed;
    private List<Vector3> patrolPoints = new List<Vector3>();
    private int currentIndex = 0;
    private void Awake()
    {
        foreach (Transform child in patrolPath)
        {
            
            patrolPoints.Add(child.position);
        }
        
        transform.eulerAngles = transform.position.x > patrolPoints[currentIndex].x ? new Vector3(0,180,0) : Vector3.zero;
    }

    
    void Start()
    {

    }

    
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentIndex], speed * Time.deltaTime);
        if (transform.position == patrolPoints[currentIndex]) 
        {
            SetNewDestination();

        }
    }

    private void SetNewDestination()
    {
        
        currentIndex = (currentIndex + 1) % patrolPoints.Count;


        
        if (transform.position.x > patrolPoints[currentIndex].x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else 
        { 
            transform.eulerAngles = Vector3.zero;
        }
    }
}