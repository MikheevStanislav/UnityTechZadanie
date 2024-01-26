using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesGenerater : MonoBehaviour
{
    public float velocity;              
    public float deltaTime;             
    public GameObject cube;             
    public float endDistance;           
    private List<GameObject> cubes;     
    private float timer;                
    private int counter = 0;            

    public static CubesGenerater Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        cubes = new List<GameObject>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > deltaTime)
        {
            GameObject cube2 = Instantiate(cube);

            cube2.name = "Cube " + counter;
            counter++;
            cubes.Add(cube2);
            timer = 0f;
        }

        for (int i = cubes.Count - 1; i >= 0; i--)
        {
            GameObject x = cubes[i];
            x.transform.position += new Vector3(Time.deltaTime * velocity, 0, 0);
            if (x.transform.position.x >= endDistance)
            {
                Destroy(x);
                cubes.RemoveAt(i);
            }
        }
    }
}
