using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;
    public Action onDead;

    // 1. Đổi private thành protected để PlayerHealth truy cập được
    protected int healthPoint;

    // 2. Thêm virtual cho Start để lớp con có thể ghi đè nếu cần
    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    // 3. THÊM TỪ KHÓA VIRTUAL Ở ĐÂY để sửa lỗi CS0506
    public virtual void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
        onDead?.Invoke();
    }
}