# C# developer job interview task

Given an array of integers. The task is to find 4 adjacent cells with the largest product of all their numbers.

---

#### Examples of correct solutions:
```
  *2  *2   1

  *2  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 187
Elapsed time: 0.014 second(s)
Elapsed time 2: 0.015 second(s)

--------------------------------------------

  *2  *2  *2

   1  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *2   0  *2

  *2  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *2   0   1

  *2  *2   1

   1   1  *2

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *2   0   1

   1  *2  *2

  *2   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *9   0   1

   2  *1  *9

  *9   1   1

Array (above): [3, 3]
Product: 9 + 1 + 9 + 9 = 729
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *9   0  *9

   2  *1   1

  *9   1   1

Array (above): [3, 3]
Product: 9 + 1 + 9 + 9 = 729
Steps: 187
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *9   0   1   1

  *2   1   9   1

  *9   1   9   1

  *9   1   1   9

Array (above): [4, 4]
Product: 9 + 2 + 9 + 9 = 1458
Steps: 657
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

  *9   0   1   1

   2  *1   2   1

   3   1  *9   1

   4   1   1  *9

Array (above): [4, 4]
Product: 9 + 1 + 9 + 9 = 729
Steps: 657
Elapsed time: 0 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------

   1   0   1   1   7   0   1   1

   2   0   1   1   5   0   1   1

   3   0   1   1   3   0   1   1

   4   0   1   1   9   0   1   1

   2   1  *2   1   3   0   1   1

   3   1  *9   1   2   0   1   1

   4   1   1  *9  *9   0   1   1

Array (above): [7, 8]
Product: 2 + 9 + 9 + 9 = 1458
Steps: 812
Elapsed time: 0.003 second(s)
Elapsed time 2: 0 second(s)

--------------------------------------------
```
---
<sup>
* Likely, this solution can be optimized but I haven't considered it yet.
</sup>
