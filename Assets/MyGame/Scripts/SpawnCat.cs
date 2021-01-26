using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCat : MonoBehaviour
{
    public GameObject prefabCat;
    public GameObject parentGo;

    private float spawnRate = 4f;
    private float nextSpawn = 4f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTheCats();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            spawnRate = Random.Range(1f, 10f);
            nextSpawn = Time.time + spawnRate;
            Debug.Log("nextspan" + spawnRate);
            SpawnTheCats();
        }
    }

    private void SpawnTheCats()
    {
        var clones = Instantiate(prefabCat);
        clones.GetComponent<Transform>().SetParent(parentGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
