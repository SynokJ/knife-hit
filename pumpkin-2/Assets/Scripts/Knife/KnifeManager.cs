using System.Collections;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    [SerializeField] private Knife _knifePref;
    [SerializeField] private Transform _originPoint;

    private void Start()
    {
        SpawnKnife();
    }

    public void SpawnKnife()
    {
        StartCoroutine(SpawnWithDelay());
    }

    IEnumerator SpawnWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        Knife knife = Instantiate(_knifePref, _originPoint.position, Quaternion.identity);
        knife.OnKnifeDashed += SpawnKnife;
    }
}
