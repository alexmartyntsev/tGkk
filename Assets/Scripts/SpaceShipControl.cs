using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShipControl : MonoBehaviour
{
    public static bool immortal = false;
	public float hp;
    public float lineSpeed;
    public float rotateSpeed;
    public float friction;
    public Transform bullet;
    public float shootTime;
    float sT;
    public float yCorrection = 0.475f;
	public SpriteRenderer sh = null;
	float yOfVel;
    Rigidbody2D player;

	public static Vector3 velX;

    // Use this for initialization
    void Start()
    {
		
        sT = 0;
		player = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
	void Update()
	{
		yOfVel = GameObject.Find ("SpaceShip1").GetComponent<Rigidbody2D> ().velocity.y;
		if (yOfVel <= 0)
//			yOfVel = yOfVel * -1;
			yOfVel = 0;
		
		velX = new Vector3 (0, yOfVel, 0);

		if (immortal) {
			var cc = sh.color;
			cc = new Color(255,0,0,255);
			sh.color = cc;
		} 
		else 
		{
			var cc = sh.color;
			cc = new Color(255,255,255,255);
			sh.color = cc;	
		}	
	}

	void FixedUpdate()
    {
		
		sT = sT + Time.deltaTime;


        if (Input.GetKey(KeyCode.UpArrow))
            player.AddForce(transform.up * lineSpeed, ForceMode2D.Impulse);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.AddRelativeForce(-transform.up * lineSpeed * friction, ForceMode2D.Impulse);
        }

        //		player.AddTorque (-Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime);
        

        player.AddForce(transform.right * Input.GetAxis("Horizontal") * rotateSpeed, ForceMode2D.Impulse);

        if (Input.GetKey(KeyCode.Space) && sT > shootTime)
        {
            Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + yCorrection), bullet.rotation);
            sT = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
       // EnemyController shot = otherCollider.gameObject.GetComponent<EnemyController>();
		if (otherCollider.gameObject.name.Contains ("EnemyOf") && !immortal) {
			if (hp < 1)
				SceneManager.LoadScene ("GameOver");
			else {
				
				hp = hp - 1;
			}
		}
    }
}
