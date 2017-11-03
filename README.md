# RotateMatrix

https://stackoverflow.com/questions/42519/how-do-you-rotate-a-two-dimensional-array<br/>
We were able to visualize what the problem domain would look like.  Both is a 2d and linear view.  We looked up some tutorials and discoved how to impliment this using a RotateMatrix helper using a couple of nested for loops.  We first create a new matrix and set it to size n by n, then we set each position equal to the next position minus one of the original array.  When the loop is finished we return the new loop and print it.  This has a Big O value of O(N)^2
