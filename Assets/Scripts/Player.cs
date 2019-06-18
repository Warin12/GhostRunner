using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    [SerializeField] public float Ymove;
    [SerializeField] public float speed;
    [SerializeField] public float maxHeight;
    [SerializeField] public float minHeight;
    [SerializeField] public int health = 3;

    public Text healthDisplay;

    public GameObject gameOver;


    private void Update()
    {
        healthDisplay.text = health.ToString();
        
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
         
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Ymove);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Ymove);
        }
    }
}
