using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateApples : MonoBehaviour { 

    public GameObject apple;
    List<GameObject> apples;
    public int nbApples;
    public int nbApplesFirstIsland = 10;
    public int nbApplesSecondIsland = 10;
    public int nbApplesThirdIsland = 10;


    public static Vector3 location;

    private const float valueY = 10.21f;


    // Start is called before the first frame update
    void Start()
    {
        apple = Resources.Load("apple") as GameObject;

        apples = new List<GameObject>();


        GenerateFirstIsland();
        GenerateSecondIsland();
        GenerateThirdIsland();

    }

    // Update is called once per frame
    void Update()
    {
        apples.RemoveAll(GameObject => GameObject == null);
        nbApples = apples.Count;
        //print(nbApples);
    }

    void GenerateFirstIsland()
    {
        for (int i = 0; i <= nbApplesFirstIsland; i++)
        {
            location = new Vector3(Random.Range(127.0f, 172.0f), valueY, Random.Range(40.0f, 131.0f));
            AddToList();
        }
    }
    void GenerateSecondIsland()
    {
        for (int i = 0; i <= nbApplesSecondIsland; i++)
        {
            location = new Vector3(Random.Range(-176.0f, -110.0f), valueY, Random.Range(87.0f, 161.0f));
            AddToList();
        }
    }
    void GenerateThirdIsland()
    {
        for (int i = 0; i <= nbApplesThirdIsland; i++)
        {
            location = new Vector3(Random.Range(-63.0f, -46.0f), valueY, Random.Range(-123.0f, -92.0f));
            AddToList();
        }
    }

    void AddToList()
    {
        apples.Add((GameObject)Instantiate(apple, location, Quaternion.Euler(0, 0, 0)));
    }
}
