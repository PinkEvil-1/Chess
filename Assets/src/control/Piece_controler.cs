using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_controler : MonoBehaviour
{
    // Start is called before the first frame update
    private int x;
    private int y;
    GameManager game_manger;
    void Start()
    {
        GameObject go = GameObject.Find("GameManager");
        if (go == null) {
            Debug.Log("don't find GameManager this gameObject");
            return;
        }
        game_manger = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        game_manger.pieceSelect(x, y);
    }

    public void setXY(int x, int y) {
        this.x = x;
        this.y = y;
    }
}
