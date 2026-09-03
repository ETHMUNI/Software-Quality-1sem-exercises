# Password field

## Assignment
A password field accepts a minimum of 6 characters and a maximum of 10 characters. Define:

1. Its corresponding equivalence partitions and test case values
2. The boundary values and resulting test case values with a 3-boundary value approach
3. The final list of test case values

## Solution

### Equivalence partitions
Valid Partitions: 6-10 

Invalid Partitions:
* 1-5 
* 11 - max char
* 0
* Negative numbers of characters

#### Test cases(middle values)
* 8

### boundary values + test cases
Invalid lower boundary: 5
Valid lower boundaries: 6, 7 
Valid upper boundaries: 9, 10
Invalid upper boundary: 11

Invalid boundaries: 5, 11
Valid boundaries: 6, 7, 9, 10

#### Test case values (3-value approach):
List: 5, 6, 7, 9, 10, 11


