// int maximum(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// // int max1 = maximum(a1, b1, c1);
// // int max2 = maximum(a2, b2, c2);
// // int max3 = maximum(a3, b3, c3);

// int max = maximum(
//     maximum(a1, b1, c1), 
//     maximum(a2, b2, c2), 
//     maximum(a3, b3, c3));

// Console.WriteLine(max);


// ARRAYS

// int maximum(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
// array[0] = 12;
// // Console.WriteLine(array[0]);

// int max = maximum(
//     maximum(array[0], array[1], array[2]),
//     maximum(array[3], array[4], array[5]),
//     maximum(array[6], array[7], array[8])
// );
// Console.WriteLine(max);