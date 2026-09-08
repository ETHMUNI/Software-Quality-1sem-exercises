## 1. Equivalence partitions
### Height:
Valid partitions:
* 30 - 60

Invalid partitions
* Below 30
* Higher than 60
* 0
* non numeric numbers

### Width
Valid partitions:
* 30 - 100

Invalid partitions:
* Below 30
* Higher than 100
* 0
* non numeric numbers

### Area
Valid partitions:
* 900 - 6000 cm2

Invalid partitions:
* Below 900
* Higher 6000
* non numerics numbers
* 0

### Test cases
* Height: 35, 45, 55
* Width: 50, 70, 90
* Area: 2175, 3450, 4725

## 2. Boundry analysis(3-way approach)

Height Boundry values:
* 0 (invalid)
* 29.9 (invalid)
* 30 (valid)
* 60 (valid)
* 60.1 (invalid)

Width boundry values:
* 0 (invalid)
* 29.9 (invalid)
* 30 (valid)
* 100 (valid)
* 100.1 (invalid)

Area boundry values:
* 0 (invalid)
* 899.9 (invalid)
* 900 (valid)
* 6000 (valid)
* 6000.1 (invalid)

### Test case values
Height list: 0, 29.9, 30, 45, 55, 60, 60.1
Width list: 0, 29.9, 30, 50, 70, 90, 100, 100.1
Area list: 0, 899.9, 900, 2175, 3450, 4725, 6000, 6000.1

