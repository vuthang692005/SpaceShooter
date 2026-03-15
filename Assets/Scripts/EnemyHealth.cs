using UnityEngine;
using UnityEngine.UI; // Cần thiết để điều khiển thanh máu

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;

    [Header("UI References")]
    public Image healthBarFill; // Kéo thanh máu của Enemy vào đây

    private void Awake()
    {
        LivingEnemyCount++;
    }

    protected override void Start()
    {
        base.Start(); // Gọi khởi tạo máu từ lớp Health
        UpdateHealthBar();
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage); // Gọi logic trừ máu và nổ của lớp cha
        UpdateHealthBar(); // Cập nhật thanh máu sau mỗi lần bị bắn
    }

    void UpdateHealthBar()
    {
        if (healthBarFill != null)
        {
            // Tỷ lệ = máu hiện tại / máu tối đa
            healthBarFill.fillAmount = (float)healthPoint / defaultHealthPoint;
        }
    }

    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
    }
}