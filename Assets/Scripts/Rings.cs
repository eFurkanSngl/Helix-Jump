using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Score _score;
    
    // Start is called before the first frame update
    void Start()
    {
        _score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y -3 >= ball.position.y)
        {
            Destroy(gameObject);
            _score.IncreaseScore(25);
        }
    }
}
