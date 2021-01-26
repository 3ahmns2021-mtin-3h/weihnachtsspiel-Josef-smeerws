using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNuts : MonoBehaviour
{
    public GameObject nutPrefab;
    public GameObject parentSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTheNuts();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheNuts();
        }
    }

    private void SpawnTheNuts()
    {
        var clones = Instantiate(nutPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }
}
