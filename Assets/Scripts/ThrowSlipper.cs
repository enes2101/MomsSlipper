using UnityEngine;
using DG.Tweening;
using DG;

public class TerlikFirlatma : MonoBehaviour
{
    public GameObject terlikPrefab; // F�rlat�lacak terlik objesi
    public Transform kol; // Kolun oldu�u bo� nesne
    public Transform hedef; // �ocu�un oldu�u hedef nesne
    public float firlatmaGucu = 5f; // Terli�in f�rlatma h�z�

    private bool terlikFirlatildi = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirlatTerlik();
        }
    }

    private void FirlatTerlik()
    {
        GameObject terlik = Instantiate(terlikPrefab, kol.position, Quaternion.identity);
        Rigidbody rb = terlik.GetComponent<Rigidbody>();

        Vector3 firlatmaYonu = (hedef.position - kol.position).normalized;
        rb.transform.DOJump(hedef.position, 1, 1, 1).SetEase(Ease.InCubic);
    }

    //// koldan hedefe sar� bir �izgi �eker

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawLine(kol.position, hedef.position);
    //}
}
