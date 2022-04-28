# Vector
This a minimal example to show an issue with MS Test 2.2.4 to 2.2.10. In some cases DynamicData seems to be mixing up the arguments of different test cases if structs are involved. MS Test up to version 2.2.3 doesn't have this problems. The problem does also not occur in versions 2.2.4 to 2.2.10 if I change the type of Vector2D from struct to class. 

# How to reproduce
I have prepared 4 branches:
| Branch               | Vector2D is | MS Test version | Problem occurs |
|:---------------------|:-----------:|:---------------:|:--------------:|
| struct-mstest-2.2.3  | struct      | 2.2.3           | no             |
| struct-mstest-2.2.10 | struct      | 2.2.10          | yes            |
| class-mstest-2.2.3   | class       | 2.2.3           | no             |
| class-mstest-2.2.10  | class       | 2.2.10          | no             |

There a three test methods in the test class that use DynamicData to fetch the test case from methods. All three test methods are similar. Only one of them shows the issue, while the other two are not affected.
