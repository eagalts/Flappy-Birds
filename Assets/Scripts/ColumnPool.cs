using UnityEngine;

public class ColumnPool : MonoBehaviour
{

	public int columnPoolSize = 5;
	public GameObject columnPrefab;
	public float columnSpawnRate = 4f;
	public float columnMinYPosition = -1.5f;
	public float columnMaxYPosition = 2.5f;

	private GameObject[] columns;
	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawn = 4f;
	private float columnSpawnXPosition = 10f;
	private int currentColumn = 0;

	void Start ()
	{
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++)
		{
			columns [i] = (GameObject)Instantiate (columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}

	void Update ()
	{
		timeSinceLastSpawn += Time.deltaTime;

		if (!Global.global.gameOver && timeSinceLastSpawn >= columnSpawnRate)
		{
			timeSinceLastSpawn = 0f;
			float columnSpawnYPosition = Random.Range (columnMinYPosition, columnMaxYPosition);
			columns [currentColumn].transform.position = new Vector2 (columnSpawnXPosition, columnSpawnYPosition);
			currentColumn++;
			if (currentColumn >= columnPoolSize)
			{
				currentColumn = 0;
			}
		}
	}
}
