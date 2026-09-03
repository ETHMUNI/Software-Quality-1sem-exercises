## 1. Equivalence partitions
Valid partitions - based on input
* 0.1 - 300
* 300.01 - 800
* 800.01 - max float

Note: Conceptionally there are no invalid partitions, since you can't make a purchase with any of these points in the real world.
But the system might take these as valid input, therefore they are worth to consider.

Invalid partitions:
* 0
* negative floats
* non float numerics

Test cases(middle values):
* 150
* 450
* 950

## 2. Boundry analysis(3-way approach)

Boundry Values:
* 0-299.01
* 300-800
* 800.01

Test case values:
* 0, 1
* 299.01, 300, 300.01
* 799,01, 800, 800.01

List: 0, 1, 150, 299.01, 300, 300.01, 450, 799,01, 800, 800.01, 950