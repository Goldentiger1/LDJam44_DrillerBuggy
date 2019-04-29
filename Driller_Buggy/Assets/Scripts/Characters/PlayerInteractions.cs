using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public LayerMask bG;
    public SystemChecker system;
    public GameObject player;
    public int speed;
    public int fingers;
    public Collider2D searchAreaBorder;
    public Transform movePosition;
    Ray ray;

    void Start()
    {
        player = GameObject.Find("Player");
        searchAreaBorder = GameObject.Find("EnergyCore").gameObject.GetComponent<Collider2D>();
        system = GameObject.Find("SystemChecker").gameObject.GetComponent<SystemChecker>();
    }

    void Update()
    {
        if(system.Desktop == true && system.Handheld == false)
        {
            if (Input.GetMouseButtonDown(2))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit, 100, bG))
                {

                    print("hip");
                }
            }
        }
        else if(system.Handheld == true && system.Desktop == false)
        {

        }
    }
}