using UnityEngine;

public class DestroyAndInstantiate : MonoBehaviour
{
    public GameObject EnemySlot; 
     private void OnTriggerEnter2D(Collider2D  other)
    {
        Debug.Log($"EnemySlot active status: {EnemySlot.activeSelf}");
         EnemySlot.SetActive(true);
    }

   

}
