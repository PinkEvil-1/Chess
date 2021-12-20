using System.Collections;
using System.Collections.Generic;

public class Piece_info {
    private bool is_white = true;
    private string piece_type = "";

    public Piece_info(bool is_white, string piece_type) {
        this.is_white = is_white;
        this.piece_type = piece_type;
    }
    public bool getIsWhite() {
        return is_white;
    }
    public string getType() {
        return piece_type;
    }
}

public class Piece
{
    public bool is_white = true;
    public int x = 0;
    public int y = 0;
    protected string piece_type = "";

    public Piece()
    {

    }
    public Piece(int x, int y, bool is_white)
    {
        this.x = x;
        this.y = y;
        this.is_white = is_white;
    }

    public string getType() {
        return piece_type;
    }

    public Piece_info getPieceInfo() {
        Piece_info info = new Piece_info(is_white, piece_type);
        return info;
    }
}

public class Pawn : Piece
{

    public Pawn(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "Pawn";
    }
}

public class Bishop : Piece
{
    public Bishop(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "Bishop";
    }
}
public class King : Piece
{
    public King(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "King";
    }
}
public class Knight : Piece
{
    public Knight(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "Knight";
    }
}
public class Queen : Piece
{
    public Queen(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "Queen";
    }
}
public class Rook : Piece
{
    public Rook(int x, int y, bool is_white) : base(x, y, is_white)
    {
        piece_type = "Rook";
    }
}
