using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //get the current screen position of the mouse from inout
        Vector3 mousePos2D = Input.mousePosition;
        //the camera'ss z position ses how far to us the mouse into 3D
        mousePos2D.z = Camera.main.transform.position.z;
        //convert the point fro 2D screen sace into D gameworld space
        Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(mousePos2D);
        //move he x position of this basket
        Vector3 pos = this.transform.position;
        pos.x = mousePos3d.x;
        this.transform.position = pos;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //ind out what hit this basket
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Apple") ;
            {
            Destroy(collidedWith);
        }
        int score = int.Parse(scoreGT.text);
        score += 100;
        scoreGT.text = score.ToString();
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }
}
