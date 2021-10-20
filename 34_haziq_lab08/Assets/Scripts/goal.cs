using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal : MonoBehaviour
{
    private int score;
    public GameObject scoretext;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext.GetComponent<Text>().text = "score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = "score " + score;
    }
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag.Equals("Obstacle"))
        {
            score++;
            Destroy(collision.gameObject);
        }
    }
}
