/**
 * Difficulty : Easy
 * Language   : JavaScript
 * My Score   : 10 out of 10
 */

/**
 * Power Set Count
 * 
 * Have the function PowerSetCount(arr) take the array of integers 
 * stored in arr, and return the length of the power set (the number of all 
 * possible sets) that can be generated. For example: if arr is [1, 2, 3], then 
 * the following sets form the power set: 
 * 
 * []
 * [1]
 * [2]
 * [3]
 * [1, 2]
 * [1, 3]
 * [2, 3]
 * [1, 2, 3]
 * 
 * You can see above all possible sets, along with the empty set, are 
 * generated. Therefore, for this input, your program should return 8.
 * 
 * Examples
 * 
 * Input: [1, 2, 3, 4]
 * Output: 16
 * 
 * Input: [5, 6]
 * Output: 4
 */

function Factorial(n) {
    if (n == 0) {
        return 1;
    }
    else {
        return (n * Factorial(n - 1));
    }
}

function Permutation(n, r) {
    return (Factorial(n) / Factorial(n - r));
}

function Combination(n, r) {
    return (Factorial(n) / (Factorial(r) * Factorial(n - r)));
}

function PowerSetCount(arr) {
    if (arr === null)
        return 0;
    else {
        var set = 0;
        for (var i = 0; i <= arr.length; i++) {
            set += Combination(arr.length, i);
        }
        return set;
    }
}

console.log(PowerSetCount([1, 2, 3, 4]));
console.log(PowerSetCount([5, 6]));