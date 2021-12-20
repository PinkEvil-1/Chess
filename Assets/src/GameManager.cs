using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int BOARD_LENGTH = 8;
    public static int BOARD_WIDTH = 8;

    private GamaContainer game_container;
    private ChessView view;
    void Start()
    {
        game_container = new GamaContainer();
        game_container.init();

        //view = new ChessView();
        view = gameObject.AddComponent<ChessView>() as ChessView;
        view.init();
        view.draw(game_container.getBoard());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pieceSelect(int x, int y) {

    }
}
