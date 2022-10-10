const food = ["pizza", " burger", " fingerChips", " donut", " springRoll"];

// Function #1: Array Slice

document.write("<h3>Array Slice </h3> <br>")

const modifiedFood1 = food.slice(1, 4);
document.write(modifiedFood1);

// Function #2: Array Splice

document.write("<h3>Array Splice </h3> <br>")
food.splice(2, 0, "noodles", "icecream");
const modifiedFood2 = food;
document.write(modifiedFood2);


// Function #3: Filter

document.write("<h3>Array Filter </h3> <br>")

const numberArray = [12, 324, 213, 4, 2, 3, 45, 4234];
const isEven = numberArray.filter(iseven);
function iseven(element) {
    return element % 2 == 0 ? true : false;
}
document.write(isEven)

const isPrime = numberArray.filter(ele => {
    for (var i = 2; i < ele; i++) {
        if (ele % i == 0) return false;
    }
    return true;
});
document.write("<br>Prime Number :"+isPrime);

// Function #4: Reject

document.write("<h3>Array Reject </h3> <br>")

const non_Prime = numberArray.filter(ele=>{
        for(var i=2;i<ele;i++){
            if(ele%i==0) return true;
        }
        return false;
    });
    document.write(non_Prime);

// Function #5: Lambda

document.write("<h3>Lambda </h3> <br>")

const isEvn = numberArray.filter(even=>even%2==0?true:false);
document.write(isEvn);

//Function #6: Map

document.write("<h3>Map </h3> <br>")

const myArr = [11, 34, 20, 5, 53, 16];
const Square_array = myArr.map(function findSquareOfNumbers(ele){
     return ele*ele;
});
document.write(Square_array);


// Function #7: Reduce

document.write("<h3>Reduce </h3> <br>")
const myArray = [2, 3, 5, 10];

// 1.method
var total_mul = myArray.reduce((total,ele)=> total*=ele);
document.write(total_mul+"<br>");

// 2. method

var total_mul =myArray.reduce(multiply);
function multiply(total,ele){
    return total *=ele;
}
document.write(total_mul);

