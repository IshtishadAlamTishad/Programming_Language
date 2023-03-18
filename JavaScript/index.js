// Basics of Javascripts

let name = "Tishad";
console.log(name);

let firstName = "Tishad", lastName = "Alam";
console.log(firstName);

// constants

let interestRate = 0.3;
interestRate=1;
console.log(interestRate);

const InterestRate=0.3;

// types 2 catagory
// primitive(value) & Reference

let name1 = "Tishad";
let age  = 23; // number literal
let isApproved = false;
let fName = undefined; 
let lName = null;



// object 

let person = {
    name: "Tishad",
    age: 23
};
// Dot Notation
person.name = "Mike";

// Bracket Notation
let selection = "name";
person[selection] = "David";

console.log(person.name);


// Arrays

let selectedColours = ['red',"blue"];

selectedColours[2] = 'Green';

console.log("First Element in Array = "+selectedColours[0]);
console.log("Colours = " + selectedColours);
console.log("Length = "+selectedColours.length);


// Function

function Welcome() {
    console.log("Hello User");
}

Welcome();

function Name(name) {
    console.log('Welcome '+name);
}
Name('Tishad');
Name('Mike');
Name('Lisa');

function info(firstName,LastName) {
    console.log("Hello " + firstName + " " + LastName);
}

info("Ishtishad Alam","Tishad");

function square(num) {
    return num*num;
}
console.log(square(2));