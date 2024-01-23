using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public int level = 1;
    public int exp;
    public int baseMaxHp = 54;
    public int baseAttack = 10;
    public int baseDefense = 10;

    public int maxHp;
    public int attack;
    public int defense;

    private int nextLvUp;
    private int prevLvUp;



    // Start is called before the first frame update
    void Start()
    {
        CalculateStats();
    }

    private void CalculateStats()
    {
        prevLvUp = (int)Mathf.Pow(level, 4f);
        nextLvUp = (int)Mathf.Pow(level + 1, 4f);
        maxHp = baseMaxHp + ((int)Mathf.Pow(level, 1.2f) * 10) * (int)Random.Range(0, 10);
        attack = baseAttack + (int)Mathf.Pow(level, 1.15f);
        defense = baseDefense + (int)Mathf.Pow(level, 1.15f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
