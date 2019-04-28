using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public SystemChecker system;
    public GameObject player;
    public int speed;
    public int fingers;
    public Collider2D searchAreaBorder;

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

        }
        else if(system.Handheld == true && system.Desktop == false)
        {

        }
    }
}