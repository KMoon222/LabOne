using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PieceMovement : MonoBehaviour
{



    [ColorUsage(true, true)]
    public Color pieceColor;

    SpriteRenderer spriteRenderer;


    SpriteRenderer GetSpriteRenderer()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        return spriteRenderer;
    }

    enum PieceTypes
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        King,
        Queen
    }

    [SerializeField] private PieceTypes PieceType;

    [Header("Sprites")]
    public Sprite pawnS;
    public Sprite rookS;
    public Sprite knightS;
    public Sprite bishopS;
    public Sprite kingS;
    public Sprite queenS;


#if UNITY_EDITOR




    private void OnDrawGizmosSelected()
    {


        GetSpriteRenderer();


        Gizmos.color = new Color(0f, 0f, 1f, 0.9f);

        if (PieceType == PieceTypes.Pawn)
        {
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, 1f, 0), new Vector3(1f, 1f, 0f));
        }
        else if (PieceType == PieceTypes.Rook)
        {
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, 4f, 0), new Vector3(1f, 7f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, -4f, 0), new Vector3(1f, 7f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(4f, 0, 0), new Vector3(7f, 1f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(-4f, 0, 0), new Vector3(7f, 1f, 0f));

        }
        else if (PieceType == PieceTypes.Knight)
        {
            for (int i = -2; i <= 2; i = i + 4)
            {
                for (int j = -1; j <= 1; j = j + 2)
                {
                    Gizmos.DrawCube(gameObject.transform.position + new Vector3(j, i, 0), new Vector3(1f, 1f, 0f));
                    Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, j, 0), new Vector3(1f, 1f, 0f));
                }
            }
        }
        else if (PieceType == PieceTypes.Bishop)
        {
            for (int i = 1; i <= 7; i++)
            {
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(-i, i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, -i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(-i, -i, 0), new Vector3(1f, 1f, 0f));

            }
        }
        else if (PieceType == PieceTypes.King)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j = j + 2)
                {
                    Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, j, 0), new Vector3(1f, 1f, 0f));
                    Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, j, 0), new Vector3(1f, 1f, 0f));
                    Gizmos.DrawCube(gameObject.transform.position + new Vector3(j, 0, 0), new Vector3(1f, 1f, 0f));
                }
            }
        }
        else if (PieceType == PieceTypes.Queen)
        {
            for (int i = 1; i <= 7; i++)
            {
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(-i, i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(i, -i, 0), new Vector3(1f, 1f, 0f));
                Gizmos.DrawCube(gameObject.transform.position + new Vector3(-i, -i, 0), new Vector3(1f, 1f, 0f));
            }
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, 4f, 0), new Vector3(1f, 7f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(0, -4f, 0), new Vector3(1f, 7f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(4f, 0, 0), new Vector3(7f, 1f, 0f));
            Gizmos.DrawCube(gameObject.transform.position + new Vector3(-4f, 0, 0), new Vector3(7f, 1f, 0f));

        }
    }



    private void OnValidate()
    {
        GetSpriteRenderer();

        spriteRenderer.color = pieceColor;


        switch (PieceType)
        {
            case PieceTypes.Pawn:
                spriteRenderer.sprite = pawnS;
                break;
            case PieceTypes.Rook:
                spriteRenderer.sprite = rookS;
                break;
            case PieceTypes.Bishop:
                spriteRenderer.sprite = bishopS;
                break;
            case PieceTypes.Knight:
                spriteRenderer.sprite = knightS;
                break;
            case PieceTypes.King:
                spriteRenderer.sprite = kingS;
                break;
            case PieceTypes.Queen:
                spriteRenderer.sprite = queenS;
                break;
        }


    }

#endif



    public void OnSceneGUI()
    {
         Handles.PositionHandle(transform.position, transform.rotation);

    }
    





}













