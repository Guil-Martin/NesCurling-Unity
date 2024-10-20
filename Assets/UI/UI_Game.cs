using UnityEngine;

public class UI_Game : MonoBehaviour
{

    public GameObject capsule;
    public GameObject spawnPoint;

    public void btn_spawn_on_click()
    {
        if (capsule != null)
        {
            float y = Random.Range(0.5f, 2.0f);
            Vector3 spawnPosition = new(0, y, 0);

            Instantiate(capsule, spawnPoint.transform.position + spawnPosition, Quaternion.identity);
        }
    }
}
