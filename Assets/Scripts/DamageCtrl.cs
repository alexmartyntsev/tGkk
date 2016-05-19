using UnityEngine;

public class DamageCtrl : MonoBehaviour {

	public int hp = 1;
	public void Damage(int damageCount)
	{
		hp -= damageCount;

		if (hp <= 0)
			Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		bulletctrl shot = otherCollider.gameObject.GetComponent<bulletctrl> ();
		if (shot != null) {
			Damage (shot.damage);
		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
