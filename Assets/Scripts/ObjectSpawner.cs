using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefabBoard;
    [SerializeField] private GameObject objectPrefabPlayer;
    [SerializeField] private GameObject objectPrefabBall;
    [SerializeField] private float boardWidth = 10f;
    [SerializeField] private float boardHeight = 5f;
    [SerializeField] private float objectSpacing = 0.5f;



    void Start()
    {
        GameObject board = Instantiate(objectPrefabBoard);
        board.transform.position = Vector3.zero;

        GameObject ball = Instantiate(objectPrefabBall);
        ball.transform.position = Vector3.zero;

        GameObject player = Instantiate(objectPrefabPlayer);
        player.transform.position = new Vector3(-boardWidth / 2 + objectSpacing, 0, 0);

        GameObject secondPlayer = Instantiate(objectPrefabPlayer);
        secondPlayer.transform.position = new Vector3(boardWidth / 2 - objectSpacing, 0, 0);

    }


}
