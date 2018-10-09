using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public Grid background;
    public Transform generationPoint;
    public float distanceBetween;
    public Collider2D floor;

    public float backgroundWidth;
    // Use this for initialization
    void Start()
    {
        backgroundWidth = floor.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
