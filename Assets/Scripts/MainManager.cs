using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    #region Singleton

    public static MainManager instance;

    void Awake()
    {
        instance = this;
        player = GameObject.FindGameObjectWithTag(playerTag);
        canPlayerMove = true;
    }
    #endregion



    private void Update()
    {
        /*if (Input.GetKeyUp(KeyCode.M))
        {
            canPlayerMove = !canPlayerMove;
        }*/
    }

    private GameObject player;

    [SerializeField] private string playerTag;

    [SerializeField] private string[] enemyTags;

    [SerializeField] private string mainPostProcessingTag;

    //A bool which controls if the player can move their camera
    //and if they can phyiscally move
    public bool canPlayerMove { get; set; }

    public bool isGamePaused { get; set; }

    public GameObject GetPlayer()
    {
        return player;
    }

    public string GetPlayerTag()
    {
        return playerTag;
    }

    public string[] GetEnemyTags()
    {
        return enemyTags;
    }

    public string GetMainPostProcessingTag()
    {
        return mainPostProcessingTag;
    }
}
