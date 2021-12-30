/**
 * Difficulty : Medium
 * Language   : JavaScript
 * My Score   : 10 out of 10
 */

/**
 * Distinct List
 * 
 * Have the function DistinctList(arr) take the array of numbers
 * stored in arr and determine the total number of duplicate entries. For 
 * example if the input is [1, 2, 2, 2, 3] then your program should output 2
 * because there are two duplicates of one of the elements.
 * 
 * Examples
 * 
 * Input: [0,-2,-2,5,5,5]
 * Output: 3
 * 
 * Input: [100,2,101,4]
 * Output: 0
 */

function DistinctList(arr) {
    var duplicates = 0;
    const duplicated = [];

    for (var i = 0; i < arr.length; i++) {
        if (!duplicated.includes(arr[i])) {
            for (var j = i + 1; j < arr.length; j++) {
                if (arr[i] === arr[j]) {
                    duplicates++;
                    duplicated.push(arr[i]);
                }
            }
        }
    }

    return duplicates;
}

console.log(DistinctList([0, -2, -2, 5, 5, 5]));
console.log(DistinctList([100, 2, 101, 4]));