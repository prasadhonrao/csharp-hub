int[] numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ];

bool result = false;

result = numbers is [ 1, _, 3, _, 5, _, 7, _, 9 ];

Console.WriteLine(result);
