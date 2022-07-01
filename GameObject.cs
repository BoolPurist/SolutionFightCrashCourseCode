namespace Fighting;

public class GameObject : IFight
{
  protected int Hp;
  protected int Attack;
  
  public virtual int DealDamage()
  {
    return Attack;
  }

  public virtual void TakeDamage(int damageToTake)
  {
    Hp -= damageToTake;
  }

  public override string ToString()
  {
    return $"Hp: {Hp}, Attack: {Attack}";
  }
}