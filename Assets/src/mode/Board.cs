using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Move_info {
    int x;
    int y;
    public Move_info(int x, int y) {
        this.x = x;
        this.y = y;
    }
}
public class Board
{
    public Piece[,] board;

    public Board()
    {
        board = new Piece[GameManager.BOARD_LENGTH, GameManager.BOARD_WIDTH];
    }
    public void init()
    {
        resetBoard();
    }

    private void resetBoard()
    {
        for (int i = 0; i < GameManager.BOARD_LENGTH; i++)
        {
            for (int j = 0; j < GameManager.BOARD_LENGTH; j++)
            {
                board[i, j] = null;
            }
        }
        board[0, 0] = new Rook  (0, 0, true);
        board[0, 1] = new Knight(0, 1, true);
        board[0, 2] = new Bishop(0, 2, true);
        board[0, 3] = new Queen (0, 3, true);
        board[0, 4] = new King  (0, 4, true);
        board[0, 5] = new Bishop(0, 5, true);
        board[0, 6] = new Knight(0, 6, true);
        board[0, 7] = new Rook  (0, 7, true);
        for (int i = 0; i < GameManager.BOARD_WIDTH; i++)
        {
            board[1, i] = new Pawn(1, i, true);
        }

        board[7, 0] = new Rook  (0, 0, false);
        board[7, 1] = new Knight(0, 1, false);
        board[7, 2] = new Bishop(0, 2, false);
        board[7, 3] = new Queen (0, 3, false);
        board[7, 4] = new King  (0, 4, false);
        board[7, 5] = new Bishop(0, 5, false);
        board[7, 6] = new Knight(0, 6, false);
        board[7, 7] = new Rook  (0, 7, false);
        for (int i = 0; i < GameManager.BOARD_WIDTH; i++)
        {
            board[6, i] = new Pawn(6, i, false);
        }
    }

    public Piece[,] getBoard() {
        return board;
    }
}
