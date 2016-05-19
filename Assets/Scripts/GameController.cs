using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform enemy;
    public int enemyCount;

//	Rigidbody2D myRB;

    public int mapX1;
    public int mapX2;
    public int mapY1;
    public int mapY2;


    // Use this for initialization
    void Start()
    {
//		myRB = GetComponent<Rigidbody2D>();
        for (int i = 1; i < enemyCount; i++)
            Instantiate(enemy, new Vector2(Random.Range(mapX1, mapX2), Random.Range(mapY1, mapY2)), enemy.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene(0);
		if (Input.GetKeyUp (KeyCode.LeftControl)) 
		{
			if (SpaceShipControl.immortal == true)
				SpaceShipControl.immortal = false;
			else
				SpaceShipControl.immortal = true;

		}
//		Debug.Log (GameObject.Find("SpaceShip1").GetComponent<Rigidbody2D>().velocity);

    }
}