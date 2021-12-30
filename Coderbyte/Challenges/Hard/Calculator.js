/**
 * Difficulty : Hard
 * Language   : JavaScript
 * My Score   : 12 out of 15
 */

/**
 * Calculator
 * 
 * Have the function Calculator(str) take the str parameter being 
 * passed and evaluate the mathematical expression within in. For
 * example, if str were "2+(3-1)*3" the output should be 8. Another 
 * example: if str were "(2-0)(6/2)" the output should be 6. There can be 
 * parenthesis withşn the string so you must evaluate it reply 
 * according to the rules of arithmetic. The string will contain the 
 * operator: +,-,/,*,(, and ). If you have a string like this: #/#*# or #+# 
 * (#)/#, then evaluate from left to right. So divide then multiply, and for 
 * the second one multiply, divide, then add. The evaluations will be such 
 * that there will not be any decimal operations, so you do not need to 
 * account for rounding and whatnot.
 * 
 * Examples
 * 
 * Input: "6*(4/2)+3*1"
 * Output: 15
 * 
 * Input: "6/3-1"
 * Output: 1
 */

function Calculator(str) {
    // Note : JavaScript already has a method that performs this function.
    return eval(str);
}

console.log(Calculator("6*(4/2)+3*1"));
console.log(Calculator("6/3-1"));