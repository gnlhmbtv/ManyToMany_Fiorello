// console.log("Hello, ");
// const asyncExample=()=>{
//     setTimeout(() => {
//         console.log("How are you?");
//     }, 500);
// };
// asyncExample();
// console.log("World");




// function calculator(a, b, callback){
//     let addition = a + b;
//     let substraction = a - b;
//     let multiplication = a * b;
//     let division = a / b;
 
//     let results={
//         addition: addition,
//         substraction: substraction,
//         multiplication: multiplication,
//         division: division
//     };
 
//     //Make the third param, callback functin optional
//     if (callback && typeof(callback) === "function") {
//         callback(results); //call the function that was passed in 
//     }
// }
 
// calculator(10, 2);
// calculator(10, 2, function(rslt){
//     console.log(rslt);
// });
//??????????????



// function greeting(name) {
//     alert('Hello ' + name);
//   }
  
//   function processUserInput(callback) {
//     var name = prompt('Please enter your name.');
//     callback(name);
//   }
//   processUserInput(greeting);


function sum(num1,num2) {
    return num1+num2
}
function subtract(num1,num2) {
    return num1-num2
}
function multiply(num1,num2) {
    return num1*num2
}
function divide(num1,num2) {
    return num1/num2
}
function calculate(num1,num2,callback) {
  return callback(num1,num2);
}
let result = calculate(5,6,subtract);
console.log(result);


// function myDisplayer(some) {
//     document.getElementById("demo").innerHTML = some;
//   }
  
//   function myCalculator(num1, num2) {
//     let sum = num1 + num2;
//     let multiply=num1*num2;
//     return sum;
//   }
  
//   let result = myCalculator(5, 5);
//   myDisplayer(result);
  
  