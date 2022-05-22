using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [HideInInspector] public SpriteRenderer Target;
    [SerializeField] private Color _targetColor;
    private Color _startColor;
    float color = 0.5f;
    private void Start()
    {
        Target = GetComponent<SpriteRenderer>();
        _startColor = Target.color;
    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime,0,0);
            color -= 0.05f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            color += 0.05f * Time.deltaTime;
        }

        Target.color = Color.Lerp(_startColor, _targetColor, color);
    }
}
