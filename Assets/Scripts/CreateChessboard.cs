using UnityEngine;

public class CreateChessboard : MonoBehaviour
{



    #if UNITY_EDITOR
    private void OnDrawGizmos(){

        Gizmos.color = Color.white;
        //Gizmos.DrawWireCube(transform.position, new Vector3(8f, 8f, 0f));

        for (int i = -4; i <= 4; i++)
        {
            Gizmos.DrawLine(new Vector3(-4f, i, 0f), new Vector3(4f, i, 0f));
            Gizmos.DrawLine(new Vector3(i, -4f, 0f), new Vector3(i, 4f, 0f));
        }

        //Gizmos.color = Color.grey;
        Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.25f);

        for (float i = -3.5f; i<= 2.5; i = i + 2)
        {
            for (float j = -3.5f; j <= 2.5; j = j + 2)

                Gizmos.DrawCube(new Vector3(i, j, 0f), new Vector3(1f, 1f, 0f));
        }

        for (float i = -2.5f; i <= 3.5; i = i + 2)
        {
            for (float j = -2.5f; j <= 3.5; j = j + 2)

                Gizmos.DrawCube(new Vector3(i, j, 0f), new Vector3(1f, 1f, 0f));

        }


    }
#endif

}
