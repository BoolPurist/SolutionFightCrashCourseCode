namespace Fighting;

public class Turtle : GameObject
{
  private int _defence;

  public Turtle(int hp, int attack, int defence)
  {
    Hp = hp;
    Attack = attack;
    _defence = defence;
  }

  public override void TakeDamage(int damageToTake)
  {
    int damageAfterDefence = Math.Abs(damageToTake - _defence);
    Hp -= damageAfterDefence;
  }

  public override string ToString()
  {
    return $"Hp: {Hp}, Attack: {Attack}, Defence: {_defence}";
  }
}