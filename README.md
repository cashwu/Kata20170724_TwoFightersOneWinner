# [Two fighters, one winner.](https://www.codewars.com/kata/577bd8d4ae2807c64b00045b)

---

Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having `health <= 0`.

Each fighter will be a `Fighter` object/instance. See the Fighter class below in your chosen language.

Both `health` and `damagePerAttack` (`damage_per_attack` for python) will be integers larger than `0`. You can mutate the `Fighter` objects.

## Example:
```
  declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew") => "Lew"

  // Python
  declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"

  Lew attacks Harry; Harry now has 3 health.
  Harry attacks Lew; Lew now has 6 health.
  Lew attacks Harry; Harry now has 1 health.
  Harry attacks Lew; Lew now has 2 health.
  Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.
```

---

### 中文大意

模擬兩個人戰鬥，健康降到 0 就死了，有先後攻擊的差別
