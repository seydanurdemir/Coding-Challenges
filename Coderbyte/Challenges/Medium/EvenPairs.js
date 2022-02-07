/**
 * Difficulty : Medium
 * Language   : JavaScript
 * My Score   : 10 out of 10
 */

/**
 * Even Pairs
 * 
 * Have the function EvenPairs(str) take the str parameter being 
 * passed and determine if a pair of adjacent even numbers exists 
 * anywhere in the string. If a pair exists, return the string true, otherwise 
 * return false. For example: if str is "f178svg3k19k46" then there are two 
 * even numbers at the end of the string, "46" so your program should 
 * return the string true. Another example: if str is "7r5gg812" then the pair 
 * is "812" (8 and 12) so your program should return the string true.
 * 
 * Examples
 * 
 * Input: "3gy41d216"
 * Output: true
 * 
 * Input: "f09r27i8e67"
 * Output: false
 */

function IsLetter(c) {
    return (/[a-zA-Z]/).test(c);
}

function IsNumber(n) {
    return (/[0-9]/).test(n);
}

function IsEven(str) {
    var n = 0;
    n = str[str.length - 1];

    if ((n % 2) == 0)
        return true;
    else
        return false;
}

function IsEvenPair(str) {
    if (str.length == 1) {
        return false;
    } else {
        var pair1 = "";
        var pair2 = "";

        for (var i = 1; i < str.length; i++) {
            pair1 = str.slice(0, i);
            pair2 = str.slice(i, str.length);
            if (IsEven(pair1) && IsEven(pair2)) {
                return true;
            }
        }

        return false;
    }
}

function TakeNumbers(arr) {
    var substr = "";
    const subarr = [];

    for (var i = 0; i <= arr.length; i++) {
        if (IsLetter(arr[i])) {
            subarr.push(substr);
            substr = "";
        } else {
            substr = substr.concat(arr[i]);
        }
    }

    return subarr;
}

function IncludesEvenPair(arr) {
    for (var i = 0; i < arr.length; i++) {
        if (IsEvenPair(arr[i])) {
            return true;
        }
    }

    return false;
}

function EvenPairs(str) {
    if (IncludesEvenPair(TakeNumbers(str.split("")))) {
        return "true";
    } else {
        return "false";
    }
}

console.log(EvenPairs("3gy41d216"));
console.log(EvenPairs("f09r27i8e67"));