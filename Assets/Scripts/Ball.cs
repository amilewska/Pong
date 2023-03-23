using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float ballSpeed = 2f;
    private Vector3 moveDir;
    [SerializeField]private float range = 1f;
    [SerializeField] private LayerMask playersLayerMask;
    [SerializeField] private bool hitPlayer;

    private void Start()
    {
        moveDir = Vector3.right;
    }
    void Update()
    {
        
        transform.Translate(moveDir * Time.deltaTime * ballSpeed);

        Ray theRay = new Ray(transform.position, moveDir * range);

        if (Physics.Raycast(transform.position, moveDir, out RaycastHit hit, range, playersLayerMask))
        {
            if(hit.transform.TryGetComponent(out Player player))
            {
                moveDir *=-1;
            }
            
        }

        
        Debug.DrawRay(transform.position, transform.TransformDirection(moveDir * range));


    }


}

