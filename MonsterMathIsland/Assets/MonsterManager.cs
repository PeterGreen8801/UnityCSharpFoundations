using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [SerializeField] private int amountOfMonsters = 10;
    [SerializeField] Transform monsterSpawnPoint;
    [SerializeField] private GameObject[] monsterPrefabs;
    [SerializeField] float waveDifficulty;

    public List<GameObject> monsters;

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < amountOfMonsters; i++)
        {
            int monsterIndex = Random.Range(0, monsterPrefabs.Length);
            GameObject monster = Instantiate(monsterPrefabs[monsterIndex], monsterSpawnPoint.position, monsterSpawnPoint.rotation);
            monsters.Add(monster);
        }

        waveDifficulty = CalculateWaveDifficulty();
    }

    float CalculateWaveDifficulty()
    {
        float difficulty = 0;
        foreach (GameObject monster in monsters)
        {
            difficulty += monster.GetComponent<Points>().points;
        }

        difficulty /= (amountOfMonsters * 3);
        return difficulty;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
