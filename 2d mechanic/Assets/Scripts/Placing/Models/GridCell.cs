

public class GridCell 
{
    public float centerX;
    public float centerY;
    public bool IsOccupied;

    public GridCell(float x, float y, bool IsOccupied)
    {
        this.centerX = x;
        this.centerY = y;
        this.IsOccupied = IsOccupied;
    }
}
