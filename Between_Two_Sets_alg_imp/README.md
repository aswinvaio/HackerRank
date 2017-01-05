# Between Two Sets
Consider two sets of positive integers,  and . We say that a positive integer, , is between sets  and  if the following conditions are satisfied:

All elements in  are factors of .
 is a factor of all elements in .
Given  and , find and print the number of integers (i.e., possible 's) that are between the two sets.

###Input Format

The first line contains two space-separated integers describing the respective values of  (the number of elements in set ) and  (the number of elements in set ). 
The second line contains  distinct space-separated integers describing . 
The third line contains  distinct space-separated integers describing .

###Constraints

###Output Format

Print the number of integers that are considered to be between  and .

###Sample Input

2 3
2 4
16 32 96
###Sample Output

3
###Explanation

The integers that are between  and  are , , and .