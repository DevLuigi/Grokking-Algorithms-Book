function binarySearch(array, item) {
    let low = 0;
    let middle = 0;
    let high = array.length - 1;
    let guess;

    while (low <= high) {
        middle = Math.floor(low + high / 2);
        guess = array[middle];

        if (guess == item) {
            return middle;
        }

        if (guess > item) {
            high = middle - 1;
        } else {
            low = middle + 1;
        }
    }

    return -1;
}

const array = [1,2,3,4,5,6,7,8];

let start = performance.now();
console.log(binarySearch(array, 10));
let end = performance.now();

console.log(`A função levou ${Math.round(end - start, 2)}ms para ser executada!`);