using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBricks : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] bricks;
    public GameObject brickPrototype;
    void Start()
    {
        for (int i = -Constants.numCols/2; i < Constants.numCols/2; i++)
        {
            for (int j = -Constants.numRows/2; j < Constants.numRows/2; j++)
            {
                Instantiate(brickPrototype, new Vector3(i, j + 2, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
