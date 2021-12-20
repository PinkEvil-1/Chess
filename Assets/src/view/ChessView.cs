using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPosition {
    public float x;
    public float y;
    public CellPosition (float x, float y) {
        this.x = x;
        this.y = y;
    }
}
public class ChessView : MonoBehaviour 
{
    private float begin_x = -5.25f;
    private float begin_y = 5.25f;
    private CellPosition[,] cells_position;
    Dictionary<string, string> black_piece_name;
    Dictionary<string, string> white_piece_name;
    //public GameObject[] black_piece = new GameObject[6];

    public void init() 
    {
        cells_position = new CellPosition[GameManager.BOARD_WIDTH, GameManager.BOARD_LENGTH];
        for (int i = 0 ; i < GameManager.BOARD_WIDTH ; i++) {
            for (int j = 0 ; j < GameManager.BOARD_LENGTH ; j++) {
                cells_position[i, j] = new CellPosition(begin_x + (i * 1.5f), begin_y - (j * 1.5f));
            }
        }

        black_piece_name = new Dictionary<string, string>();
        white_piece_name = new Dictionary<string, string>();

        black_piece_name.Add("Bishop", "black/Black Bishop");
        black_piece_name.Add("King"  , "black/Black King");
        black_piece_name.Add("Knight", "black/Black Knight");
        black_piece_name.Add("Pawn"  , "black/Black Pawn");
        black_piece_name.Add("Queen" , "black/Black Queen");
        black_piece_name.Add("Rook"  , "black/Black Rook");

        white_piece_name.Add("Bishop", "white/White Bishop");
        white_piece_name.Add("King"  , "white/White King");
        white_piece_name.Add("Knight", "white/White Knight");
        white_piece_name.Add("Pawn"  , "white/White Pawn");
        white_piece_name.Add("Queen" , "white/White Queen");
        white_piece_name.Add("Rook"  , "white/White Rook");
    }

    public void draw(Piece_info[,] pieces_info) {
        for (int x = 0 ; x < pieces_info.GetLength(0) ; x++) {
            for (int y = 0 ; y < pieces_info.GetLength(1) ; y++) {
                if (pieces_info[x, y] == null) {
                    continue;
                }
                Piece_info info = pieces_info[x, y];
                bool isWhite = info.getIsWhite();
                string type = info.getType();
                string path = "";

                ref Dictionary<string, string> piece_dic = ref black_piece_name;
                if (isWhite) {
                    piece_dic = ref white_piece_name;
                }
                switch (type) {
                    case "Bishop":
                        path = piece_dic["Bishop"];
                        break;
                    case "King":
                        path = piece_dic["King"];
                        break;
                    case "Knight":
                        path = piece_dic["Knight"];
                        break;
                    case "Pawn":
                        path = piece_dic["Pawn"];
                        break;
                    case "Queen":
                        path = piece_dic["Queen"];
                        break;
                    case "Rook":
                        path = piece_dic["Rook"];
                        break;
                }
                Object obj = Resources.Load("gameObject/chessPiece/" + path);
                GameObject gobj = Instantiate(obj) as GameObject;
                gobj.transform.position = new Vector3(cells_position[x, y].x, 0.2f, cells_position[x, y].y);
                Piece_controler control = gobj.GetComponent<Piece_controler>();
                control.setXY(x, y);
            }
        }
    }
}
