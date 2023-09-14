using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    [SerializeField]
    public GameObject PipePrefab;

    private float SpawRate = 1f;
    private float MAX_HEIGHT_PIPE = 2.50F;
    private float MIN_HEIGHT_PIPE = -1.18F;

    private void OnEnable()
    {
        InvokeRepeating(nameof(GenerateNewPipe), SpawRate, SpawRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(GenerateNewPipe));
    }

    void GenerateNewPipe()
    {
        GameObject pipes = Instantiate(PipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(MIN_HEIGHT_PIPE, MAX_HEIGHT_PIPE);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
