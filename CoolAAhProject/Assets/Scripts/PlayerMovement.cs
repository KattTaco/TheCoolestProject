using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Vector2 Movement = new Vector2 (0, 0);
	[SerializeField] float PlayerSpeed = 5;
	public float upperLimitY;
	public float lowerLimitY;
	public float upperLimitX;
	public float lowerLimitX;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.W))
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y+ PlayerSpeed, lowerLimitY, upperLimitY), gameObject.transform.position.z);
			//gameObject.GetComponent<SpriteRenderer>().sprite = back;
			//GetComponent<AudioSource>().Play();
		}
		if (Input.GetKey(KeyCode.S))
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y - PlayerSpeed, lowerLimitY, upperLimitY), gameObject.transform.position.z);
			//gameObject.GetComponent<SpriteRenderer>().sprite = front;
			//GetComponent<AudioSource>().Play();
		}
		if (Input.GetKey(KeyCode.A))
		{
			gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x - PlayerSpeed, lowerLimitX, upperLimitX), gameObject.transform.position.y, gameObject.transform.position.z);

			//gameObject.GetComponent<SpriteRenderer>().sprite = left;
			//GetComponent<AudioSource>().Play();
		}
		if (Input.GetKey(KeyCode.D))
		{
			gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x+ PlayerSpeed, lowerLimitX, upperLimitX), gameObject.transform.position.y, gameObject.transform.position.z);
			//gameObject.GetComponent<SpriteRenderer>().sprite = right;
			//GetComponent<AudioSource>().Play();
		}
		
	}
}
