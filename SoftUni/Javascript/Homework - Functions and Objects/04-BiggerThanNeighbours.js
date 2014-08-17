function isBigger(index, arr) {
    if (index >= arr.length || index < 0) {
        console.log("invalid index");
    } else if (index === 0 || index === arr.length - 1) {
        console.log("only one neighbour");
    } else if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
        console.log("bigger");
    } else {
        console.log("not bigger");
    }
}
isBigger(2, [1, 2, 3, 3, 5 ]);
isBigger(2, [1, 2, 5, 3, 4 ]);
isBigger(5, [1, 2, 5, 3, 4 ]);
isBigger(0, [1, 2, 5, 3, 4 ]);