using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    //[SerializeField] private GameObject enemyPrefab; 
    public GameObject enemyPrefab;
    private GameObject _enemy;

    public float minimumXCoord = -25;
    public float maximumXCoord = 25;
    public float minimumZCoord = -25;
    public float maximumZCoord = 25;

    private float nextLaunch;
    public float delay;

    void Update()
    {
        if (WanderingAI.counter < 20 && Time.time > nextLaunch)
        {
            float pointX = Random.Range(minimumXCoord, maximumXCoord);
            float pointZ = Random.Range(minimumZCoord, maximumZCoord);

            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(pointX, transform.position.y, pointZ);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            WanderingAI.counter++;
            nextLaunch = Time.time + delay;
        }
    }
}
