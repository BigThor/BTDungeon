using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //hit.collider.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log(hit.point);
                transform.position = Vector3.MoveTowards(transform.position, hit.point, playerSpeed * Time.deltaTime);
            }
        }
    }
}
