using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateChickens : MonoBehaviour
{

    public GameObject chicken;
    List<GameObject> chickens;
    public int nbChickens;
    public int nbChickensFirstIsland = 10;
    public int nbChickensSecondIsland = 10;
    public int nbChickensThirdIsland = 10;


    public static Vector3 location;

    private const float valueY = 10.21f;


    // Start is called before the first frame update
    void Start()
    {
        chicken = Resources.Load("chicken") as GameObject;

        chickens = new List<GameObject>();


        GenerateFirstIsland();
        GenerateSecondIsland();
        GenerateThirdIsland();

    }

    // Update is called once per frame
    void Update()
    {
        chickens.RemoveAll(GameObject => GameObject == null);
        nbChickens = chickens.Count;
        //print(nbChickens);
    }

    void GenerateFirstIsland()
    {
        for (int i = 0; i <= nbChickensFirstIsland; i++)
        {
            location = new Vector3(Random.Range(127.0f, 172.0f), valueY, Random.Range(40.0f, 131.0f));
            AddToList();
        }
    }
    void GenerateSecondIsland()
    {
        for (int i = 0; i <= nbChickensSecondIsland; i++)
        {
            location = new Vector3(Random.Range(-176.0f, -110.0f), valueY, Random.Range(87.0f, 161.0f));
            AddToList();
        }
    }
    void GenerateThirdIsland()
    {
        for (int i = 0; i <= nbChickensThirdIsland; i++)
        {
            location = new Vector3(Random.Range(-63.0f, -46.0f), valueY, Random.Range(-123.0f, -92.0f));
            AddToList();
        }
    }

    void AddToList()
    {
        chickens.Add((GameObject)Instantiate(chicken, location, Quaternion.Euler(0, 0, 0)));
    }
}
