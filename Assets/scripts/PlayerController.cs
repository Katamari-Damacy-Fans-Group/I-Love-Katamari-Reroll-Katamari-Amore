using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

using System.Collections;
using System.Threading;

public class PlayerController : MonoBehaviour
{
	public float speed;

	[SerializeField]private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		void FixedUpdate()
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

			rb.AddForce(movement * speed * Time.fixedDeltaTime);
		}
	}
}