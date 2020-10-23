using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float Speed = 1;
	
	public bool RotateY = true;
	public bool RotateX = true;
	public bool RotateZ = true;
	public bool LocalAxes = true;
	
	
	public bool StopAfterTime = false;
	public float StopTime = 28;
	
	private float TimeoutTime = -1;
	private bool DoRotate = true;
	
	// Use this for initialization
	void Start () {
		DoRotate = true;
		TimeoutTime = Time.time + StopTime;
	}
	
	void OnEnable()
	{
		DoRotate = true;
		TimeoutTime = Time.time + StopTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (DoRotate)
		{
			if (LocalAxes)
			{
				if (RotateY)
					transform.Rotate(transform.up, Time.deltaTime * Speed);
				if (RotateX)
					transform.Rotate(transform.right, Time.deltaTime * Speed);
				if (RotateZ)
					transform.Rotate(transform.forward, Time.deltaTime * Speed);
			}
			else
			{
				if (RotateY)
					transform.Rotate(Vector3.up, Time.deltaTime * Speed);
				if (RotateX)
					transform.Rotate(Vector3.right, Time.deltaTime * Speed);
				if (RotateZ)
					transform.Rotate(Vector3.forward, Time.deltaTime * Speed);
			}
			
		}
		
		
		if (StopAfterTime && TimeoutTime > 0 && Time.time > TimeoutTime)
		{
			DoRotate = false;
			TimeoutTime = -1;
		}
	}
}
