namespace Fighting;

public class Ork : GameObject
{
  private int _increaseAttackFactor;
  
  public Ork(int hp , int attack, int increaseAttackFactor)
  {
    Hp = hp;
    Attack = attack;
    _increaseAttackFactor = increaseAttackFactor;
  }

  public override int DealDamage()
  {
    int newAttackDamage = Attack;
    Attack += _increaseAttackFactor;
    return newAttackDamage;
  }
  
  public override string ToString()
  {
    return $"Hp: {Hp}, Attack: {Attack}, Increase Damage Factor: {_increaseAttackFactor}";
  }
}