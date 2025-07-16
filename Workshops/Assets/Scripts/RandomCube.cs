using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;


public class RandomCube : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    private List<GameObject> gameObjectsList;
    private int whichNumber;
    private int rnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rnd = Random.Range(1, 4);

        gameObjectsList = new List<GameObject>();
        gameObjectsList.Add(cube1);
        gameObjectsList.Add(cube2);
        gameObjectsList.Add(cube3);
    }

    // Update is called once per frame
    public void Cube1Button()
    {
        whichNumber = 1;
        WhichCubeIsCorrect(whichNumber);
    }

    public void Cube2Button()
    {
        whichNumber = 2;
        WhichCubeIsCorrect(whichNumber);
    }

    public void Cube3Button()
    {
        whichNumber = 3;
        WhichCubeIsCorrect(whichNumber);
    }

    void WhichCubeIsCorrect(int whichNumber)
    {
        var text = GetComponent<TextMeshProUGUI>();
        if (whichNumber == rnd) 
        {
            text.text = "YOU WIN";
        }
        else
        {
            text.text = "YOU LOSE";
        }
        for (int i = 0; i < 3; i++)
        {
            if (i != rnd - 1)
            {
                gameObjectsList[i].GetComponent<Rigidbody>().useGravity = true;
            }
        }

    }
}
