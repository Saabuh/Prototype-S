using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace Prototype_S
{
    public class MapGenerator : MonoBehaviour
    {
        [SerializeField] private int mapWidth;
        [SerializeField] private int mapHeight;
        [SerializeField] private float scale;

        [SerializeField] private Tilemap terrainMap; // Reference to the Tilemap
        [SerializeField] private Tilemap waterMap; // Reference to the Tilemap
        [SerializeField] private TileBase waterTile; // Tile for water
        [SerializeField] private TileBase grassTile; // Tile for grass
        [SerializeField] private TileBase sandTile; // Tile for mountains

        [ContextMenu("Generate Map")]
        public void GenerateMap()
        {
            terrainMap.ClearAllTiles();
            waterMap.ClearAllTiles();
            
            float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, scale);

            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    Tilemap selectedTileMap;
                    TileBase selectedTile;
                    
                    switch (noiseMap[x, y])
                    {
                        case < 0.25f:
                            selectedTile = waterTile;
                            selectedTileMap = waterMap;
                            break;
                        case < 0.35f:
                            selectedTile = sandTile;
                            selectedTileMap = terrainMap;
                            break;
                        default:
                            selectedTile = grassTile;
                            selectedTileMap = terrainMap;
                            break;
                    }
                    
                    selectedTileMap.SetTile(new Vector3Int(x, y, 0), selectedTile);
                }
            }
            
        }

    }
}
