using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    [Header("UI References")]
    public Image healthBarFill;

    protected override void Start()
    {
        // Gọi Start của lớp cha để khởi tạo máu
        base.Start();
        UpdateHealthBar();
    }

    public override void TakeDamage(int damage)
    {
        // Gọi logic trừ máu của lớp cha
        base.TakeDamage(damage);
        // Sau đó cập nhật thanh máu trên màn hình
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (healthBarFill != null)
        {
            // Tính toán tỷ lệ fillAmount (từ 0 đến 1)
            healthBarFill.fillAmount = (float)healthPoint / defaultHealthPoint;
        }
    }
}