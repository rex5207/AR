using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDrawing : MonoBehaviour {
	
	public GameObject target;
	public GameObject magnifier;
	public LineRenderer lineRenderer;
	private int LengthOfLineRenderer= 2;  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lineRenderer.SetPosition(0, target.transform.position); // before these were indexed starting with one. Arrays use 0 as the first element.
		lineRenderer.SetPosition(1, magnifier.transform.position);
	}
}
