# Job interview task

Given an array of integers. The task is to find 4 adjacent cells with the largest product of all their numbers.

---

#### Examples of correct solutions:
```
  *2  *2   1

  *2  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 297
Elapsed time: 0.028 second(s)

--------------------------------------------

  *2  *2  *2

   1  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *2   0  *2

  *2  *2   1

   1   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *2   0   1

  *2  *2   1

   1   1  *2

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *2   0   1

   1  *2  *2

  *2   1   1

Array (above): [3, 3]
Product: 2 + 2 + 2 + 2 = 16
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *9   0   1

   2  *1  *9

  *9   1   1

Array (above): [3, 3]
Product: 9 + 1 + 9 + 9 = 729
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *9   0  *9

   2  *1   1

  *9   1   1

Array (above): [3, 3]
Product: 9 + 1 + 9 + 9 = 729
Steps: 297
Elapsed time: 0 second(s)

--------------------------------------------

  *9   0   1   1

  *2   1   9   1

  *9   1   9   1

  *9   1   1   9

Array (above): [4, 4]
Product: 9 + 2 + 9 + 9 = 1458
Steps: 1240
Elapsed time: 0 second(s)

--------------------------------------------

  *9   0   1   1

   2  *1   2   1

   3   1  *9   1

   4   1   1  *9

Array (above): [4, 4]
Product: 9 + 1 + 9 + 9 = 729
Steps: 1240
Elapsed time: 0 second(s)

--------------------------------------------

  *1   0   1   1   7   0   1   1

  *2   0   1   1   5   0   1   1

  *3   0   1   1   3   0   1   1

  *4   0   1   1   9   0   1   1

   2   1   2   1   3   0   1   1

   3   1   9   1   2   0   1   1

   4   1   1   9   9   0   1   1

Array (above): [7, 8]
Product: 1 + 2 + 3 + 4 = 24
Steps: 6200
Elapsed time: 0 second(s)

--------------------------------------------
```
---
*P.S.

Perhaps this solution can be optimized, but I haven't considered it yet.*
