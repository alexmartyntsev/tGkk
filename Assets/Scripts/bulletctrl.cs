using UnityEngine;

public class bulletctrl : MonoBehaviour {
	Rigidbody2D puf;
	public float pufSpeed;
	public float pufLifetime;
	public int damage = 1;
    int score = 0;
	Vector3 vel;

	// Use this for initialization
	void Start () {
////		if (vel >= new Vector3 (0, 0, 0))
		vel = SpaceShipControl.velX;
//		else
//			vel = -1 * vel;
//		velX = ;
		Destroy (gameObject, pufLifetime);
		puf = GetComponent<Rigidbody2D> ();
		puf.AddForce (transform.right * pufSpeed + vel, ForceMode2D.Impulse);
	}
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
        //EnemyController shot = otherCollider.gameObject.GetComponent<EnemyController> ();
        if (otherCollider.gameObject.name.Contains("EnemyOf"))
        {
            Destroy(gameObject);
            score = score + damage;
        }

	}
    
	
	// Update is called once per frame
	void Update () {
//        Debug.Log(score);    
    }
}
