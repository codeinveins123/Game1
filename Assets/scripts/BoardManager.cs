using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public class CellData
   {
    public bool Passable;
   }
    private Tilemap m_Tilemap;
    private CellData[,] m_BoardData;
    private Grid m_Grid;

    public int Width;
    public int Height;
    public Tile[] GroundTiles;
    public Tile[] WallTiles;
    public PlayerController Player;
    public void Init()
    {
        Debug.Log("Board Manager Start");
        m_Tilemap = GetComponentInChildren<Tilemap>();
        m_Grid = GetComponentInChildren<Grid>();
        m_BoardData = new CellData[Width, Height];

        for(int y = 0; y < Height; y++)
        {
            for(int x = 0; x < Width; x++)
            {
                m_BoardData[x, y] = new CellData();
                Tile tile;
                if(x == 0 || x <= (Width - 1) / 2 && (y == 0 || y == Height - 1))
                {
                    tile = WallTiles[0];
                    m_BoardData[x, y].Passable = false;
                }
                else if(x == Width - 1 || x > (Width - 1) / 2 && (y == 0 || y == Height - 1))
                {
                    tile = WallTiles[1];
                    m_BoardData[x, y].Passable = false;
                }
                else
                {
                    tile = GroundTiles[Random.Range(0, GroundTiles.Length)];
                    m_BoardData[x, y].Passable = true;
                }
                m_Tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }
    }

    public Vector3 CellToWorld(Vector2Int cellIndex)
    {
        return m_Grid.GetCellCenterWorld((Vector3Int)cellIndex);
    }

    public CellData GetCellData(Vector2Int cellIndex)
    {
        if (cellIndex.x < 0 || cellIndex.x >= Width || cellIndex.y < 0 || cellIndex.y >= Height)
            return null;

        return m_BoardData[cellIndex.x, cellIndex.y];
    }
}
