using FPS.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Parameters
    [SerializeField]
    private float ExplosionRadius = 1;
    public float Radius { get { return ExplosionRadius; } set { ExplosionRadius = value; } }
    [SerializeField]
    private float ExplosionDamage = 1;
    public float Damage { get { return ExplosionDamage; } set { ExplosionDamage = value; } }
    [SerializeField]
    private float ExplosionTime = 1;
    public float ExplosionPeriod { get { return ExplosionTime; } set { ExplosionTime = value; } }
    [SerializeField]
    private ExplosiveDamageType ExplosionDamageType = ExplosiveDamageType.Fixed;
    public ExplosiveDamageType DamageType { get { return ExplosionDamageType; } set { ExplosionDamageType = value; } }

    // Objects
    [SerializeField]
    private SphereCollider AreaCollider;
    [SerializeField]
    private MeshRenderer AreaRenderer;


    // Variables
    public bool DirectHit { get; internal set; }
    public bool Exploding { get; internal set; }
    public float ExplosionTimer { get; internal set; }
    public Vector3 ExplosionHit { get; set; }

    private void OnValidate()
    {
        AreaCollider = GetComponent<SphereCollider>();
        AreaRenderer = GetComponent<MeshRenderer>();
    }

    private void Awake()
    {
        enabled = false;
        AreaRenderer.enabled = false;
    }

    private void OnEnable()
    {
        Explode();
    }

    private void Explode()
    {
        AreaRenderer.enabled = true;
        Exploding = true;
        ExplosionTimer = 0;
    }

    private void Update()
    {
        ExplosionTimer += GameClock.DeltaTime;
        if (ExplosionTimer > ExplosionTime)
        {
            AreaRenderer.enabled = false;
            Exploding = false;
            enabled = false;
        }
    }

    private void ApplyDamage(Health Hp)
    {
        switch(ExplosionDamageType)
        {
            case ExplosiveDamageType.Fixed:
                Hp.Damage(ExplosionDamage);
                break;
            case ExplosiveDamageType.Scale:
                Vector3 Displacement = Hp.transform.position - ExplosionHit;
                float Distance = Displacement.magnitude;
                float DamageRatio = DirectHit ? 1 : Distance > ExplosionRadius ? 0 : Distance / ExplosionRadius;
                Hp.Damage(ExplosionDamage * DamageRatio);
                break;
            case ExplosiveDamageType.InverseScale:
                Vector3 Displacement2 = Hp.transform.position - ExplosionHit;
                float Distance2 = Displacement2.magnitude;
                float DamageRatio2 = DirectHit ? 1 : Distance2 > ExplosionRadius ? 0 : 1 - Distance2 / ExplosionRadius;
                Hp.Damage(ExplosionDamage * DamageRatio2);
                break;
        }
    }
}
