using UnityEngine;

public class PrefabCollider : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();  // GameManager referansını al
    }

    // Çarpışma gerçekleştiğinde çağrılır
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple") || other.CompareTag("Cube"))  // Eşleşen tag'lere bak
        {
            if (gm.One == null)
            {
                gm.One = this.gameObject;  // Eğer One null ise, bu nesneyi One olarak ata
            }
            else if (gm.Two == null)
            {
                gm.Two = this.gameObject;  // Eğer Two null ise, bu nesneyi Two olarak ata
            }
        }
    }
}
