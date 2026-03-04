using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float _Vida;
    public float _Speed;
    public bool _Shield;
    public float _DamageBoost;
    
    void Awake()
    {
        _Vida=1;
        _Speed = 1.0f;
        _Shield = false;
        _DamageBoost = 1;

    }

    public void _CaminodelaGrulla (float valor)
    {
        
        _Vida += valor;

    }

    public void _CaminodelaSerpiente (float valor)
    {
        
        _Speed += valor;

    }

    public void _CaminodelAguila (float valor)
    {
        if (valor > 0) 
        {
        _Shield = true;
        }
        else
        {
        _Shield = false;
        }
        

    }

    public void _CaminodelTigre(float valor)
    {
        
        _DamageBoost = valor;

    }



    // Update is called once per frame
    
}
