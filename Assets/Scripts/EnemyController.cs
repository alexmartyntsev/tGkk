using UnityEngine;

	public class EnemyController : MonoBehaviour {
//	public GameObject player;

	Rigidbody2D enemy;
	// Use this for initialization
	void Start () {
	
		enemy = GetComponent<Rigidbody2D> ();
		enemy.AddForce (new Vector2 (Random.Range (-100f, 100f), Random.Range (-100f, 100f)));
//		enemy.AddRelativeForce
	}
	
	// Update is called once per frame
	void Update () {
//		transfor.LookAt (player);
	}
}
