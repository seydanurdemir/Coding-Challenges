/**
 * Difficulty : Easy
 * Language   : JavaScript
 * My Score   : 9 out of 10
 */

/**
 * AB Check
 * 
 * Have the function ABCheck(str) take the str parameter being passed 
 * and return the string true if the characters a and b are separated by 
 * exactly 3 places anywhere in the string at least once (ie. "lane borrowexd" 
 * would result in true because there is exactly three characters between a 
 * and b). Otherwise return the string false.
 * 
 * Examples
 * 
 * Input: "after badly"
 * Output: false
 * 
 * Input: "Laura sobs"
 * Output: true
 */

function ABCheck(str) {
    for (var i = 0; i < str.length; i++) {
        // Note : You can check whether [i+4] is out of str range or note
        if ((str.split("")[i] === "a") && (str.split("")[i + 4] === "b")) {
            return true;
        }
    }

    return false;
}

console.log(ABCheck("after badly"));
console.log(ABCheck("Laura sobs"));