namespace Fighting;

public delegate void EventWithNumber(int number);

public class GameObject : IFight
{
  
  
  protected int Hp;
  protected int Attack;

  public event EventWithNumber HasDied;
  
  public virtual int DealDamage()
  {
    return Attack;
  }

  public virtual void TakeDamage(int damageToTake)
  {
    Hp -= damageToTake;
    if (Hp <= 0 && HasDied != null)
    {
      HasDied.Invoke(damageToTake);
    }
  }

  public override string ToString()
  {
    return $"Hp: {Hp}, Attack: {Attack}";
  }
}