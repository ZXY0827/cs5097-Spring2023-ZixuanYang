# cs5097-Spring2023-ZixuanYang
1.To calculate intervening points you can simply calculate the translation vector and divide by 10 and add this to the initial start position and so on. But what if the loop iterates indefinitely and the input is a direction vector (a vector that simply shows the direction the object is moving)? How would you calculate the intermediate positions if you don't know the destination (or even how long the object will travel)?

If the loop iterates indefinitely and the input is a direction vector, we can calculate the intermediate positions by continuously updating the position of the object based on direction vector and fixed time step. For example, if the direction vector is (x, y, z) and the time step is t, the position of the object will be(xt, yt, zt) at each iteration of the loop. However, the method assumes that the object moves at a constant velocity, and the direction vector is given by velocity.If the object's velocity is not constant, we need additional information such as the object's acceleration to calculate the intermediate positions.

2.You can use simple arrays to do this problem, but you can also use a vector math library (which was optional), why or why not did you use a library?

For performing vector operations, it is easy to use vector math libraries such as dot product, cross product and vector addition. We can also optimize these operations, which is more convenient and faster than writing code by myself.
However, sometimes using libraries may increase the complexity of the code, and there may be more additional dependencies that need to depend on.
If we are working on a small project or with limited resources, it might be more efficient to use simple arrays and implement the necessary vector operations ourselves. On the other hand, if we are working on a large project with lots of vector operations or need to optimize performance, we can use a vector math library which might help for us.
