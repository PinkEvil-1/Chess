using System.Collections;
using System.Collections.Generic;
public class GamaContainer
{
    Board board;
    bool is_white_true = true;
    public void init() 
    {
        board = new Board();
        board.init();
    }

    public Piece_info[,] getBoard() {
        Piece_info[,] result = new Piece_info[GameManager.BOARD_LENGTH, GameManager.BOARD_WIDTH];
        Piece[,] pieces = board.getBoard();
        for (int i = 0 ; i < pieces.GetLength(0) ; i++) {
            for (int j = 0 ; j < pieces.GetLength(1) ; j++) {
                if (pieces[i, j] == null) {
                    result[i, j] = null;
                } else {
                    result[i, j] = pieces[i, j].getPieceInfo();
                }
            }
        }
        return result;
    }

    public Dictionary<int, Move_info> selectPiece(int x, int y) {
        Dictionary<int, Move_info> moves = new Dictionary<int, Move_info>();
        
        return moves;
    }
}
